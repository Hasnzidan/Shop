using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Models;
using Shop.ViewModels;

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

        
       // GET: Instructor/Create
       public IActionResult Create()
       {
            var instructorVM = new InstructorVM
            {
                Department = _context.Department.ToList(),
                Course = _context.Course.ToList()
            };

            return View("Create", instructorVM);
       }
       
       // POST: Instructor/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
       public IActionResult Create(InstructorVM instructorVM)
       {
       
           if (ModelState.IsValid)
           {
               var instructor = new Instructor
               {
                   Name = instructorVM.Name,
                   Salary = (int)instructorVM.Salary,
                   ImgURL = instructorVM.ImgURL,
                   Address = instructorVM.Address,
                   DeptId = instructorVM.DeptId,
                   CrsId = instructorVM.CrsId,
                   Department = _context.Department.Find(instructorVM.DeptId),
                   Course = _context.Course.Find(instructorVM.CrsId)
               };
       
                               _context.Instructor.Add(instructor);
               _context.SaveChanges();
              return RedirectToAction("Index");
           }
            instructorVM.Department = _context.Department.ToList();
            instructorVM.Course = _context.Course.ToList();
           return View(instructorVM);
       }

        // GET: Instructor/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
        
            var instructor = _context.Instructor
                .Include(i => i.Department)
                .Include(i => i.Course)
                .FirstOrDefault(m => m.Id == id);
        
            if (instructor == null)
            {
                return NotFound();
            }
        
            // Load ViewBag data before creating the ViewModel
           List<Department> departments = _context.Department.ToList();
           List<Course> courses = _context.Course.ToList();
        
            var instructorVM = new InstructorVM
            {
                Id = instructor.Id,
                Name = instructor.Name ?? string.Empty,
                Salary = instructor.Salary,
                ImgURL = instructor.ImgURL,
                Address = instructor.Address ?? string.Empty,
                DeptId = instructor.DeptId,
                CrsId = instructor.CrsId,
                Department = departments,
                Course = courses
            };
            return View("Edit",instructorVM);
        }
        
       [HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Edit(int id, InstructorVM instructorVM)
{
    if (id != instructorVM.Id)
    {
        return NotFound();
    }

    // Manually check if DeptId and CrsId are valid (not 0 or default value)
    
    if (ModelState.IsValid)
    {
        // Update the instructor details in the database
        var instructor = _context.Instructor.Find(id);
        if (instructor == null)
        {
            return NotFound();
        }

        instructor.Name = instructorVM.Name;
        instructor.Salary = instructorVM.Salary;
        instructor.ImgURL = instructorVM.ImgURL;
        instructor.Address = instructorVM.Address;
        instructor.DeptId = instructorVM.DeptId;
        instructor.CrsId = instructorVM.CrsId;

        _context.Instructor.Update(instructor);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    return View(instructorVM);
}        
        private bool InstructorExists(int id)
        {
            return _context.Instructor.Any(e => e.Id == id);
        }
    }
}
