using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using DAL;


namespace BLL
{
    

    public  class StudentBLL
    {

        //private StudentDAL _DAL = new StudentDAL();

        private StudentDAL2 _DAL2 = new StudentDAL2();

        

        public List<Student> Search(string search, int page )
        { 
            var std = _DAL2.Search(search, page );
            return std;
        }


        public Student GetByID(int Id)
        {
            var std = _DAL2.GetByID(Id);
            return std;

        }
        public List<Student> Get()
        {
            var Result = _DAL2.Get();
            return Result;

        }

        public Student Add(Student std )
        {
            std = _DAL2.Add(std);
            return (std);
        }

       

           public Student Edit(Student std)
        {
            std = _DAL2.Edit(std);
            return (std);
        }


        public  Student Delete(int Id)
        {
            Student std = _DAL2.Delete(Id);
            return std;
        }

    }
}