using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Twilio.Web.Models;

namespace Twilio.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly TwilioSmsSettings _twilioSmsSettings;

        public HomeController(ILogger<HomeController> logger, IOptions<TwilioSmsSettings> twilioSmsSettings)
        {
            _logger = logger;
            _twilioSmsSettings = twilioSmsSettings.Value;
        }

        [HttpGet]
        public async Task<IActionResult> SendSMS()
        {
            TwilioResponse response = new TwilioResponse();
            using (var client = new HttpClient {BaseAddress = new Uri(_twilioSmsSettings.BaseUri)})
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Basic",
                    Convert.ToBase64String(
                    Encoding.ASCII.GetBytes($"{_twilioSmsSettings.AccountSid}:{_twilioSmsSettings.AuthToken}")));

                var messageContent = new FormUrlEncodedContent(
                    new[]
                {
                        new KeyValuePair<string, string>("To", $"+999999999"), 
                        new KeyValuePair<string, string>("From", $"{_twilioSmsSettings.FromPhoneNumber}"),
                        new KeyValuePair<string, string>("Body", $"Hello from Mick's Twilio.Web01")
                });
                var requestUri = $"{_twilioSmsSettings.BaseUri}{_twilioSmsSettings.RequestUri}{_twilioSmsSettings.AccountSid}{_twilioSmsSettings.RequestEndpoint}";
                
                var result = await client.PostAsync(requestUri, messageContent).ConfigureAwait(false);

                response = JsonConvert.DeserializeObject<TwilioResponse>(await result.Content.ReadAsStringAsync());
            }

            return View("Index", response);

        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Privacy()
        {


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {


            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
