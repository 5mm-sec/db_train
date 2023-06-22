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
    public partial class UserProfile : Form

    {
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=kokl003;User ID=kokl003"; //oracle 서버 연결

        bool saveMode = false;

        String email;
        public UserProfile(String email)
        {

            InitializeComponent();
            this.email = email;

            Name_Text.ReadOnly = false;
            First_Number_Text.ReadOnly = false;
            Second_Number_Text.ReadOnly = false;
            Third_Number_Text.ReadOnly = false;
            First_Card_Text.ReadOnly = false;
            Second_Card_Text.ReadOnly = false;
            Third_Card_Text.ReadOnly = false;

            String query = $"select 아이디,이름,전화번호,등급,카드번호 from 회원 where 아이디='{email}'";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                Id_Text.Text = read.GetString(0).ToString();
                Name_Text.Text = read.GetString(1).ToString();

                String phone = read.GetString(2).ToString();
                String[] p = phone.Split('-');
                First_Number_Text.Text = p[0];
                Second_Number_Text.Text = p[1];
                Third_Number_Text.Text = p[2];
                Grade_Text.Text = read.GetString(3).ToString();
                String[] cards = read.GetString(4).ToString().Split('-');

                First_Card_Text.Text = cards[0];
                Second_Card_Text.Text = cards[1];
                Third_Card_Text.Text = cards[2];

                Console.WriteLine(phone);
            }


        }
        private void ProfileChange_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("회원 정보를 수정하시겠습니까?", "저장하기", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                conn = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                String phone = First_Number_Text.Text + "-" + Second_Number_Text.Text + "-" + Third_Number_Text.Text;
                String query = $"select * from 회원 where 이름='{Name_Text.Text}' and 전화번호='{phone}' and not 아이디='{Id_Text.Text}'";

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {

                    MessageBox.Show("해당 정보로 가입된 계정이 이미 존재합니다.", "수정 실패");

                    return;
                }
                conn.Close();
                conn.Open();


                Console.WriteLine(query);
                string card = First_Card_Text.Text + "-" + Second_Card_Text.Text + "-" + Third_Card_Text.Text;

                query = $"update 회원 set 이름='{Name_Text.Text}',전화번호='{phone}',카드번호='{card}' where 아이디='{Id_Text.Text}'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("수정이 완료되었습니다.", "수정 성공");
            }

        }
        private void Out_btn_Click(object sender, EventArgs e)
        {
            string ID = "";
            ID = Id_Text.Text;

            if (MessageBox.Show("회원을 탈퇴하겠습니까?", "탈퇴하기", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                conn = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                String query = $"delete from 회원 where 아이디 = '{Id_Text.Text}'";

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("탈퇴 완료되었습니다.", "탈퇴 성공");

                LoginForm f = new LoginForm();
                f.ShowDialog();
            }
        }
    }
}
