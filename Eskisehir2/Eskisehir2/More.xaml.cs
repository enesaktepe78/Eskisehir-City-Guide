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
    public partial class More : ContentPage
    {
        public More()
        {
            InitializeComponent();
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Information ", "This application gives information about places to visit and local dishes in Eskişehir ", "ok");

        }

        [Obsolete]
        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://enesaktepe78.github.io/bim222hmw1/contactme.html"));

        }
    }
}