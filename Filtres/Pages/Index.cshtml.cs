﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtres.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]
        public int testVriable { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public override void OnPageHandlerSelected(PageHandlerSelectedContext pageContext)
        {
            int a = 40;
        }
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext
       pageContext)
        {
            int a = 65;
        }
        public override void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 23;
        }
        public void OnGet()
        {
            int a = 12;
        }
    }
}
