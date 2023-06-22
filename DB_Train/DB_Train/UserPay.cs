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
    public partial class UserPay : Form
    {
        String email, id;
        ArrayList array;
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        String TrainID = "";
        int price = 0;
        public UserPay(String email, String id, ArrayList array)
        {
            this.email = email;
            this.id = id;
            this.array = array;
            InitializeComponent();

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = $"select 카드번호 from 회원 where 아이디='{email}'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OleDbDataReader read = cmd.ExecuteReader();
            Console.WriteLine(email);
            Console.WriteLine(cmd.CommandText);

            Pay_CB.Items.Add("현금");
            if (read.Read())
            {
                //String data = (String)read.GetValue(0).ToString();
                //Console.WriteLine(data);
                //prideBox.Text = data;
                Pay_CB.Items.Add((String)read.GetValue(0).ToString());

            }

            conn.Close();
            conn.Open();

            cmd.CommandText = $"select 역순번,열차번호,방향,출발역,도착역,출발시간,도착시간,운임료 from 구간 where 역순번='{id}'";
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                Order_Text.Text = read.GetValue(0).ToString();
                Train_Text.Text = read.GetValue(1).ToString();
                Direction_Text.Text = read.GetValue(2).ToString();
                Depart_Station_Text.Text = read.GetValue(3).ToString();
                Arrival_Station_Text.Text = read.GetValue(4).ToString();
                Depart_Text.Text = read.GetValue(5).ToString();
                Arrival_Text.Text = read.GetValue(6).ToString();
                price = Int32.Parse(read.GetValue(7).ToString());
            }

            conn.Close();
            conn.Open();

            cmd.CommandText = $"select 방향 from 구간 where 역순번='{id}'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Direction_Text.Text = read.GetValue(0).ToString();
            }

            price = price * array.Count;
            
            Price_Text.Text = price + "원";

            Member_Text.Text = array.Count + "명";
            Seat_Text.Text = "";
            for (int i = 0; i < array.Count; i++)
            {
                Seat_Text.Text += array[i].ToString() + " ";
            }
            conn.Close();
            conn.Open();
            cmd.CommandText = $"select 열차등급 from 구간 where 역순번='{id}'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                Train_Number_Text.Text = read.GetValue(0).ToString();
            }
            Pay_CB.SelectedIndex = 0;


        }
        private void Pay_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("예매를 하시겠습니까?", "예매 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string st = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
                string now = $"TO_DATE('{st}', 'yyyy-MM-dd-HH24-mi')";

                Console.WriteLine(array[0].ToString());

                string sta = DateTime.Parse(Depart_Text.Text).ToString("yyyy-MM-dd-HH-mm");
                string en = DateTime.Parse(Arrival_Text.Text).ToString("yyyy-MM-dd-HH-mm");
                string startTime = $"TO_DATE('{sta}', 'yyyy-MM-dd-HH24-mi')";
                string endTime = $"TO_DATE('{en}', 'yyyy-MM-dd-HH24-mi')";

                int price = Int32.Parse(Price_Text.Text.Replace("원", ""));
                price = price / array.Count;

                conn = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = $"SELECT reservation_seq.NEXTVAL FROM DUAL";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();
                String sequence = "";
                if (read.Read())
                {
                    sequence = read.GetValue(0).ToString();
                }

                conn.Close();
                for (int i = 0; i < array.Count; i++)
                {
                    conn.Open();
                    String r = array[i].ToString()[0].ToString();
                    String c = array[i].ToString();
                    c = c.Replace("A", "");
                    c = c.Replace("B", "");
                    c = c.Replace("C", "");
                    c = c.Replace("D", "");
                    String query = $"insert into 예매좌석 values ('{sequence}','{Order_Text.Text}','{Train_Text.Text}','{Direction_Text.Text}','{Depart_Station_Text.Text}','{Arrival_Station_Text.Text}',{startTime},{endTime},'{Train_Number_Text.Text}','{r}','{c}','{email}',{now},'{price}','{Pay_CB.Text}')";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("정상적으로 예매 되었습니다!", "예매 종료");
                Close();

            }
        }

        private void UserPay_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
