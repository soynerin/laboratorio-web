using System.Web;

namespace Services
{
    public static class Configuration
    {
        public static string Host { get; set; } = HttpContext.Current.Request.Url.Host;
        
        public static int Port { get; set; } = HttpContext.Current.Request.Url.Port;
    }
}
