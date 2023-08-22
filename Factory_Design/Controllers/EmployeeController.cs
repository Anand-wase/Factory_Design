using Factory_Design.Data;
using Factory_Design.Factory.AbstractFactory.AbstractInterface;
using Factory_Design.Factory.AbstractFactory.Client;
using Factory_Design.Factory.AbstractFactory.ConcreteFactory;
using Factory_Design.Factory.FactoryMethod;
using Factory_Design.Managers;
using Factory_Design.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Factory_Design.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var listofData = _context.Employees.Include(x => x.EmployeeType).ToList();
            return View(listofData);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeTypes, "Id", "Employee_Type");

            return View();

        }

        [HttpPost]
        public ActionResult Create(Employee model)
        {
                BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(model);
                empFactory.ApplySalary();
                IComputerFactory factory = new EmployeeSystemFactory().Create(model);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                model.ComputerDetails=manager.GetSystemDetails();
                _context.Employees.Add(model);
                _context.SaveChanges();
                ViewBag.Message = "Data Inserted Successfully";
                return RedirectToAction("Index");

            


            //ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeTypes, "Id", "Id", model.EmployeeTypeId);
            //return View(model);
        }
       

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            ViewData["EmployeeTypeId"] = new SelectList(_context.EmployeeTypes, "Id", "Employee_Type");

            return View(data);


        }

        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(model);
            empFactory.ApplySalary();
            IComputerFactory factory = new EmployeeSystemFactory().Create(model);
            EmployeeSystemManager manager = new EmployeeSystemManager(factory);
            model.ComputerDetails=manager.GetSystemDetails();
            var data = _context.Employees.Where(x => x.Id == model.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = model.Id;
                data.Name = model.Name;
                data.JobDescription = model.JobDescription;
                data.Number = model.Number;
                data.EmployeeTypeId = model.EmployeeTypeId;
                data.Bonus=model.Bonus;
                data.HourlyPay=model.HourlyPay;
                data.HouseAllowance=model.HouseAllowance;
                data.MedicalAllowance=model.MedicalAllowance;
                data.ComputerDetails = model.ComputerDetails;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = _context.Employees.Where(x => x.Id == id).FirstOrDefault();

            _context.Employees.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record Deleted Successfully";
            return RedirectToAction("Index");

        }
    }
}
