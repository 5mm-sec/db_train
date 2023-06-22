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
    public partial class AdminAddSchedule : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        public AdminAddSchedule()
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

            //this.Depart_Station_CB.Items.AddRange(obj);
            //this.Depart_Station_CB.SelectedIndex = 0;

            //this.Arrival_Station_CB.Items.AddRange(obj);
            //this.Arrival_Station_CB.SelectedIndex = 0;



            GridViewRefresh();

        }
        private void GridViewRefresh()
        {
            Order_Text.Text = "";
            Train_View_Label.Text = "";
            Train_Type_View_Label.Text = "";
            Fare_Text.Text = "";
            Direction_Text.Text = "";
            Train_Data_View.DataSource = null;
            Train_Data_View.Rows.Clear();

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            String query = "select 열차번호 as 번호, 열차등급 as 등급 from 열차 order by 열차번호";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;

            Train_Data_View.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                Train_Data_View.Columns[i].Name = read.GetName(i);
            }
            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                Train_Data_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            conn.Close();

            try
            {
                String id = (String)Train_Data_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;
                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                cmd.CommandText = "select * from 열차 where 열차번호 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                read = cmd.ExecuteReader(); //select  결과

                if(read.Read())
                {
                    Train_View_Label.Text = read.GetValue(0).ToString();
                    Train_Type_View_Label.Text = read.GetValue(1).ToString();
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
        private void Train_Data_View_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);

            String id = (String)Train_Data_View.Rows[e.RowIndex].Cells[0].Value;
            Console.WriteLine(id);
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                idbox.Text = id;
                cmd.CommandText = "select * from 열차 where 열차번호 = '" + id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Train_View_Label.Text = read.GetValue(0).ToString();
                    Train_Type_View_Label.Text = read.GetValue(1).ToString();
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

        private void Regi_btn_Click(object sender, EventArgs e)
        {
            DateTime Depart_Time = this.Depart_PK.Value;
            DateTime Arrival_Time = this.Arrival_PK.Value;

            string De = Depart_Time.ToString("yyyy-MM-dd-HH-mm");
            string Ar = Arrival_Time.ToString("yyyy-MM-dd-HH-mm");

            string Depart = $"TO_DATE('{De}', 'yyyy-MM-dd-HH24-mi')";
            string Arrival = $"TO_DATE('{Ar}', 'yyyy-MM-dd-HH24-mi')";

            string q = $"select TO_CHAR(출발시간,'YYYY/MM/DD/hh24/mi'),TO_CHAR(도착시간,'YYYY/MM-DD-hh24-mi') from 구간 where ( (출발시간 between {Depart} and {Arrival}) or (도착시간 between {Depart} and {Arrival}) ) and  열차번호 = '{Train_View_Label.Text}'";
            Console.WriteLine(q);

            conn = new OleDbConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = q;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            OleDbDataReader read = cmd.ExecuteReader();
            conn.Close();
            conn.Open();

            string query = $"insert into 구간 values('{Order_Text.Text.Trim()}','{Train_View_Label.Text.Trim()}','{Train_Type_View_Label.Text.Trim()}',{Depart},'{Depart_Station_CB.Text.Trim()}',{Arrival},'{Arrival_Station_CB.Text.Trim()}','{Fare_Text.Text.Trim()}','{Direction_Text.Text}')";

            Console.WriteLine(query);
            cmd.CommandText = query;
            //Console.WriteLine(query);
            try
            {
                int fare = Int32.Parse(Fare_Text.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("요금은 숫자로 입력하세요");
                conn.Close();
                return;
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("해당시간에 정상적으로 스케쥴이 추가되었습니다");
                Fare_Text.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("입력을 확인해주세요.");
            }
            conn.Close();
        }

        /*private void Depart_PK_ValueChange(object sender, EventArgs e)
        {
            try
            {
                DateTime d1 = this.Arrival_PK.Value;
                String text = this.timeBox.Text.Replace("분", "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idbox_Click(object sender, EventArgs e)
        {

        }

        private void AdminAddSchedule_Load(object sender, EventArgs e)
        {

        }

        private void Fare_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void 번역순_Click(object sender, EventArgs e)
        {

        }
    }
}
