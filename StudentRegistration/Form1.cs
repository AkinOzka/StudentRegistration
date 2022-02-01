using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" &&
                txtLastName.Text == "" &&
                rdoFemale.Checked == false &&
                rdoMale.Checked == false &&
                txtAge.Text == "")
            {
                MessageBox.Show("The record is not Correct");
            }


            Student student = new Student();
            student.Id = Convert.ToInt32(txtId.Text);
            student.FirstName = txtFirstName.Text;
            student.SecondName = txtLastName.Text;

            if (rdoFemale.Checked)
            {
                student.Gender = "Female";
            }
            if (rdoMale.Checked)
            {
                student.Gender = "Male";
            }


            //student.Gender=rdoFemale.Checked;
            student.Age = Convert.ToInt32(txtAge.Text);
            StudentManager manager = new StudentManager();
            manager.Insert(student);

            manager.GetStudents();
            //lstStudents.Items.Clear();
            lstStudents.Items.Add(student);

            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            txtAge.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentManager manager = new StudentManager();
            var allStudents = manager.GetStudents();
            foreach (var student in allStudents)
            {
                lstStudents.Items.Add(student);
            }

        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            Student student = (Student)lstStudents.SelectedItem;
            if (student != null)
            {
                txtId.Text = student.Id.ToString();
                txtFirstName.Text = student.FirstName.ToString();
                txtLastName.Text = student.SecondName.ToString();

                if (student.Gender == "Male")
                {
                    rdoMale.Checked = true;
                }
                if (student.Gender == "female")
                {
                    rdoFemale.Checked = true;
                }
                txtAge.Text = student.Age.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var student = (Student)lstStudents.SelectedItem;
            int index = lstStudents.SelectedIndex;
            textBox1.Text = index.ToString();
            StudentManager manager = new StudentManager();


            Student newStudent = new Student();
            newStudent.Id = Convert.ToInt32(txtId.Text);
            newStudent.FirstName = txtFirstName.Text;
            newStudent.SecondName = txtLastName.Text;

            if (rdoFemale.Checked)
            {
                newStudent.Gender = "Female";
            }
            if (rdoMale.Checked)
            {
                newStudent.Gender = "Male";
            }

            if (txtId.Text!=" ")
            {
                manager.Update(newStudent, index);
            }
            else
            {
                MessageBox.Show("Select een record");
            }

            newStudent.Age = Convert.ToInt32(txtAge.Text);
           

            lstStudents.Items.Clear();

            var allStudents = manager.GetStudents();
            foreach (var item in allStudents)
            {
                lstStudents.Items.Add(item);
            }
        }
    }
}
