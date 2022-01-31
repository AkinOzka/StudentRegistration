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
            if (txtFirstName.Text=="" &&
                txtLastName.Text==""&&
                rdoFemale.Checked==false &&
                rdoMale.Checked==false &&
                txtAge.Text=="")
            {
                MessageBox.Show("The record is not Correct");
            }
            
                          
            Student student=new Student();
            student.Id =Convert.ToInt32( txtId.Text);
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
            student.Age = Convert.ToInt32( txtAge.Text);
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
    }
}
