using Acumulador.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Acumulador
{
    //Stateful
    
    public partial class Default : System.Web.UI.Page
    {
        //localhost:45109/Paginas/Default.aspx?nombre=Matias&contador=35
        //https://www.google.com/search?channel=trow5&client=firefox-b-d&q=casas
        //https://www.google.com/search?q=casas+y+muebles&source=lmns&bih=955&biw=1920&client=firefox-b-d&hl=en&sa=X&ved=2ahUKEwjC38vV2M74AhVDVTUKHSneAI0Q_AUoAHoECAEQAA/otrac
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                this.lblMensaje.Text = "Sin un mecanismo auxilliar es imposible mantener el estado de la variable: el valor nunca se incrementa más allá de 1.";
            }
            else
            {
                var acumulador = new Acumulador { Contador = 0, Nombre = "Matias" };
                ViewState["i"] = acumulador;
                Session["i"] = acumulador;
                Session.Timeout = 1;
                Application["i"] = acumulador;
                Session.Timeout = 2;

            }

            Response.Cookies["i"].Value = 0.ToString();
            Response.Cookies["persistente"]["prop1"] = "Hola soy persistente1";
            Response.Cookies["persistente"]["prop2"] = "Hola soy persistente2";

            var acumulador2 = new Acumulador();
            if(Request.QueryString["nombre"] != null)
            {
                acumulador2.Nombre = Request.QueryString["nombre"];
            }
            if (Request.QueryString["contador"] != null)
            {
                acumulador2.Contador = Convert.ToInt32(Request.QueryString["contador"]);
            }
            if(acumulador2.Nombre != null && Request.QueryString["contador"] != null)
            {
                this.lblValor.Text = "Valor de la variable: " + acumulador2.Contador + " Nombre: " + acumulador2.Nombre;
            }

            if(Context.Items["info"] != null)
            {
                var info = Context.Items["info"] as Informacion;
                this.lblValor.Text = $"Valor de la variable: {info.Contador} Nombre: {info.Nombre}";
            }



            //string fechaCookie = Request.Cookies["Fecha"].Value;

            string Empresa = System.Configuration.ConfigurationManager.AppSettings["Empresa"];

        }

        //protected void Button_Click(object sender, EventArgs e)
        //{
        //    Acumulador acumulador = Application["i"] as Acumulador;
        //    acumulador.Contador++;
        //    this.lblValor.Text = "Valor de la variable: " + acumulador.Contador;
        //}

        //protected void Button_Click(object sender, EventArgs e)
        //{
        //    Acumulador acumulador = Session["i"] as Acumulador;
        //    acumulador.Contador++;
        //    this.lblValor.Text = "Valor de la variable: " + acumulador.Contador;
        //}

        protected void Button_Click(object sender, EventArgs e)
        {
            Acumulador acumulador = ViewState["i"] as Acumulador;
            acumulador.Contador++;
            this.lblValor.Text = "Valor de la variable: " + acumulador.Contador;
        }

        //protected void Button_Click(object sender, EventArgs e)
        //{
        //    int i = 0;
        //    if (Request.Cookies["i"] != null)
        //    { 
        //        i = Convert.ToInt32(Request.Cookies["i"].Value); 
        //    }
        //    Response.Cookies["i"].Value = (++i).ToString();
        //    this.lblValor.Text = "Valor de la variable: " + Response.Cookies["i"].Value;
        //}


    }

    [Serializable]
    public class Acumulador
    {
        public int Contador { get; set; }
        public string Nombre { get; set; }
    }
}