using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class StudentListVM2
    {

        public List<Student> Students { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public double TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
