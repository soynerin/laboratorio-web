using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Services
{
    public static class HashServices
    {
        public static string MakeExpiryHash(DateTime expiry)
        {
            const double randomNumber = Math.PI * TimeSpan.TicksPerMillisecond;
            var bytes = Encoding.UTF8.GetBytes(randomNumber.ToString(CultureInfo.InvariantCulture) + expiry.ToString("s"));

            using (var sha = System.Security.Cryptography.SHA1.Create())
            {
                return string.Concat(sha.ComputeHash(bytes).Select(b => b.ToString("x2"))).Substring(8);
            }
        }
    }
}
