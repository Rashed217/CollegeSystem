using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem
{
    public class Student
    {
        [Key]
        public int StId { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Hostel")]
        public int HostelId { get; set; }


        public virtual Department Department { get; set; }


        public virtual Hostel Hostel { get; set; }

        public virtual ICollection<StudentPhone> StudentPhones { get; set; }
    }
}
