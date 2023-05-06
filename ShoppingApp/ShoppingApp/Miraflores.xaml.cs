using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Miraflores : ContentPage
	{
		public Miraflores ()
		{
			InitializeComponent ();
		}
        private async void btnSur_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Surco());
        }

        private async void btnAte_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Ate());
        }

        private async void btnMirf_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Miraflores());
        }
    }
}