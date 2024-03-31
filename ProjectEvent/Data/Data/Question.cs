using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int CompetitionID { get; set; }
        public string Content { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
