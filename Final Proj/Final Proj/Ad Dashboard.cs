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
    public partial class Ad_Dashboard : Form
    {
        public Ad_Dashboard()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form f1 = new Login_Form();
            f1.Show();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            uc_bookdetails1.Hide();
            uc_issueBook1.Hide();
            uc_returnBook1.Hide();
            uc_Student_details1.Show();
            uc_Student_details1.BringToFront();
        }

        private void btn_bookDetails_Click(object sender, EventArgs e)
        {
            uc_Student_details1.Hide();
            uc_issueBook1.Hide();
            uc_returnBook1.Hide();
            uc_bookdetails1.Show();
            uc_bookdetails1.BringToFront();
        }

        private void btn_issueBook_Click(object sender, EventArgs e)
        {
            uc_Student_details1.Hide();
            uc_bookdetails1.Hide();
            uc_returnBook1.Hide();
            uc_issueBook1.Show();
            uc_issueBook1.BringToFront();
        }

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            uc_Student_details1.Hide();
            uc_bookdetails1.Hide();
            uc_issueBook1.Hide();
            uc_returnBook1.Show();
            uc_returnBook1.BringToFront();
        }

        private void Ad_Dashboard_Load(object sender, EventArgs e)
        {
            uc_Student_details1.Hide();
            uc_bookdetails1.Hide();
            uc_issueBook1.Hide();
            uc_returnBook1.Hide();
        }
    }
}
