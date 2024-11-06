using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem
{
    public class StudentPhone
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int SId { get; set; }


        public virtual Student Student { get; set; }
    }
}
