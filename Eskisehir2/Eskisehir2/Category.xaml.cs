using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eskisehir2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Category : ContentPage
    {
        public Category()
        {
            InitializeComponent();

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new HistoricalPlaces(), true);


        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new LocalDishes(), true);

        }
    }
}