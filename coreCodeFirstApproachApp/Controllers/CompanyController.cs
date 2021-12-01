using coreCodeFirstApproachApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachApp.Controllers
{
    public class CompanyController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();
        public IActionResult Index()
        {
            var companies = context.Companies.ToList();
            return View(companies);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            // var company = context.Companies.Find(id);//works only for id coloumn
            var company = context.Companies.Where(c => c.CompanyId == id).FirstOrDefault();
            return View(company);
        }
        public IActionResult Delete(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }
        [HttpPost]
        public IActionResult Delete(int id, Company company)
        {
            var companyObj = context.Companies.Find(id);
            context.Companies.Remove(companyObj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            context.Companies.Update(company);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
