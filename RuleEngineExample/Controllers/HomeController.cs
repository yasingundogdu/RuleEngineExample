using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RuleEngineExample.Models;
using RuleEngineExample.RuleEngine;
using RuleEngineExample.RuleEngine.Rules;
using RuleEngineExample.RuleEngine.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RuleEngineExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Age = 21,
                Gender = GenderEnum.Male.ToString(),
                MilitaryService = true,
                Name = "Murtaza Fidan",
                Department = "IT",
                Salary = 300000,
                Seniority = SeniorityEnum.Jr.ToString()
            });

            employees.Add(new Employee()
            {
                Age = 21,
                Gender = GenderEnum.Male.ToString(),
                MilitaryService = true,
                Name = "Cemşit Güllü",
                Department = "IT",
                Salary = 900000,
                Seniority = SeniorityEnum.Sr.ToString()
            });
            RuleEngineService<Employee> validatorService = new RuleEngineService<Employee>();
            var response = validatorService.ProcessValidate(employees, new List<IValidateRule<Employee>>
            {
                new AgeLimitRule(),
                new MilitaryServiceRule()
            });

            return View();
        }

        public IActionResult Privacy()
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
