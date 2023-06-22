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
    public partial class TicketingHistory : Form
    {
        string email;
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        bool show_all = false;

        public TicketingHistory(string email)
        {
            this.email = email;
            InitializeComponent();
            idbox.ForeColor = Color.Transparent;
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            String query = $"select * from 예매좌석 where 아이디 = '{email}'";
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
            GridViewRefresh();

        }
        private void GridViewRefresh()
        {
            Ticketing_Text.Text = "";
            Train_Text.Text = "";
            Direction_Text.Text = "";
            Depart_Station_Text.Text = "";
            Arrival_Station_Text.Text = "";
            Depart_Text.Text = "";
            Arrival_Text.Text = "";
            Train_Type_Text.Text = "";
            Seat_Text.Text = "";
            Pay_Text.Text = "";
            Price_Text.Text = "";
            idbox.Text = "";

            History_View.DataSource = null;
            History_View.Rows.Clear();

            conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            String query = $"select 예매번호 as 예매번호, 열차번호 as 열차번호, 방향 as 방향, 출발역 as 출발역, 도착역 as 도착역, 출발시간 as 출발시간, 도착시간 as 도착시간, 열차등급 as 열차등급, 좌석번호 as 좌석번호, 결제수단 as 결제수단, 금액 as 금액, 아이디 as 아이디 from 예매좌석 where 아이디 = '{email}' order by 예매번호";
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();
            int count = read.FieldCount;

            History_View.ColumnCount = count;
            for (int i = 0; i < count; i++)
            {
                History_View.Columns[i].Name = read.GetName(i);
            }
            while (read.Read())
            {

                object[] obj = new object[count]; // 필드수만큼 오브젝트 배열
                for (int i = 0; i < count; i++) // 필드 수만큼 반복
                {

                    obj[i] = new object();
                    obj[i] = read.GetValue(i);
                }


                History_View.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가
            }
            conn.Close();
            try
            {
                String id = (String)History_View.Rows[0].Cells[0].Value;
                Console.WriteLine(id);
                idbox.Text = id;

                conn = new OleDbConnection(connectionString);
                conn.Open(); //데이터베이스 연결
                cmd.CommandText = "select * from 예매좌석 where 아이디 = '" + email + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                string seat2 = "";
                read = cmd.ExecuteReader(); //select  결과
                if (read.Read())
                {
                    Ticketing_Text.Text = read.GetValue(0).ToString();
                    Train_Text.Text = read.GetValue(2).ToString();
                    Direction_Text.Text = read.GetValue(3).ToString();
                    Depart_Station_Text.Text = read.GetValue(4).ToString();
                    Arrival_Station_Text.Text = read.GetValue(5).ToString();
                    Depart_Text.Text = read.GetValue(6).ToString();
                    Arrival_Text.Text = read.GetValue(7).ToString();
                    Train_Type_Text.Text = read.GetValue(8).ToString();
                    //Seat_Text.Text = read.GetValue(10).ToString();
                    seat2 += read.GetValue(9).ToString() + read.GetValue(10).ToString() + " ";
                    Pay_Text.Text = read.GetValue(14).ToString();
                    Price_Text.Text = read.GetValue(13).ToString();
                    idbox.Text = read.GetValue(11).ToString();
                    Seat_Text.Text = seat2;
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

        private void History_View_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int row = e.RowIndex;
            Ticketing_Text.Text = History_View.Rows[row].Cells[0].Value.ToString();
            Train_Text.Text = History_View.Rows[row].Cells[1].Value.ToString();
            Direction_Text.Text = History_View.Rows[row].Cells[2].Value.ToString();
            Depart_Station_Text.Text = History_View.Rows[row].Cells[3].Value.ToString();
            Arrival_Station_Text.Text = History_View.Rows[row].Cells[4].Value.ToString();
            Depart_Text.Text = History_View.Rows[row].Cells[5].Value.ToString();
            Arrival_Text.Text = History_View.Rows[row].Cells[6].Value.ToString();
            Train_Type_Text.Text = History_View.Rows[row].Cells[7].Value.ToString();
            //Seat_Text.Text = History_View.Rows[row].Cells[8].Value.ToString();
            Pay_Text.Text = History_View.Rows[row].Cells[9].Value.ToString();
            Price_Text.Text = History_View.Rows[row].Cells[10].Value.ToString();

            String query = $"select * from 예매좌석 where 예매번호='{Ticketing_Text.Text}'";
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.Connection = conn;
            conn.Open();
            OleDbDataReader read = cmd.ExecuteReader();
            String sea = "";
            while (read.Read())
            {
                sea += read.GetValue(9).ToString() + read.GetValue(10).ToString() + " ";
            }
            Seat_Text.Text = sea;

            conn.Close();
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예매를 취소하겠습니까?", "예매 취소 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn = new OleDbConnection(connectionString);

                String query = $"delete from 예매좌석 where 예매번호='{Ticketing_Text.Text}'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine(Ticketing_Text.Text);
                GridViewRefresh();
                MessageBox.Show("예매 취소 되었습니다");
            }
        }
        private void Collection_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예매를 수정하겠습니까?", "예매 수정 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn = new OleDbConnection(connectionString);
                String query = $"delete from 예매좌석 where 예매번호='{Ticketing_Text.Text}'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine(Ticketing_Text.Text);
                GridViewRefresh();
                MessageBox.Show("예매가 취소 되었니다. 새로 예약할 좌석을 선택하세요.");

                UserTicketing f = new UserTicketing(email);
                f.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
