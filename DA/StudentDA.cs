using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using CourseEvaluation.Business;

namespace CourseEvaluation.DA
{
    public static class StudentDA
    {
        private static string filePath = Application.StartupPath + @"\Students.dat";

        public static void Save(Student student)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(student.StudentId +
                         student.FirstName +
                         student.LastName +
                         student.Email
                );
            sw.Close();
            MessageBox.Show("Save successfully!");

        }
    }
}
