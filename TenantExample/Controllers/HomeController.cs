using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TenantExample.Data;
using TenantExample.Data.Services;
using TenantExample.Models;

namespace TenantExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITenantScopeProvider scopeProvider;
        private readonly NameService nameService;

        public HomeController(ITenantScopeProvider scopeProvider, NameService nameService)
        {
            this.scopeProvider = scopeProvider;
            this.nameService = nameService;
        }

        [Route("{tenant}")]
        public IActionResult ForTenant(string tenant)
        {
            using (scopeProvider.WithTenant(tenant))
            {
                var contextName = nameService.GetContextName();
                return View("Index", contextName);
            }
        }

        public IActionResult Index()
        {
            var contextName = nameService.GetContextName();
            return View("Index", contextName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
