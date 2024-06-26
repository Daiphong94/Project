﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Competition
    {
        public int CompetitionID { get; set; }
        public string CompetitionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<StudentCompetition> StudentCompetitions { get; set; }

        public Competition()
        {
            StudentCompetitions = new HashSet<StudentCompetition>(); 
        }
    }
}
