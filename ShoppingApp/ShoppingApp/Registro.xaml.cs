using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registro : ContentPage
	{
		public Registro ()
		{
			InitializeComponent ();

        }
        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
          


            WebClient cliente = new WebClient();

            var parametros = new System.Collections.Specialized.NameValueCollection ();

            parametros.Add("nombre", entryNombre.Text);
            parametros.Add("edad", entryEdad.Text);
            parametros.Add("mail", entryMail.Text);
            parametros.Add("clave", entryClave.Text);
            parametros.Add("telefono", entryTelefono.Text);
            parametros.Add("direccion", entryDireccion.Text);

            cliente.UploadValues("http://192.168.18.35:3306/conn.php", "POST", parametros);

        }
    }
}