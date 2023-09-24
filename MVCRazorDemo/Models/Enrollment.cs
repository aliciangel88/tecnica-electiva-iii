using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRazorDemo.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        [ForeignKey("StudentID")]
        

        public virtual Course CurrCourse { get; set; }
        public virtual Course PrevCourse { get; set; }
        public virtual Student Student { get; set; }

    }
}