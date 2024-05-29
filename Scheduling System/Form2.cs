using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Scheduling_System
{
    public partial class SubjectOffering : Form
    {
        private string userName;
        private string student;
        public SubjectOffering(string student, string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.student = student;

            studentName.Text = student;
            studentNumber.Text = userName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StudentForm(student, userName).Show();
            Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.adamson.edu.ph/2018/");
            webView21.BringToFront();
            webView21.Visible = true;
        }

        private void subjOffering_Click(object sender, EventArgs e)
        {
            new StudentForm(student, userName).Show();
            Hide();
        }

        private void finance_Click(object sender, EventArgs e)
        {
            new Finance_Portal(student, userName).Show();
            Hide();
        }

        private void subjEnrollment_Click(object sender, EventArgs e)
        {
            new StudentForm(student, userName).Show();
            Hide();
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
            webView21.BringToFront();
            webView21.Visible = true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        int currentImageIndex = 0;
        private void imageShow_Click(object sender, EventArgs e)
        {
            pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\1.png");
            currentImageIndex++;
            imageCounter();

        }
        void imageCounter()
        {    
            if (currentImageIndex == 2)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\2.png");
            }
            else if (currentImageIndex == 3)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\3.png");
            }
            else if (currentImageIndex == 4)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\4.png");
            }
            else if (currentImageIndex == 5)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\5.png");
            }
            else if (currentImageIndex < 5)
            {
                currentImageIndex = 1;
            }
        }
    }
}

