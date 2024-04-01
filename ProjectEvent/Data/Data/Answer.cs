using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public int StudentID { get; set; }
        public string? File { get; set; }
        public string? Writing { get; set; }

        public virtual Question Question { get; set; }
        public virtual Student Student { get; set; }
    }
}
