using CourseEvaluation.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseEvaluation
{
    
    public partial class FormCourseEvaluation : Form
    {
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
            grade.FinalResult = grade.GetFinalGrades();
        }
    }
}
