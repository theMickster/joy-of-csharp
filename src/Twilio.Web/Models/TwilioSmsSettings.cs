namespace Twilio.Web.Models
{
    public class TwilioSmsSettings
    {
        public string AccountSid { get; set; }

        public string AuthToken { get; set; }

        public string BaseUri { get; set; }

        public string RequestUri { get; set; }

        public string RequestEndpoint { get; set; }

        public string FromPhoneNumber { get; set; }
    }
}
