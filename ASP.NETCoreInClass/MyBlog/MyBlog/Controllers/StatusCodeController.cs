﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyBlog.Controllers
{
    public class StatusCodeController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        public StatusCodeController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }
        // GET: /<controller>/
        [HttpGet("/StatusCode/{statusCode}")]

        public IActionResult Index(int statusCode)
        {
            var reExecute = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            _logger.LogInformation($"Unexpected Status Code: {statusCode}, OriginalPath: {reExecute.OriginalPath}");
            return View(statusCode);
        }   
    }  
}