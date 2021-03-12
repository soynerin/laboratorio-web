using Services;
using System;

namespace TestingFormExpiredTime
{
    public partial class PromotoresB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var expires = DateTime.Parse(Request.Params["exp"]);
            var hash = HashServices.MakeExpiryHash(expires);

            if (Request.Params["k"] == hash)
            {
                if (expires < DateTime.Now)
                {
                    ClientScript.RegisterStartupScript(GetType(), "expiredalert", "alert('expiró el link');", true);
                    //Response.Redirect($"https://{Configuration.Host}:{Configuration.Port}/PromotoresA.aspx");
                }
                else
                {
                    // HACER ALGO
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "invalidAlert", "alert('link inválido');", true);
                //Response.Redirect($"https://{Configuration.Host}:{Configuration.Port}/PromotoresA.aspx");
            }
        }
    }
}