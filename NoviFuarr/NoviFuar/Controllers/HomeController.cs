using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoviFuar.Models;
using BusinessLayer.ValidationRules;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using X.PagedList.Mvc.Core;



namespace NoviFuar.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Console.WriteLine("log1", logger);
            
        }

        //-----------------------

        VisitorManager vm = new VisitorManager(new EfVisitorRepository());

        PersonalManagementManager pm = new PersonalManagementManager(new EfPersonalManagementRepository());
        //----------
        //----------------------------------START----------------------------------//
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //----------------------------------END----------------------------------//

        //-------------------------------START----------------------------------//
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Visitors(int visitors =1)
        {
            var values = vm.GetList().ToPagedList(visitors,7);

            return View(values);
        }

        

        //----------------------------------END-------------------------------------//

        public IActionResult Reports()
        {
            return View();
        }


        //----------------------------------START----------------------------------//
        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Personals(PersonalManagement personal)
        {
            var values = pm.GetList();

            return View(values);
        }




        //------------------------------------END----------------------------------//
        //Add Visitor Procedure

        public IActionResult PopUpModal()
        {
            return View();
        }
        //----------------------------------START----------------------------------//

        [HttpGet]
        public IActionResult VisitorProcedures()
        {


            return View(new Visitors());
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult VisitorProcedures(Visitors p)
        {


            VisitorValidator vv = new VisitorValidator();
            ValidationResult result = vv.Validate(p);

            if(result.IsValid)
            {
                vm.AddVisitor(p);
                return RedirectToAction(nameof(VisitorProcedures));
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            
            return View(p);


        }


        //Add Visitor Procedure
        /*-------------------------------------END---------------------------------------*/

        public IActionResult PersonalProcedures()
        {
            return View();
        }

        //-----------------------------END----------------------------//
        public IActionResult HelpCenter()
        {
            return View();
        }

        public IActionResult _VisitorsModalPartial()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



//Refactoring isi sana kaldi sende.Onceki yazilimci.