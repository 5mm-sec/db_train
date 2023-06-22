using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace DB_Train
{
    public partial class SignupForm : Form
    {
        int process = 0;
        String code = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        public SignupForm()
        {
            InitializeComponent();
            //this.Auth_Text.KeyPress += this.only_digit_Event;
            this.First_Card_Text.KeyPress += this.only_digit_Event;
            this.Second_Card_Text.KeyPress += this.only_digit_Event;
            this.Third_Card_Text.KeyPress += this.only_digit_Event;
            this.First_Card_Text.KeyPress += this.only_digit_Event;
            this.Second_Card_Text.KeyPress += this.only_digit_Event;
            this.Third_Card_Text.KeyPress += this.only_digit_Event;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 회원가입을 취소할까요?", "회원가입 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 회원가입을 할까요?", "회원가입", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                String passWord = Pw_Text.Text;
                String repassWord = Pw_Check_Text.Text;
                if (passWord != repassWord)
                {
                    MessageBox.Show("두 비밀번호가 일치하지 않습니다.", "회원가입 실패");
                    return;
                }

                String regExpPw = @"(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[^\w\s]).{8,}";
                bool valid = Regex.IsMatch(passWord, regExpPw);


                if (!valid)
                {
                    MessageBox.Show("비밀번호는 숫자, 특수문자, 영문 각 1회 이상 " +
                        "사용하여 8자리 이상으로 설정해주세요",
                        "회원가입 실패");
                    return;
                }

                String regName = @"^[가-힣]{2,4}";
                String name = Name_Text.Text.Trim();

                valid = Regex.IsMatch(name, regName);
                if (!valid)
                {
                    MessageBox.Show("정확한 이름을 입력해주세요", "회원가입 실패");
                    return;
                }

                String regExpPhone = @"\d{2,3}-\d{3,4}-\d{4}";
                String phone = First_Phone_Text.Text.Trim() + "-" + Second_Phone_Text.Text.Trim() + "-" + Third_Phone_Text.Text.Trim();
                valid = Regex.IsMatch(phone, regExpPhone);

                if (!valid)
                {
                    MessageBox.Show("올바른전화번호를 입력해주세요",
                        "회원가입 실패");
                    return;
                }

                String regExpCard = @"\d{4}-\d{4}-\d{4}";
                String card = $"{First_Card_Text.Text.Trim()}-{Second_Card_Text.Text.Trim()}-" +
                    $"{Third_Card_Text.Text.Trim()}";
                valid = Regex.IsMatch(card, regExpCard);
                if (!valid)
                {
                    MessageBox.Show("올바른카드번호를 입력해주세요",
                        "회원가입 실패");
                    return;
                }

                //card = cardDrop.Text.Trim() + "-" + card;



                SHA256 hash1 = new SHA256Managed();
                byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(passWord));

                // 16진수 형태로 문자열 결합
                StringBuilder sb1 = new StringBuilder();
                foreach (byte b1 in bytes1)
                    sb1.AppendFormat("{0:x2}", b1);
                String grade2 = "";
                // 입력값의 해시결과
                String crypted_pw = sb1.ToString();
                String email = Email_Text.Text.Trim();
                String query = $"insert into 회원 values ('{email}','{crypted_pw}','{name}','{phone}','{grade2}','{card}')";
                Console.WriteLine(query);
                //이름 휴대전화 등급 카드번호

                
                //여기에 회원가입 되어있나 확인

                // try
                //{
                conn = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = $"select * from 회원 where 이름='{name}' and 전화번호='{phone}'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    MessageBox.Show("이미 가입된 회원입니다! 계정찾기를 이용해주세요!", "회원 가입불가");
                    if (conn != null)
                    {
                        conn.Close(); //데이터베이스 연결 해제
                    }
                    read.Close();
                    return;
                }
                conn.Close();
                conn = new OleDbConnection(connectionString);
                conn.Open();


                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                conn.Close(); //데이터베이스 연결 해제
                MessageBox.Show("회원가입되었습니다.", "회원가입 성공");
                Close();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void only_digit_Event(object sender, KeyPressEventArgs e)
        {
            // 숫자와 백스페이스만 입력가능
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
