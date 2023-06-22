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
    public partial class AdminManageSchedule : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결

        bool show_all = false;

        public AdminManageSchedule()
        {
            InitializeComponent();
            idbox.ForeColor = Color.Transparent;
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            String query = "select 역순번 from 구간";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OleDbDataReader read = cmd.ExecuteReader();

            ArrayList array = new ArrayList();
            while (read.Read())
            {

                array.Add(read.GetValue(0).ToString());
            }
            object[] obj = new object[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                obj[i] = array[i];
            }

            conn.Close();
            //this.comboBox1.Items.AddRange(obj);
            //this.comboBox1.SelectedIndex = 0;

            GridViewRefresh();

        }
        private void GridViewRefresh()
        {
            Train_Text.Text = "";
            Train_Type_Text.Text = "";
            Depart_Text.Text = "";
            Depart_Station_Text.Text = "";
            Arrival_Text.Text = "";
            Arrival_Station_Text.Text = "";
            Fare_Text.Text = "";

            Train_Schedule_View.DataSource = null;
            Train_Schedule_View.Rows.Clear();

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            String query = "select 역순번 as 역순번, 열차번호 as 열차번호, 열차등급 as 열차등급, 출발시간 as 출발시간,출발역 as 출발역, 도착시간 as 도착시간, 도착역 as 도착역, 운임료 as 운임료, 방향 as 방향 from 구간 order by 역순번";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;

            Train_Schedule_View.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                Train_Schedule_View.Columns[i].Name = read.GetName(i);
            }
            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                Train_Schedule_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            conn.Close();
            try
            {
                String id = (String)Train_Schedule_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                cmd.CommandText = "select * from 구간 where 역순번 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                read = cmd.ExecuteReader(); //select  결과
                if(read.Read())
                {
                    Train_Text.Text = read.GetValue(1).ToString();
                    Train_Type_Text.Text = read.GetValue(2).ToString();
                    Depart_Text.Text = read.GetValue(3).ToString();
                    Depart_Station_Text.Text = read.GetValue(4).ToString();
                    Arrival_Text.Text = read.GetValue(5).ToString();
                    Arrival_Station_Text.Text = read.GetValue(6).ToString();
                    Fare_Text.Text = read.GetValue(7).ToString();
                    

                }
            }
            catch(Exception ex)
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
        private void GridViewRefresh2()
        {
            Train_Text.Text = "";
            Train_Type_Text.Text = "";
            Depart_Text.Text = "";
            Depart_Station_Text.Text = "";
            Arrival_Text.Text = "";
            Arrival_Station_Text.Text = "";
            Fare_Text.Text = "";

            String DCB = Depart_CB.Text.Trim();
            String ACB = Arrival_CB.Text.Trim();

            Train_Schedule_View.DataSource = null;
            Train_Schedule_View.Rows.Clear();
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            String query = "select 역순번 as 역순번, 열차번호 as 열차번호, 열차등급 as 열차등급, 출발시간 as 출발시간,출발역 as 출발역, 도착시간 as 도착시간, 도착역 as 도착역, 운임료 as 운임료 from 구간 where 출발역 = '" + DCB + "'AND 도착역 = '"+ ACB + "'";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;


            Train_Schedule_View.ColumnCount = count;

            for (int i = 0; i < count; i++)
            {
                Train_Schedule_View.Columns[i].Name = read.GetName(i);
            }

            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                Train_Schedule_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }

            conn.Close();

            try
            {
                String id = (String)Train_Schedule_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결

                String DCB2 = Depart_CB.Text.Trim();
                String ACB2 = Arrival_CB.Text.Trim();

                cmd.CommandText = "select 역순번 as 역순번, 열차번호,출발역,도착역,출발시간,도착시간,운임료 from 구간 where 출발역 = '" + DCB2 + "'AND 도착역 = '" + ACB2 + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Train_Text.Text = read.GetValue(1).ToString();
                    Train_Type_Text.Text = read.GetValue(2).ToString();
                    Depart_Text.Text = read.GetValue(3).ToString();
                    Depart_Station_Text.Text = read.GetValue(4).ToString();
                    Arrival_Text.Text = read.GetValue(5).ToString();
                    Arrival_Station_Text.Text = read.GetValue(6).ToString();
                    Fare_Text.Text = read.GetValue(7).ToString();

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



        private void Train_Schedule_View_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            String id = (String)Train_Schedule_View.Rows[e.RowIndex].Cells[0].Value;
            Console.WriteLine(id);
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                idbox.Text = id;
                cmd.CommandText = "select * from 구간 where 역순번 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Train_Text.Text = read.GetValue(1).ToString();
                    Train_Type_Text.Text = read.GetValue(2).ToString();
                    Depart_Text.Text = read.GetValue(3).ToString();
                    Depart_Station_Text.Text = read.GetValue(4).ToString();
                    Arrival_Text.Text = read.GetValue(5).ToString();
                    Arrival_Station_Text.Text = read.GetValue(6).ToString();
                    Fare_Text.Text = read.GetValue(7).ToString();
                }
            }
            catch(Exception ex)
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
        private void Delete_Schedule_btn_Click(object sender, EventArgs e)
        {
            int selectedCellCount = Train_Schedule_View.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 0)
            {
                MessageBox.Show("삭제할 대상을 선택해주세요", "삭제 불가");
                return;
            }
            if (selectedCellCount > 0)
            {
                int row = Train_Schedule_View.SelectedCells[0].RowIndex;
                for (int i = 0; i < selectedCellCount; i++)
                {
                    if (row != Train_Schedule_View.SelectedCells[i].RowIndex)
                    {
                        MessageBox.Show("한번에 한개만 삭제 가능합니다.", "삭제 불가");
                        return;
                    }

                }

                String Order = Train_Schedule_View.Rows[row].Cells[0].Value.ToString();
                String Train_Type = Train_Schedule_View.Rows[row].Cells[1].Value.ToString();
                if (MessageBox.Show($"해당 운행을 삭제할까요?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn = new OleDbConnection(connectionString);
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    String query = $"delete  from 구간 where 역순번='{Order}'";
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {

                    }
                    MessageBox.Show($"해당 운행이 삭제되었습니다.", "삭제 성공");
                    GridViewRefresh();
                    conn.Close();
                }
            }
        }
        private void LookUp_btn_Click(object sender, EventArgs e)
        {
            GridViewRefresh2();
        }


        private void Add_Schedule_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            AdminAddSchedule f = new AdminAddSchedule();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Depart_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
