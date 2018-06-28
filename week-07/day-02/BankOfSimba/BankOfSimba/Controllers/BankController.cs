using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class BankController : Controller
    {
        public static List<BankAccount> bankAccounts = new List<BankAccount>()
        {
            new BankAccount("Simba", 2000, "Animal.Lion"),
            new BankAccount("Bimba", 12000, "Animal.Lion"),
            new BankAccount("Cimba", 3000, "Animal.Lion"),
            new BankAccount("King", 3000, "Animal.Lion")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Simba()
        {
            return View(bankAccounts);
        }

        [HttpPost]
        public IActionResult IncreaseBalance(BankAccount bankaccount)
        {

            return RedirectToAction("Bank/Simba.cshtml");
        }
    }
}