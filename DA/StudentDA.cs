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
            sw.WriteLine(student.StudentId + " | " +
                         student.FirstName + " | " +
                         student.LastName + " | " +
                         student.Email
                );
            sw.Close();
            MessageBox.Show("Save successfully!");
        }

        public static void ListStudents(ListView lstStudents)
        {
            try
            {
                //Create an object of type StreamReader
                //The using statement closes the StreamReader
                using (StreamReader sReader = new StreamReader(filePath)) 
                {
                    //Read the file until the end of the file
                    //Read line by line
                    string line = sReader.ReadLine();
                    while (line != null)
                    {
                        //Split the line into an array of string
                        string[] fields = line.Split(',');

                        //Add data to the listview control
                        ListViewItem item = new ListViewItem(fields[0]);
                        item.SubItems.Add(fields[1]);
                        item.SubItems.Add(fields[2]);
                        item.SubItems.Add(fields[3]);
                        lstStudents.Items.Add(item);
                        //Reads the next line
                        line = sReader.ReadLine();
                    }
                    sReader.Close();
                }       
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be read!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static List<Student> ListStudents()
        {
            List<Student> lstStudent = new List<Student>();
            using (StreamReader sReader = new StreamReader(filePath))
            {
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split("|");
                    Student stud = new Student();
                    stud.StudentId = Convert.ToInt32(fields[0]);
                    stud.FirstName = fields[1];
                    stud.LastName = fields[2];
                    stud.Email = fields[3];
                    lstStudent.Add(stud);
                    line = sReader.ReadLine();
                }
                return lstStudent;
            }
        }
    }
}
