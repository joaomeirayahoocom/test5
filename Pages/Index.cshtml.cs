using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            ViewData["EnvName"] = _configuration["EnvironmentName"];
            ViewData["Level2Setting"] = _configuration["Level1:Level2"];
            ViewData["NonStickySetting"] = _configuration["NonStickySetting"];
            ViewData["ConnectionString"] = _configuration.GetConnectionString("MyDBConnection");
        }
    }
}

