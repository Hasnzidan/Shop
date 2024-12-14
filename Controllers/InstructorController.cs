using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Controllers
{
    public class InstructorController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            List<Instructor> Instructorlist = 
                _context.Instructor
                .Include(i => i.Department)
                .Include(i => i.Course)
                .ToList();
            return View("Index",Instructorlist);
        }

        // GET: Instructor/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
        
            Instructor Instructor = _context.Instructor
                .Include(i => i.Department)
                .Include(i => i.Course)
                .FirstOrDefault(m => m.Id == id);
            
            if (Instructor == null)
            {
                return NotFound();
            }
        
            return View("Details", Instructor);
        }
    }
}
