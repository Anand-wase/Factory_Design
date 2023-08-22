using Factory_Design.Data;
using Factory_Design.Models;
using Microsoft.AspNetCore.Mvc;

namespace Factory_Design.Controllers
{
    public class EmployeeTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeTypeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var listofData = _context.EmployeeTypes.ToList();
            return View(listofData);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();  

        }

        [HttpPost]
        public ActionResult Create(EmployeeType model)
        {
            _context.EmployeeTypes.Add(model);  
            _context.SaveChanges();
            ViewBag.Message = "Data Inserted Successfully";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.EmployeeTypes.Where(x => x.Id == id).FirstOrDefault();
            return View(data);


        }

        [HttpPost]
        public ActionResult Edit(EmployeeType model)
        {
            var data = _context.EmployeeTypes.Where(x =>x.Id == model.Id).FirstOrDefault();
            if (data!= null)
            {
                data.Id = model.Id;
                data.Employee_Type = model.Employee_Type;
                _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = _context.EmployeeTypes.Where(x =>x.Id == id).FirstOrDefault();

            _context.EmployeeTypes.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record Delete Successfully";
            return RedirectToAction("Index");

        }
    }
}
