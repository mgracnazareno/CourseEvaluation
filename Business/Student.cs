using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEvaluation.Business
{
  public class Student
  {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Student()
        {

        }

        public Student(int _studendtId, string _fname, string _lname, string _email)
        {
            this.StudentId = _studendtId;
            this.FirstName = _fname;
            this.LastName = _lname;
            this.Email = _email;

        }
    }
}
