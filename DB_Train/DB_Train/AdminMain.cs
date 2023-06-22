using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Train
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void Edit_Train_Schedule_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            AdminManageSchedule f = new AdminManageSchedule();
            f.ShowDialog();
        }
        private void Regi_Train_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            AddTrain f = new AddTrain();
            f.ShowDialog();
        }
        private void Member_Manage_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("");
            AdminMangeMember f = new AdminMangeMember();
            f.ShowDialog();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

    }
}
