using Services;
using System;
using System.IO;

namespace LaboratorioWeb
{
    public partial class PromotoresB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime expires = DateTime.Parse(Request.Params["exp"]);
            string hash = Helper.MakeExpiryHash(expires);
            if (Request.Params["k"] == hash)
            {
                if (expires < DateTime.Now)
                {
                    // Link has expired
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('expiró el link');", true);
                    Response.Redirect("https://localhost:44385/PromotoresA.aspx");
                }
                else
                {
                    // HACER ALGO
                }
            }
            else
            {
                // Invalid link
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('link inválido');", true);
                Response.Redirect("https://localhost:44385/PromotoresA.aspx");
            }
        }
    }
}