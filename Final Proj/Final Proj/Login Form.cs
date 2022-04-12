using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proj
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            uc_std1.Show();
            uc_std1.BringToFront();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            uc_std1.Hide();
        }
    }
}
