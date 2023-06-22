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
using System.Collections;



namespace DB_Train
{
    public partial class AdminMangeMember : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결

        bool show_all = false;
        public AdminMangeMember()
        {
            InitializeComponent();
            GridViewRefresh();
        }
        private void GridViewRefresh()
        {
            Member_View.DataSource = null;
            Member_View.Rows.Clear();

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            String query = "select 아이디,이름,전화번호,등급 from 회원 where not 아이디='admin'";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;


            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;

            Member_View.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                Member_View.Columns[i].Name = read.GetName(i);
            }
            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                Member_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            conn.Close();


            try
            {
                String id = (String)Member_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                cmd.CommandText = "select * from 회원";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Id_Text.Text = read.GetValue(0).ToString();
                    Name_Text.Text = read.GetValue(2).ToString();
                    Grade_Text.Text = read.GetValue(4).ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                }
            }
        }
        private void Info_Change_btn_Click(object sender, EventArgs e)
        {

            string ID = "";
            ID = Id_Text.Text;

            if (MessageBox.Show("회원 정보를 수정하시겠습니까?", "저장하기", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                conn = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                String query = $"update 회원 set 이름='{Name_Text.Text}',등급='{Grade_Text.Text}' where 아이디 = '{Id_Text.Text}'";

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("수정이 완료되었습니다.", "수정 성공");
            }
        }
        private void Member_View_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            String id = (String)Member_View.Rows[e.RowIndex].Cells[0].Value;
            Console.WriteLine(id);
            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                idbox.Text = id;
                cmd.CommandText = "select * from 회원 where 아이디 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Id_Text.Text = read.GetValue(0).ToString();
                    Name_Text.Text = read.GetValue(2).ToString();
                    Grade_Text.Text = read.GetValue(4).ToString();
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
    }
}
