﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace Demo.Pubs.API.Extensions
{
    public static class ApplicationBuilderAppInsightsLoggerExtensions
    {
        public static IApplicationBuilder UseAppInsightsLogger(this IApplicationBuilder builder,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddApplicationInsights(builder.ApplicationServices, LogLevel.Warning);
            return builder;
        }
    }
}
