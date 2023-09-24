using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRazorDemo.Models
{
    [Table("StudentsInfo", Schema = "Admin")]
    public class Student
    {
        [Key]
        public int StdntID { get; set; }

        [Required]
        public string LastName { get; set; }

        [Column("FirstName")]
        [Required]
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        [NotMapped]
        public int FatherName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}