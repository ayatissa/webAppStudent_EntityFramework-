using BLL;
using DAL;
using DAL.Entities;
//using System.Collections.Generic;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using WebAppStudent.Common;

using WebAppStudent.Models;
//using PagedList;


namespace WebAppStudent.Content
{
    public class StudentController : Controller
    {
        StudentBLL _Bll = new StudentBLL();
        
      
       
        // GET: Student
        [TrackExecution]

        //public ActionResult Index()
        //{
          //  return View(Studentlist);
        //}



        public ActionResult Search (string search, int page = 1)
        {
            var std = _Bll.Search(search, page);
            return View(std);
        }
        

        [HttpGet]

        public ActionResult Edit(int Id)
        {

            var std = _Bll.GetByID(Id);
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(DAL.Student std)

        {

            var edit = _Bll.Edit(std);
            return View(edit);

        }


        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(DAL.Student std)
        {
            var Result = _Bll.Add(std);
            return View(std);
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var Result = _Bll.Delete(Id);
            return RedirectToAction("Index");
        }

        public ActionResult GetByID(int Id)
        {
            var GetId = _Bll.GetByID(Id);
            return View(GetId);



        }
    }
}





//************************************

//public ActionResult GetAll()
//{


//    Bll.GetAll();
//    return View("");


//}


//public ActionResult Search(string search, int page = 1)
//{
//    //var vm = new StudentListVM();
//    //var studentList = _Bll.Get();
//    //vm.Students = studentList;

//    //double TotalPages = 0;
//    //     studentList = _Bll.Search(search, page, out TotalPages );

//    //vm.Search = search;
//    //vm.CurrentPage = page;
//    //vm.PageSize = _Bll.PageSize;
//    //vm.TotalPages = TotalPages;

//    //vm.Students = studentList;


//    //return View(vm);
//}