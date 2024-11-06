using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem
{
    public class Faculty
    {
        [Key]
        public int FacId { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }


        public virtual Department Department { get; set; }

        public virtual ICollection<FacultyMobile> FacultyMobiles { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
