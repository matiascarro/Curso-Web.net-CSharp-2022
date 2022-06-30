using Acumulador.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Acumulador.Paginas
{
    public partial class Origen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Default.aspx?nombre=Tino&contador=40");
        }

        protected void ButtonTransfer_Click(object sender, EventArgs e)
        {
            Context.Items["info"] = new Informacion { Contador = 125, Nombre = "Geraldine" };
            Server.Transfer("~/Paginas/Default.aspx");
        }
    }
}