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
    }
}
