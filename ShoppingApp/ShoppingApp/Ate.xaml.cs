using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace ShoppingApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ate : ContentPage
	{
		public Ate ()
		{
			InitializeComponent ();

            Pin adrees = new Pin()
            {
                Type = PinType.Place,
                Label = "Adrees",
                Address = "Falabella Puruchuco",
                Position = new Position(-12.039819231826888, -76.93248575327226),
                Tag = "id_adrees",
            };

            map.Pins.Add(adrees);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(adrees.Position, Distance.FromMeters(500)));
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