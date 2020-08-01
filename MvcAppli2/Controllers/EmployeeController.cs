using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MvcAppli2.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get() 
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            EmployeeBusinessLayer employeeBusinessLayer =
                    new EmployeeBusinessLayer();
            Employee employee = new Employee();
            TryUpdateModel(employee);
            if (ModelState.IsValid)
            {
                employeeBusinessLayer.AddEmmployee(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }            
        }

        [HttpGet]
        public ActionResult Edit(int id) {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(emp=>emp.ID==id);

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.SaveEmployee(employee);

            return View(employee);
        }
    }
}
