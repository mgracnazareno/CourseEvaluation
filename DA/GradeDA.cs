using CourseEvaluation.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CourseEvaluation.DA
{
    public static class GradeDA
    {
        private static string filePathGrade = Application.StartupPath + @"Grade.dat";

        public static void SaveGrade(Grade grade)
        {
            using (StreamWriter sw = new StreamWriter(filePathGrade, true))
            {
                sw.WriteLine( grade.Midterm + "|" + 
                              grade.Project + "|" + 
                              grade.FinalExam + "|" + 
                              grade.FinalResult
                            );
                sw.Close();
                MessageBox.Show("Grades has been added sucessfully!");
            }
        }

        public static void ListGrade(ListView lstGrade)
        {
            using (StreamReader sReader = new StreamReader(filePathGrade))
            {
                try
                {
                    string line = sReader.ReadLine();

                    while (line != null)
                    {
                        string[] fields = line.Split(" | ");
                        ListViewItem item = new ListViewItem(fields[0]);
                        item.SubItems.Add(fields[1]);
                        item.SubItems.Add(fields[2]);
                        item.SubItems.Add(fields[3]);
                        lstGrade.Items.Add(item);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The file can not be read!", "Warning!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
