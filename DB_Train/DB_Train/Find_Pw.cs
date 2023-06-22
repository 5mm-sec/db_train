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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DB_Train
{
    public partial class Find_Pw : Form
    {
        int process = 0;
        String code = "";
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=kokl003;User ID=kokl003"; //oracle 서버 연결
        public Find_Pw()
        {
            InitializeComponent();
        }

        private void Resetpw(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
