using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Response
    {
        public int ResponseID { get; set; }
        public int SurveyID { get; set; }
        public string Answers { get; set; }
        public DateTime SubmissionDate { get; set; }
        public virtual Survey Survey { get; set; }
    }
}
