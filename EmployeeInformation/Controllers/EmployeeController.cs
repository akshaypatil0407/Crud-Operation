using EmployeeInformation.Data;
using EmployeeInformation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EmployeeInformation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;

        public EmployeeController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var result = context.Employee_Details.ToList();
            return View(result);
        }

        public IActionResult Create()
        {
            Employee_Details employee_Details = new Employee_Details();
            return View(employee_Details);
        }

        [HttpPost]
        public IActionResult Create(Employee_Details model)
        {
            if (ModelState.IsValid)
            {
                var emp = new Employee_Details()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender=model.Gender,
                    DOB=model.DOB,
                    Age=model.Age,
                    Address=model.Address,
                };
                context.Employee_Details.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);

            }
            
        }

        public IActionResult Delete(int id)
        {
            var emp=context.Employee_Details.SingleOrDefault(e => e.Id == id);
            context.Employee_Details.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var emp = context.Employee_Details.SingleOrDefault(e => e.Id==id);
            var result = new Employee_Details()
            {
                FirstName=emp.FirstName,
                LastName=emp.LastName,
                Gender=emp.Gender,
                DOB=emp.DOB,
                Age=emp.Age,
                Address=emp.Address
            };
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Employee_Details model)
        {
            var emp = new Employee_Details()
            {
                Id=model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                DOB = model.DOB,
                Age = model.Age,
                Address = model.Address,
            };

            context.Employee_Details.Update(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
