using HuynhMinhTuan_Lab456.Models;
using HuynhMinhTuan_Lab456.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace HuynhMinhTuan_Lab456.Controllers
{
    public class CoursesController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel();
            viewModel.Categories = _dbContext.Categories.ToList();
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        
    }
}