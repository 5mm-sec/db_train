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
    public partial class UserTicketing : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        String email;
        public UserTicketing(String email)
        {
            InitializeComponent();
            this.email = email;
        }
        private void GridViewRefresh()
        {
            Order_Text.Text = "";
            Depart_Station_Text.Text = "";
            Arrival_Station_Text.Text = "";
            Depart_Date_Text.Text = "";
            Arrival_Date_Text.Text = "";
            Fare_Text.Text = "";

            Schedule_View.DataSource = null;
            Schedule_View.Rows.Clear();
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            String query = "select 역순번 as 역순번, 열차번호 as 열차번호, 열차등급 as 열차등급, 출발시간 as 출발시간,출발역 as 출발역, 도착시간 as 도착시간, 도착역 as 도착역, 운임료 as 운임료 from 구간 order by 열차번호";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;

            Schedule_View.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                Schedule_View.Columns[i].Name = read.GetName(i);
            }

            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                Schedule_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            conn.Close();
            try
            {
                String id = (String)Schedule_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                cmd.CommandText = "select 역순번 as 역순번, 열차번호,출발역,도착역,출발시간,도착시간,운임료 from 구간 where 열차번호 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Order_Text.Text = read.GetName(0).ToString();
                    Train_Text.Text = read.GetName(1).ToString();
                    Depart_Station_Text.Text = read.GetValue(2).ToString();
                    Arrival_Station_Text.Text = read.GetValue(3).ToString();
                    Depart_Date_Text.Text = read.GetValue(4).ToString();
                    Arrival_Date_Text.Text = read.GetValue(5).ToString();
                    Fare_Text.Text = read.GetValue(6).ToString();
                    Console.Out.WriteLine(read);

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
        private void Lookup_btn_Click(object sender, EventArgs e)
        {
            GridViewRefresh2();
        }
        private void GridViewRefresh2()
        {
            Order_Text.Text = "";
            Train_Text.Text = "";
            Depart_Station_Text.Text = "";
            Arrival_Station_Text.Text = "";
            Depart_Date_Text.Text = "";
            Arrival_Date_Text.Text = "";
            Fare_Text.Text = "";

            Schedule_View.DataSource = null;
            Schedule_View.Rows.Clear();
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            String DCB = Depart_Station_CB.Text.Trim();
            String ACB = Arrival_Staion_CB.Text.Trim();
            String query = "select 역순번 as 역순번,열차번호 as 열차번호, 열차등급 as 열차등급, 출발시간 as 출발시간,출발역 as 출발역, 도착시간 as 도착시간, 도착역 as 도착역, 운임료 as 운임료 from 구간 where 출발역 = '"+ DCB + "'AND 도착역 = '" + ACB + "'";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;

            Schedule_View.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                Schedule_View.Columns[i].Name = read.GetName(i);
            }

            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                Schedule_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            //String idr = (String)Schedule_View.Rows[0].Cells[0].Value;
            //idBox.Text = idr;

            conn.Close();
            try
            {
                String id = (String)Schedule_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결

                String DCB2 = Depart_Station_CB.Text.Trim();
                String ACB2 = Arrival_Staion_CB.Text.Trim();

                cmd.CommandText = "select 역순번 as 역순번, 열차번호,출발역,도착역,출발시간,도착시간,운임료 from 구간 where 출발역 = '" + DCB2 + "'AND 도착역 = '" + ACB2 + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Order_Text.Text = read.GetValue(0).ToString();
                    Train_Text.Text = read.GetValue(1).ToString();
                    Depart_Station_Text.Text = read.GetValue(2).ToString();
                    Arrival_Station_Text.Text = read.GetValue(3).ToString();
                    Depart_Date_Text.Text = read.GetValue(4).ToString();
                    Arrival_Date_Text.Text = read.GetValue(5).ToString();
                    Fare_Text.Text = read.GetValue(6).ToString();
                    Console.Out.WriteLine(read);

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
        private void Schedule_View_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            String id = (String)Schedule_View.Rows[e.RowIndex].Cells[0].Value;
            Console.WriteLine(id);
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                Order_Text.Text = id;

                cmd.CommandText = "select 역순번,열차번호,출발역,도착역,출발시간,도착시간,운임료 from 구간 where 역순번 = '" + id + "'";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Order_Text.Text = read.GetValue(0).ToString();
                    Train_Text.Text = read.GetValue(1).ToString();
                    Depart_Station_Text.Text = read.GetValue(2).ToString();
                    Arrival_Station_Text.Text = read.GetValue(3).ToString();
                    Depart_Date_Text.Text = read.GetValue(4).ToString();
                    Arrival_Date_Text.Text = read.GetValue(5).ToString();
                    Fare_Text.Text = read.GetValue(6).ToString();
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



        private void Choice_Seat_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            UserChoiceSeat f = new UserChoiceSeat(email, Order_Text.Text);
            f.ShowDialog();
        }
    }
}
