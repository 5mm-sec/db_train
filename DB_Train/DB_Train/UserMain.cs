using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DB_Train
{
    public partial class UserMain : Form
    {
        String email;
        public UserMain(String email, String name)
        {
            this.email = email;
            InitializeComponent();
            label1.Text = $"{name} 님 안녕하세요.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Ticketing_btn_Click(object sender, EventArgs e)
        {
            UserTicketing f = new UserTicketing(email);
            f.ShowDialog();
        }
        private void Lookup_btn_Click(object sender, EventArgs e)
        {
            TicketingHistory f = new TicketingHistory(email);
            f.ShowDialog();
        }
        private void Member_Info_btn_Click(object sender, EventArgs e)
        {
            UserProfile f = new UserProfile(email);
            f.ShowDialog();
        }

    }
}
