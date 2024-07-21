using DeptHieracy.Models;
using DeptHieracy.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DeptHieracy.Controllers
{
    public class DeptController : Controller
    {
        private readonly Idept dept;

        public DeptController( Idept dept)
        {
            this.dept = dept;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetSubDept()
        {
            return View(dept.GetAll());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetSubDept(Dept department)
        {
            List<Dept> depts = dept.getSubDept(department);
            return View(depts);
        }
        [HttpGet]
        public IActionResult GetParDept()
        {
            return View(dept.GetAll());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetParDept(Dept department)
        {
            List<Dept> depts = dept.getParentDept(department);
            return View(depts);
        }
    }
}
