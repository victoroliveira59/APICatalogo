﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace APICatalogo.Filters
{
    public class ApiLoggingFilter  : IActionFilter
    {
        private readonly ILogger<ApiLoggingFilter> _logger;

        public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Executando - > OnActionExecuting");
            _logger.LogInformation(DateTime.Now.ToShortTimeString());
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Executando - > OnActionExecuted");
            _logger.LogInformation(DateTime.Now.ToShortTimeString());
        }
    }
}
