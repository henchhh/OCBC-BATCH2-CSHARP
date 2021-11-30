using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDO002ONL013_DeandriFirdaus_Assignment3.Models
{
    public class MovieItem
    {
        //private Models.EmployeeContext context;

        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string duration { get; set; }
        public DateTime releaseDate { get; set; }
    }
}
