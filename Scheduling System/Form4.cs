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
    public partial class StudentForm : Form
    {
        private string userName;
        private string student;
        private ListBox enrolledSubjects;

        public StudentForm(string student, string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.student = student;

            label1.Text = userName;
            label2.Text = student;

        }
        public void SetListBoxItems(ListBox.ObjectCollection items)
        {
            foreach (var item in items)
            {
                enrolledSubject.Items.Add(item);
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.adamson.edu.ph/2018/");
            webView21.BringToFront();
            webView21.Visible = true;
        }

        private void SubjOffering_Click(object sender, EventArgs e)
        {
            new SubjectOffering(student, userName).Show();
            Hide();
        }

        private void Finance_Click(object sender, EventArgs e)
        {
            new Finance_Portal(student, userName).Show();
            Hide();

        }

        private void SubjEnrollment_Click(object sender, EventArgs e)
        {
            webView21.Stop();
            webView21.Visible = false;
            webView21.SendToBack();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {
            webView21.BringToFront();   
            webView21.Visible = true;
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void EnrollSubjects_Click(object sender, EventArgs e)
        {
            new StudentEnroll(student, userName).Show();
            Hide();
        }
    }
}
