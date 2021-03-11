using Services;
using System;

namespace LaboratorioWeb
{
    public partial class PromotoresA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void OnClick(object sender, EventArgs e)
        {
            var expires = DateTime.Now + TimeSpan.FromMinutes(1);
            var hash = Helper.MakeExpiryHash(expires);
            var link = $"https://{Helper.Host}:{Helper.Port}/PromotoresB.aspx?exp={expires:s}&k={hash}";

            Response.Redirect(link);
        }
    }
}