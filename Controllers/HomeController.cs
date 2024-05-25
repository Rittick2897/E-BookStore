using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Bookish.DataModel;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;
        private readonly BookDb _bookDB;
        public HomeController(ILogger<HomeController> logger, HttpClient httpClient, BookDb bookDb)
        {
            _logger = logger;
            _httpClient = httpClient;
            _bookDB = bookDb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        } 
        public async Task<IActionResult> PscychologyOfMoney()
        {
            var result = await _bookDB.BookDbSet.ToListAsync();
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
