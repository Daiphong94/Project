using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TargetRole { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Response> Responses { get; set; }
    }
}
