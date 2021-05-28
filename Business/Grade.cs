﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEvaluation.Business
{
    public class Grade
    {
        //constatns
        
        public float Midterm { get; set; }
        public float Project { get; set; }
        public float FinalExam { get; set; }
        public float FinalResult { get; set; }

        public float GetFinalGrades(Grade grades)
        {
            const float MIDTERM = 0.3f;
            const float PROJECT = 0.3f;
            const float FINALS = 0.4f;
            int finalResult = 0;

            finalResult = Convert.ToInt32(((grades.Midterm * MIDTERM) + (grades.Project * PROJECT) + (grades.FinalExam * FINALS)) /3);

            return finalResult;
        }
    }
}
