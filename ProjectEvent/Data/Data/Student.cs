using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string StudentNumber { get; set; }
        public string Class { get; set; }
        public string Department { get; set; }
        public DateTime AdmissionDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
