using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Scheduling_System
{

    public partial class StudentEnroll : Form
    {
        private string userName;
        private string student;
        public StudentEnroll(string userName, string student)
        {
            InitializeComponent();
            this.student = student;
            this.userName = userName;

            label1.Text = userName;
            label2.Text = student;

          
        }

        private void home_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.adamson.edu.ph/2018/");
            webView21.BringToFront();
            webView21.Visible = true;
        }

        private void subjOffering_Click(object sender, EventArgs e)
        {
            new SubjectOffering(userName, student).Show();
            Hide();
        }

        private void finance_Click(object sender, EventArgs e)
        {
            new Finance_Portal(userName, student).Show();
            Hide();
        }

        private void subjEnrollment_Click(object sender, EventArgs e)
        {
            new StudentForm(userName, student).Show();
            Hide();
        }

        private void curriculumLabel_Click(object sender, EventArgs e)
        {
            webView21.BringToFront();
            webView21.Visible = true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }

        //List<DateTime> scheduleConflict = new List<DateTime>();
        private void computerAnimation_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                string comAnimQuery = "SELECT subject_number, subject_professor, subject_name, subject_slots, subject_schedule FROM comp_animation";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(comAnimQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    subjectListBox.Items.Clear();

                    while (reader.Read())
                    {
                        string? subjectNumber = reader["subject_number"].ToString();
                        string? subjectProfessor = reader["subject_professor"].ToString();
                        string? subjectName = reader["subject_name"].ToString();
                        string? subjectSlots = reader["subject_slots"].ToString();
                        string? subjectSchedule = reader["subject_schedule"].ToString();
                        subjectListBox.Items.Add(subjectNumber + "\t" + subjectProfessor + "\t" + subjectName + "\t" + subjectSlots + "\t" + subjectSchedule);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void discreteStructure_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                string discreteQuery = "SELECT subject_number, subject_professor, subject_name, subject_slots, subject_schedule FROM discrete";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(discreteQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    subjectListBox.Items.Clear();

                    while (reader.Read())
                    {
                        string? subjectNumber = reader["subject_number"].ToString();
                        string? subjectProfessor = reader["subject_professor"].ToString();
                        string? subjectName = reader["subject_name"].ToString();
                        string? subjectSlots = reader["subject_slots"].ToString();
                        string? subjectSchedule = reader["subject_schedule"].ToString();
                        subjectListBox.Items.Add(subjectNumber + "\t" + subjectProfessor + "\t" + subjectName + "\t" + subjectSlots + "\t" + subjectSchedule);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataStructure_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                string dsaQuery = "SELECT subject_number, subject_professor, subject_name, subject_slots, subject_schedule FROM dsa";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(dsaQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    subjectListBox.Items.Clear();

                    while (reader.Read())
                    {
                        string? subjectNumber = reader["subject_number"].ToString();
                        string? subjectProfessor = reader["subject_professor"].ToString();
                        string? subjectName = reader["subject_name"].ToString();
                        string? subjectSlots = reader["subject_slots"].ToString();
                        string? subjectSchedule = reader["subject_schedule"].ToString();
                        subjectListBox.Items.Add(subjectNumber + "\t" + subjectProfessor + "\t" + subjectName + "\t" + subjectSlots + "\t" + subjectSchedule);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void digiLab_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                string digiLabQuery = "SELECT subject_number, subject_professor, subject_name, subject_slots, subject_schedule FROM digi_lab";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(digiLabQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    subjectListBox.Items.Clear();

                    while (reader.Read())
                    {
                        string? subjectNumber = reader["subject_number"].ToString();
                        string? subjectProfessor = reader["subject_professor"].ToString();
                        string? subjectName = reader["subject_name"].ToString();
                        string? subjectSlots = reader["subject_slots"].ToString();
                        string? subjectSchedule = reader["subject_schedule"].ToString();
                        subjectListBox.Items.Add(subjectNumber + "\t" + subjectProfessor + "\t" + subjectName + "\t" + subjectSlots + "\t" + subjectSchedule);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void digiLec_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                string digiLecQuery = "SELECT subject_number, subject_professor, subject_name, subject_slots, subject_schedule FROM digital_lec";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(digiLecQuery, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    subjectListBox.Items.Clear();

                    while (reader.Read())
                    {
                        string? subjectNumber = reader["subject_number"].ToString();
                        string? subjectProfessor = reader["subject_professor"].ToString();
                        string? subjectName = reader["subject_name"].ToString();
                        string? subjectSlots = reader["subject_slots"].ToString();
                        string? subjectSchedule = reader["subject_schedule"].ToString();
                        subjectListBox.Items.Add(subjectNumber + "\t\n" + subjectProfessor + "\t" + subjectName + "\t" + subjectSlots + "\t" + subjectSchedule);
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //checks if there is value from subjectListbox, then prints onto listbox1   
           if (subjectListBox.SelectedItem != null)
            {
                listBox1.Items.Add(subjectListBox.SelectedItem);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
                StudentForm frm = new StudentForm(userName, student);
                frm.Show();
                frm.SetListBoxItems(listBox1.Items);
                this.Hide();
        }

        /*
        void viewSchedule()
        {
            //list of schedules
            DateTime discreteMonday1 = new DateTime(2024, 04, 15, 7, 0, 0);
            DateTime discreteMonday2 = new DateTime(2024, 04, 15, 9, 0, 0);
            DateTime discreteTuesday = new DateTime(2024, 04, 16, 7, 0, 0);
            DateTime discreteWednesday1 = new DateTime(2024, 04, 17, 7, 0, 0);
            DateTime discreteWednesday2 = new DateTime(2024, 04, 17, 9, 0, 0);
            DateTime discreteThursday = new DateTime(2024, 04, 18, 7, 0, 0);
            DateTime discreteFriday1 = new DateTime(2024, 04, 19, 7, 0, 0);
            DateTime discreteFriday2 = new DateTime(2024, 04, 19, 9, 0, 0);

            String discreteMon1Conv = Convert.ToString(discreteMonday1);
            String discreteMon2Conv = Convert.ToString(discreteMonday2);
            String discreteTuesConv = Convert.ToString(discreteTuesday);
            String discreteWed1Conv = Convert.ToString(discreteWednesday1);
            String discreteWed2Conv = Convert.ToString(discreteWednesday2);
            String discreteThursConv = Convert.ToString(discreteThursday);
            String discreteFri1Conv = Convert.ToString(discreteFriday1);
            String discreteFri2Conv = Convert.ToString(discreteFriday2);

            DateTime digiLabMonday1 = new DateTime(2024, 04, 15, 8, 0, 0);
            DateTime digiLabMonday2 = new DateTime(2024, 04, 15, 10, 0, 0);
            DateTime digiLabTuesday = new DateTime(2024, 04, 16, 7, 0, 0);
            DateTime digiLabWednesday1 = new DateTime(2024, 04, 17, 8, 0, 0);
            DateTime digiLabWednesday2 = new DateTime(2024, 04, 17, 10, 0, 0);
            DateTime digiLabThursday = new DateTime(2024, 04, 18, 7, 0, 0);
            DateTime digiLabFriday1 = new DateTime(2024, 04, 19, 8, 0, 0);
            DateTime digiLabFriday2 = new DateTime(2024, 04, 19, 10, 0, 0);

            String digiLabMon1Conv = Convert.ToString(digiLabMonday1);
            String digiLabMon2Conv = Convert.ToString(digiLabMonday2);
            String digiLabTuesConv = Convert.ToString(digiLabTuesday);
            String digiLabWed1Conv = Convert.ToString(digiLabWednesday1);
            String digiLabWed2Conv = Convert.ToString(digiLabWednesday2);
            String digiLabThursConv = Convert.ToString(digiLabThursday);
            String digiLabFri1Conv = Convert.ToString(digiLabFriday1);
            String digiLabFri2Conv = Convert.ToString(digiLabFriday2);

            DateTime digiLecMonday1 = new DateTime(2024, 04, 15, 9, 0, 0);
            DateTime digiLecMonday2 = new DateTime(2024, 04, 15, 11, 0, 0);
            DateTime digiLecTuesday = new DateTime(2024, 04, 16, 8, 0, 0);
            DateTime digiLecWednesday1 = new DateTime(2024, 04, 17, 9, 0, 0);
            DateTime digiLecWednesday2 = new DateTime(2024, 04, 17, 11, 0, 0);
            DateTime digiLecThursday = new DateTime(2024, 04, 18, 8, 0, 0);
            DateTime digiLecFriday1 = new DateTime(2024, 04, 19, 9, 0, 0);
            DateTime digiLecFriday2 = new DateTime(2024, 04, 19, 11, 0, 0);

            String digiLecMon1Conv = Convert.ToString(digiLecMonday1);
            String digiLecMon2Conv = Convert.ToString(digiLecMonday2);
            String digiLecTuesConv = Convert.ToString(digiLecTuesday);
            String digiLecWed1Conv = Convert.ToString(digiLecWednesday1);
            String digiLecWed2Conv = Convert.ToString(digiLecWednesday2);
            String digiLecThursConv = Convert.ToString(digiLecThursday);
            String digiLecFri1Conv = Convert.ToString(digiLecFriday1);
            String digiLecFri2Conv = Convert.ToString(digiLecFriday2);

            DateTime DSAMonday = new DateTime(2024, 04, 15, 7, 30, 0);
            DateTime DSATuesday1 = new DateTime(2024, 04, 16, 7, 0, 0);
            DateTime DSATuesday2 = new DateTime(2024, 04, 16, 10, 0, 0);
            DateTime DSAWednesday = new DateTime(2024, 04, 17, 7, 0, 0);
            DateTime DSAThursday1 = new DateTime(2024, 04, 18, 7, 0, 0);
            DateTime DSAThursday2 = new DateTime(2024, 04, 18, 10, 0, 0);
            DateTime DSAFriday = new DateTime(2024, 04, 19, 7, 30, 0);

            String DSAMonConv = Convert.ToString(DSAMonday);
            String DSATues1Conv = Convert.ToString(DSATuesday1);
            String DSATues2Conv = Convert.ToString(DSATuesday2);
            String DSAWedConv = Convert.ToString(DSAWednesday);
            String DSAThurs1Conv = Convert.ToString(DSAThursday1);
            String DSAThurs2Conv = Convert.ToString(DSAThursday2);
            String DSAFriConv = Convert.ToString(DSAFriday);

            DateTime ComAnimMonday = new DateTime(2024, 04, 15, 8, 0, 0);
            DateTime ComAnimTuesday1 = new DateTime(2024, 04, 16, 8, 0, 0);
            DateTime ComAnimTuesday2 = new DateTime(2024, 04, 16, 10, 0, 0);
            DateTime ComAnimWednesday = new DateTime(2024, 04, 17, 8, 0, 0);
            DateTime ComAnimThursday1 = new DateTime(2024, 04, 18, 8, 30, 0);
            DateTime ComAnimThursday2 = new DateTime(2024, 04, 18, 10, 0, 0);
            DateTime ComAnimFriday = new DateTime(2024, 04, 19, 8, 0, 0);

            String ComAnimMonConv = Convert.ToString(ComAnimMonday);
            String ComAnimTues1Conv = Convert.ToString(ComAnimTuesday1);
            String ComAnimTues2Conv = Convert.ToString(ComAnimTuesday2);
            String ComAnimWedConv = Convert.ToString(ComAnimWednesday);
            String ComAnimThurs1Conv = Convert.ToString(ComAnimThursday1);
            String ComAnimThurs2Conv = Convert.ToString(ComAnimThursday2);
            String ComAnimFriConv = Convert.ToString(ComAnimFriday);

            if (selectSubject.SelectedIndex == 0)
            {
                schedule1.Text = ComAnimMonConv;
                schedule2.Text = ComAnimTues1Conv;
                schedule3.Text = ComAnimTues2Conv;
                schedule4.Text = ComAnimWedConv;
                schedule5.Text = ComAnimThurs1Conv;
                schedule6.Text = ComAnimThurs2Conv;
                schedule7.Text = ComAnimFriConv;
                schedule8.Text = "None";
            }
            else if (selectSubject.SelectedIndex == 1)
            {
                schedule1.Text = discreteMon1Conv;
                schedule2.Text = discreteMon2Conv;
                schedule3.Text = discreteTuesConv;
                schedule4.Text = discreteWed1Conv;
                schedule5.Text = discreteWed2Conv;
                schedule6.Text = discreteThursConv;
                schedule7.Text = discreteFri1Conv;
                schedule8.Text = discreteFri2Conv;
            }

            else if (selectSubject.SelectedIndex == 2)
            {
                schedule1.Text = digiLabMon1Conv;
                schedule2.Text = digiLabMon2Conv;
                schedule3.Text = digiLabTuesConv;
                schedule4.Text = digiLabWed1Conv;
                schedule5.Text = digiLabWed2Conv;
                schedule6.Text = digiLabThursConv;
                schedule7.Text = digiLabFri1Conv;
                schedule8.Text = digiLabFri2Conv;

            }

            else if (selectSubject.SelectedIndex == 3)
            {
                schedule1.Text = digiLecMon1Conv;
                schedule2.Text = digiLecMon2Conv;
                schedule3.Text = digiLecTuesConv;
                schedule4.Text = digiLecWed1Conv;
                schedule5.Text = digiLecWed2Conv;
                schedule6.Text = digiLecThursConv;
                schedule7.Text = digiLecFri1Conv;
                schedule8.Text = digiLecFri2Conv;
            }

            else if (selectSubject.SelectedIndex == 4)
            {
                schedule1.Text = DSAMonConv;
                schedule2.Text = DSATues1Conv;
                schedule2.Text = DSATues2Conv;
                schedule2.Text = DSAWedConv;
                schedule2.Text = DSAThurs1Conv;
                schedule2.Text = DSAThurs2Conv;
                schedule2.Text = DSAFriConv;
                schedule2.Text = "None";
            }
        }
        */

    }

}