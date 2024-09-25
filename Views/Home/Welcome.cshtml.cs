using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TodoApp.Views.Home
{
    public class Welcome : PageModel
    {
        private readonly ILogger<Welcome> _logger;

        public Welcome(ILogger<Welcome> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}