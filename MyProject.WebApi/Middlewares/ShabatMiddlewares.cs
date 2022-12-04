using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Builder;

namespace MyProject.WebApi.Middlewares
{
    //public class ShabatMiddlewares
    //{
    //    public class TrackMiddleware
    //    {
    //        private readonly RequestDelegate _next;
    //        private readonly ILogger _logger;

    //        public TrackMiddleware(RequestDelegate next, ILogger<TrackMiddleware> logger)
    //        {
    //            _next = next;
    //            _logger = logger;
    //        }
    //        public async Task InvokeAsync(HttpContext context)
    //        {
    //            var requestSeq = Guid.NewGuid().ToString();
    //            _logger.LogInformation($"Request Starts {requestSeq}");
    //            context.Items.Add("RequestSeqence", requestSeq);
    //            await _next(context);
    //            _logger.LogInformation($"Request ends {requestSeq}");
    //        }
    //    }
    //}
    //public  static class ShabatMiddlewaresExtensions
    //{
    //    public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<TrackMiddleware>();
    //    }

    //}
}
