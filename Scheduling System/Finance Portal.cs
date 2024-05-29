using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_System
{
    public partial class Finance_Portal : Form
    {
        private string userName;
        private string student;
        public Finance_Portal(string student, string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.student = student;

            studentName.Text = student;
            studentNumber.Text = userName;
        }

        private void Finance_Portal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        { 
            webView21.BringToFront();
            webView21.Visible = true;

        }
    }
}
