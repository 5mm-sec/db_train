using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DB_Train
{
    public partial class AddTrain : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        String id;
        bool isEdit;
        public AddTrain()
        {
            InitializeComponent();
            this.isEdit = false;
        }
        public AddTrain(String id)
        {
            this.isEdit = true;
            this.id = id;
            InitializeComponent();

            Train_Text.ReadOnly = true;
            Train_Type_Text.ReadOnly = true;

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 열차 where 열차번호 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Train_Text.Text = read.GetValue(1).ToString();
                    Train_Type_Text.Text = read.GetValue(2).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        private void Regi_Train_btn_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            OleDbCommand cmd = new OleDbCommand();
            if (MessageBox.Show("정말로 저장 할까요?", "저장 안내", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            if (!isEdit)
            {
                String query = $"insert into 열차 values ('{Train_Text.Text.Trim()}','{Train_Type_Text.Text.Trim()}')";
                cmd.CommandText = query;
                Console.WriteLine(query);

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                try
                {
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    cmd.Parameters.Clear();
                    conn.Close();
                    MessageBox.Show("성공적으로 저장되었습니다", "열차 등록 성공");
                    Train_Text.Text = "";
                    Train_Type_Text.Text = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("입력을 확인해주세요1");
                }
            }
            else
            {
                String query = $"update 열차 set 열차번호 = '{Train_Text.Text.Trim()}'" +
                    $" , 열차등급='{Train_Type_Text.Text.Trim()}'";
                Console.WriteLine(query);
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                try
                {
                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    cmd.Parameters.Clear();
                    conn.Close();
                    MessageBox.Show("성공적으로 수정되었습니다", "열차 등록 성공");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("입력을 확인해주세요2");
                }
            }

        }

    }
}
