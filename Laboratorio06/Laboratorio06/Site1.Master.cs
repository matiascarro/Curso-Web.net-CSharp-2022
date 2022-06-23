using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio06
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ulMenuInicio.Text = "<ul class= \"dropdown-menu\">";
            //ulMenuFinal.Text = "</ul>";
            //liAbre.Text = "<li class = \"dropdown-item\">";
            //liCierra.Text = "</li>";
        }

        protected void HyperLinkAdministracion_Load(object sender, EventArgs e)
        {
            HyperLinkAdministracion.NavigateUrl = "Administracion.aspx";
        }

        protected void HyperLinkAyuda_Load(object sender, EventArgs e)
        {
            HyperLinkAyuda.NavigateUrl = "Ayuda.aspx";
        }

        protected void HyperLinkVolver_Load(object sender, EventArgs e)
        {
            HyperLinkVolver.NavigateUrl = "Index.aspx";
        }

    }
}