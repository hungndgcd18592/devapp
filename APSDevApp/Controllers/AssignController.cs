using System;
using APSDevApp.Models;
using APSDevApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APSDevApp.Controllers
{
    public class AssignController : Controller
    {
        private ApplicationDbContext _context;
        public ActionResult Index(int id)
        {
            var trainerInCourse = _context.Trainers.Where(c => c.CourseId == id).ToList();
            var traineeInCourse = _context.Trainees.Where(c => c.CourseId == id).ToList();
            var listTrainerTraineeInCourse = new ListTrainerTraineeInCourse()
            {
                Trainers = trainerInCourse,
                Trainees = traineeInCourse,
                Course = _context.Courses.SingleOrDefault(c => c.Id == id)
            };
            return View(listTrainerTraineeInCourse);
        }
    }
}