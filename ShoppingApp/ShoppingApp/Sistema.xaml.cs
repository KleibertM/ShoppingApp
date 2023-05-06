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
	public partial class Sistema : ContentPage
	{
		public Sistema ()
		{
			InitializeComponent ();
		}
        private async void btnHist_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Historia());

        }

        private async void btnPerso_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Personal());
        }

        private async void btnSist_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Sistema());
        }
    }
}