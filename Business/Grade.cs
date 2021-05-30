using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CourseEvaluation.Business
{
    public class Grade
    {
        public double Midterm { get; set; }
        public double Project { get; set; }
        public double FinalExam { get; set; }
        public double FinalResult { get; set; }

        public Grade()
        {

        }

        public Grade(float _midterm, float _project, float _finalExam, float _finalResult)
        {
            this.Midterm = _midterm;
            this.Project = _project;
            this.FinalExam = _finalExam;
            this.FinalResult = _finalResult;
        }
        public int GetFinalGrades()
        {
            const double MIDTERM = 0.3f;
            const double PROJECT = 0.3f;
            const double FINALS = 0.4f;
           
            FinalResult= Convert.ToInt32((Midterm * MIDTERM) + (Project * PROJECT) + (FinalExam * FINALS));
            return (int)FinalResult;
          
        }
    }
}
