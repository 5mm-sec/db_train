using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using System.Diagnostics;
namespace DB_Train
{
    public partial class UserChoiceSeat : Form
    {
        public ArrayList buttons = new ArrayList();
        String email;
        String id;
        int i = 1;
        OleDbConnection conn;
        string connectionString = "Provider=OraOLEDB.Oracle;Password=kokl003;User ID=kokl003"; //oracle 서버 연결


        public UserChoiceSeat(String email,String id)
        {
            InitializeComponent();

            this.email = email;
            this.id = id;
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = $"select 역순번 ,열차등급 from 구간 where 역순번 = '"+id+"'";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            OleDbDataReader read = cmd.ExecuteReader();
            string Train_Number = "";
            string Train_Type = "";
            if (read.Read())
            {
                Train_Number = read.GetValue(0).ToString();
                Train_Type = read.GetValue(1).ToString();
                Console.WriteLine(Train_Number);
                Console.WriteLine(Train_Type);
            }
            conn.Close();

            if (Train_Type == "새마을호")
            {
                int k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "A" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "A" + (k++);
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(100 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }
                }
                k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {

                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "B" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "B" + k++;
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(200 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        //23 67 111
                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }

                }
                k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {

                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "C" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "C" + k++;
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(300 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        //23 67 111
                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }

                }
                k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {

                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "D" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "D" + k++;
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(400 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        //23 67 111
                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }

                }


            }
            else if (Train_Type == "무궁화호")
            {
                int k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "A" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "A" + (k++);
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(100 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }
                }
                k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "B" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "B" + k++;
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(250 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        //23 67 111
                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }

                }
                k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "C" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "C" + k++;
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(400 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        //23 67 111
                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }

                }
                k = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                        b.Name = "D" + k;
                        b.Size = new System.Drawing.Size(38, 35);
                        b.Text = "D" + k++;
                        this.panel1.Controls.Add(b);
                        b.Location = new System.Drawing.Point(550 + (44 * (j % 3)), 70 + (41 * (i % 10)));

                        //23 67 111
                        b.UseVisualStyleBackColor = true;
                        buttons.Add(b);
                    }

                }
            }// 예약 열차 조회 만들기, 잔여좌석 만들기
            for (int i = 0; i < buttons.Count; i++)
            {
                Button b = (Button)buttons[i];
                b.Click += new System.EventHandler(this.Seat_btn_Click);
            }

            //잔여좌석 표시해주는거 여기서부터
            conn.Open();
            cmd.CommandText = $"select * from 구간 where 역순번 = '" + id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            read = cmd.ExecuteReader(); //select  결과

            string Order = "";
            string Direction = "";
            string DepartStation = "";
            string ArrivalStation = "";
            string Depart_Time = "";
            string Arrival_Time = "";
            string Train_NUM = "";

            string Order2 = "";
            string Direction2 = "";
            string DepartStation2 = "";
            string ArrivalStation2 = "";
            string Depart_Time2= "";
            string Arrival_Time2 = "";
            string Train_NUM2 = "";
            string Row_Num = "";

            int Seat_Num = 0;


            if (read.Read())
            {
                Order = read.GetValue(0).ToString();
                Direction = read.GetValue(8).ToString();
                DepartStation = read.GetValue(4).ToString();
                ArrivalStation = read.GetValue(6).ToString();
                Depart_Time = read.GetValue(3).ToString();
                Arrival_Time = read.GetValue(5).ToString();
                Train_NUM = read.GetValue(1).ToString();
                Debug.WriteLine(Order);
                Debug.WriteLine(Direction);
                Debug.WriteLine(DepartStation);
                Debug.WriteLine(ArrivalStation);
                Debug.WriteLine(Depart_Time);
                Debug.WriteLine(Arrival_Time);
                Debug.WriteLine(Train_NUM);
            }
            conn.Close();
            
            while(i < 100)
            {
                conn.Open();
                cmd.CommandText = $"select 역순번,방향,출발역,도착역,출발시간,도착시간,행번호,좌석번호,열차번호 from 예매좌석 where 예매번호= '" + i + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                read = cmd.ExecuteReader();
                if (read.Read())
                {
                    Order2 = read.GetValue(0).ToString();
                    Direction2 = read.GetValue(1).ToString();
                    DepartStation2 = read.GetValue(2).ToString();
                    ArrivalStation2 = read.GetValue(3).ToString();
                    Depart_Time2 = read.GetValue(4).ToString();
                    Arrival_Time2 = read.GetValue(5).ToString();
                    Row_Num = read.GetValue(6).ToString();
                    Seat_Num = Int32.Parse(read.GetValue(7).ToString());
                    Train_NUM2 = read.GetValue(8).ToString();
                }


                if (Train_NUM == Train_NUM2 && Direction == Direction2 && ArrivalStation == ArrivalStation2 || Train_NUM == Train_NUM2 && Direction == Direction2 && DepartStation == DepartStation2)
                {
                    String row = Row_Num;
                    int t = (row[0] - 'A') * 4;
                    int col = Seat_Num;

                    Console.WriteLine(t + col);

                    (buttons[t + col] as Button).Enabled = false;
                    
                }

                i++;
                conn.Close();
            }
        }

        private void Seat_btn_Click(object sender, EventArgs e)
        {
            Button s = sender as Button;

            if (s.BackColor == SystemColors.Control)
            {
                s.BackColor = Color.Green;
                s.ForeColor = Color.White;
            }
            else
            {
                s.BackColor = SystemColors.Control;
                s.ForeColor = Color.Black;
            }
            Console.WriteLine(s.Text);
            string color = s.BackColor.ToString();
            Console.WriteLine(color);
        }
        private void Pay_btn_Click(object sender, EventArgs e)
        {
            ArrayList Seats = new ArrayList();
            String choice = "";

            for (int i = 0; i < buttons.Count; i++)
            {
                Button s = buttons[i] as Button;
                if (s.BackColor == Color.Green)
                {

                    Seats.Add(s.Text);
                    Console.WriteLine(s.Text);
                    choice += s.Text + " ";

                }
            }

            if (Seats.Count == 0)
            {
                MessageBox.Show("적어도 한개 이상 선택해주세요", "예매 불가");
                return;
            }

            if (MessageBox.Show(Seats.Count + "개의 좌석" + choice + "를 예매 할까요?", "예매확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Hide();

                UserPay f = new UserPay(email, id, Seats);
                f.Closed += (s, args) => this.Close();

                f.ShowDialog();

                
            }
        }
    }
}


