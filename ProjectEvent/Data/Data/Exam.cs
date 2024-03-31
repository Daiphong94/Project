using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Exam
    {
        public int ExamID { get; set; }
        public int CompetitionID { get; set; }
        public int StudentID { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual Student Student { get; set; }
    }
}
