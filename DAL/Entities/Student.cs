using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Age is required.")]
        public string StudentName { get; set; }

        [Range(5, 80)]
        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }



    }
}
