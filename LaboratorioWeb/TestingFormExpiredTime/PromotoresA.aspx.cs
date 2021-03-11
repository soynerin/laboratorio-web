using System;
using Services;

namespace TestingFormExpiredTime
{
    public partial class PromotoresA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void OnClick(object sender, EventArgs e)
        {
            var expires = DateTime.Now + TimeSpan.FromMinutes(1);
            var hash = HashServices.MakeExpiryHash(expires);
            var link = $"https://{Configuration.Host}:{Configuration.Port}/PromotoresB.aspx?exp={expires:s}&k={hash}";

            Response.Redirect(link);
        }
    }
}