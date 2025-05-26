using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NhnLab06.Models;

namespace NhnLab06.Controllers
{
    public class NhnEmployeeController : Controller
    {
        static List<NhnEmployee> NhnListEmployee = new List<NhnEmployee>
        {
            new NhnEmployee { NhnId = 1, NhnName = "Nguyễn Văn A", NhnBirthDay = new DateTime(2002,1,1), NhnEmail = "a@student.com", NhnPhone = "0123456789", NhnSalary = 1000, NhnStatus = true },
            new NhnEmployee { NhnId = 2, NhnName = "Trần Thị B", NhnBirthDay = new DateTime(1995,5,5), NhnEmail = "b@mail.com", NhnPhone = "0987654321", NhnSalary = 1200, NhnStatus = false },
            new NhnEmployee { NhnId = 3, NhnName = "Lê Văn C", NhnBirthDay = new DateTime(1990,10,10), NhnEmail = "c@mail.com", NhnPhone = "0911222333", NhnSalary = 1500, NhnStatus = true },
            new NhnEmployee { NhnId = 4, NhnName = "Phạm Thị D", NhnBirthDay = new DateTime(1998,8,8), NhnEmail = "d@mail.com", NhnPhone = "0909090909", NhnSalary = 1800, NhnStatus = true },
            new NhnEmployee { NhnId = 5, NhnName = "Ngô Văn E", NhnBirthDay = new DateTime(2000,2,2), NhnEmail = "e@mail.com", NhnPhone = "0888999777", NhnSalary = 1100, NhnStatus = false }
        };

        public ActionResult NhnIndexEmployee()
        {
            return View(NhnListEmployee);
        }

        public ActionResult NhnCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NhnCreateSubmit(NhnEmployee newEmployee)
        {
            newEmployee.NhnId = NhnListEmployee.Count + 1;
            NhnListEmployee.Add(newEmployee);
            return RedirectToAction("NhnIndexEmployee");
        }
    }
}
