using CourseEvaluation.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourseEvaluation.DA;
namespace CourseEvaluation
{
    
    public partial class FormCourseEvaluation : Form
    {
        List<Student> lstStudent = new List<Student>();
        private Grade grade = new Grade();
        public FormCourseEvaluation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            grade.Midterm = Convert.ToInt32(txtMidterm.Text);
            grade.Project = Convert.ToInt32(txtProject.Text);
            grade.FinalExam = Convert.ToInt32(txtProject.Text);
            // grade.FinalResult = grade.GetFinalGrades();
            grade.FinalResult = grade.GetFinalGrades();
            lblFinResult.Text = grade.GetFinalGrades().ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmail.Text;
            StudentDA.Save(student);

            Grade grade = new Grade();
            grade.Midterm = Convert.ToInt32(txtMidterm.Text);
            grade.Project = Convert.ToInt32(txtProject.Text);
            grade.FinalExam = Convert.ToInt32(txtFinalExam.Text);
            grade.FinalResult = int.Parse(lblFinResult.Text);
            GradeDA.SaveGrade(grade);
        }
    }
}
