using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{


    public class StudentDAL 
    {
        private static List<Student> studentList = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 6, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 7, StudentName = "Rob" , Age = 19 }
         };

        //const int PageSize = 3;
        myContext db = new myContext();

        //public List<Student> Search(string search, int page , out double TotalPages)

        //{

        //    TotalPages = 0;
        //    var studentList = Get();

        //    if (search != null && search != "")
        //    {
        //        var query = studentList.Where(s => s.StudentName.Contains(search));

        //        var paging = query
        //            .OrderBy(s => s.StudentId)
        //            .Skip((page - 1) * PageSize)
        //            .Take(PageSize)
        //            .ToList();

        //        var CountAfterFilter = query.Count();

        //        TotalPages = Math.Ceiling((double)CountAfterFilter / PageSize);
        //        studentList = paging;
        //    }
        //    return studentList;

        //}

      
       

        public List<Student> Get()
        {
            var Result = studentList ;
            return Result;
        }

        public Student GetByID(int Id)
        {
            var std = studentList.Where(s => s.StudentId == Id).Single();
            return std;
        }

        public Student Add(Student std)
        {
            var max = studentList.Max(s => s.StudentId);
            std.StudentId = max +1;
            studentList.Add(std);
       
            return std;
        }

        public Student Edit(Student std)
        {
            var stdOld = studentList.Where(s => s.StudentId == std.StudentId).Single();
            stdOld.StudentName = std.StudentName;
            stdOld.Age = std.Age;
            return std;
        }

        public Student Delete(int Id)
        {
            var std = studentList.Where(s => s.StudentId == Id).Single();
            studentList.Remove(std);
            return std;
        }
        
    }

}

//Search2
//public List<Student> Search(string search, int page = 1)

//{

//    var List = db.Students.ToList();
//    if (!string.IsNullOrWhiteSpace(search))
//    {
//        List = db.Students.Where(x => x.StudentName.Contains(search) || search == null)
//       .OrderBy(x => x.StudentId)
//       .Skip((page - 1) * PageSize)
//       .Take(PageSize).ToList();


//        var Totalpages = Math.Ceiling((double)List.Count() / PageSize);
//        var CurrentPage = page;

//        var TotalPages = Totalpages;

//    }

//    return (List);

//}



    //  Search1  
//public List<Student> Index(string search, int page = 1)
//{
//    var vm = new StudentListVM2();
//    var studentList = Get();
//    var TotalStudents = studentList.Count();
//    vm.Search = search;
//    vm.Students = studentList;
//    if (!string.IsNullOrWhiteSpace(search))
//    {
//        var result = studentList.Where(x => x.StudentName.Contains(search) || search == null).ToList();

//        studentList = result.OrderBy(x => x.StudentId).Skip((page - 1) * PageSize).Take(PageSize).ToList();


//      var CurrentPage = page;
//        vm.PageSize = PageSize;
//      var TotalPages = Math.Ceiling((double)studentList.Count() / PageSize);
//        vm.Students = studentList;

//    }
//    vm.Students = studentList;
//    return (vm.Students);
//}
