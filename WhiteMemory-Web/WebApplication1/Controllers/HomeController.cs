using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Data;
using WebApplication1.Models;

using Nethereum.Web3;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _db = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = _db.BlockchainContracts.ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            BlockchainContract model = new BlockchainContract();
            //var web3 = new Web3("https://localhost:44392/");
            //var balance = await web3.Eth.GetBalance.SendRequestAsync("");
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(BlockchainContract model)
        {
            _db.BlockchainContracts.Add(model);
            _db.SaveChanges();
            return Redirect("~/"); 
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetBlockchainData()
        {
            return View();
        }
    }
}
