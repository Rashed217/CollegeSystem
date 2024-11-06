using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem
{
    public class FacultyMobile
    {
        [Key]
        public int FMId { get; set; }
        [ForeignKey("Faculty")]
        public int FId { get; set; }


        public virtual Faculty Faculty { get; set; }
    }
}
