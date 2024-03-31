using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string AdminNumber { get; set; }
        
        public DateTime JoiningDate { get; set; }
    }
}
