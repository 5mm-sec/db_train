using System;
using System.Windows.Forms;
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
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;

namespace DB_Train
{
    public partial class LoginForm : Form
    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        public LoginForm()
        {
            InitializeComponent();
            Pw_text.PasswordChar = '*';
        }

        private void Login_btn_click(object sender, EventArgs e)
        {
            String email = Id_Text.Text;
            String pw = Pw_text.Text;
            String Check_grade = "";
            email = email.Trim();

            Console.WriteLine("로그인 버튼 눌림" + email + "djawnstlr");

            bool valid = Regex.IsMatch(email, @"[a-zA-Z0-9!#$%&'*+/s=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");
            if (email == "admin")
            {
                valid = true;
            }
            if (!valid)
            {
                MessageBox.Show("올바른 이메일이 아닙니다. 확인해주세요.", "로그인 실패");
                return;
            }
            SHA256 hash1 = new SHA256Managed();
            byte[] bytes1 = hash1.ComputeHash(Encoding.ASCII.GetBytes(pw));

            // 16진수 형태로 문자열 결합
            StringBuilder sb1 = new StringBuilder();
            foreach (byte b1 in bytes1)
                sb1.AppendFormat("{0:x2}", b1);

            // 입력값의 해시결과
            String crypted_pw = sb1.ToString();
            Console.WriteLine(crypted_pw);
            //admin passwd 8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918

            String query = $"select 이름,등급 from 회원 where 아이디='{email}' and 비밀번호='{crypted_pw}'";

            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();

            if (!read.Read())
            {
                MessageBox.Show("가입 정보가 없습니다.", "로그인실패");
                if (conn != null)
                {
                    conn.Close();
                }
                return;
            }
            else if (email != "admin" && read.GetValue(1).ToString() == "")
            {
                MessageBox.Show("관리자의 승인이 필요합니다\n\n", "승인 대기중");
                if (conn != null)
                {
                    conn.Close();
                }
                return;
            }

            String name = read.GetString(0);
            //String grade = read.GetString(1);
            conn.Close();
            Console.WriteLine(name);
            MessageBox.Show($"{name}님 환영합니다.", "로그인성공");

            if (email == "admin")
            {
                //여기서 admin 작업 진행
                this.Hide();

                AdminMain f = new AdminMain(); //이메일 어드민 넣어야됨
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
                return;

            }
            else
            {

                this.Hide();

                UserMain f = new UserMain(email, name); // 누구누구님 환영합니다 넣어야됨
                f.Closed += (s, args) => this.Close();
                f.ShowDialog();
            }



        }

        private void Signup_btn_click(object sender, EventArgs e)
        {
            Console.WriteLine("Signup Button Pressed");
            SignupForm f = new SignupForm();
            f.ShowDialog();
        }
        private void Find_Id_btn_Click(object sender, EventArgs e)
        {
            Find_Id f = new Find_Id();
            f.ShowDialog();
        }
        private void Find_Pw_btn_Click(object sender, EventArgs e)
        {
            Find_Pw f = new Find_Pw();
            f.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
