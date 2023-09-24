using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRazorDemo.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Index(IsUnique = true)]
        [ConcurrencyCheck]
        [MaxLength(24), MinLength(5)]
        public string Title { get; set; }
        [Index]
        public int Credits { get; set; }

        [Timestamp, DataType("timestamp")]
        public byte[] TimeStamp { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        [InverseProperty("CurrCourse")]
        public virtual ICollection<Enrollment> CurrEnrollments { get; set; }

        [InverseProperty("PrevCourse")]
        public virtual ICollection<Enrollment> PrevEnrollments { get; set; }


    }
}