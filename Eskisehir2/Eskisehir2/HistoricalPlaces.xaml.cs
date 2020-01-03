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
    public partial class HistoricalPlaces : ContentPage
    {
        public IList<Historical> hst { get; private set; }

        public HistoricalPlaces()
        {
            InitializeComponent();

            hst = new List<Historical>();
            hst.Add(new Historical
            {
                Name = "Odunpazarı",
                ImageUrl = "odunpazari.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Yazılıkaya",
                ImageUrl = "yazilikaya.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Kurşunlu Mosque",
                ImageUrl = "kursunlu.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Kentpark",
                ImageUrl = "kentpark.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Şelale",
                ImageUrl = "selale.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Balmumu Museum",
                ImageUrl = "balmumu.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Eti Arkeoloji Museum",
                ImageUrl = "eti.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Çağdaş Cam Sanatları",
                ImageUrl = "cagdas.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Devrim Arabası",
                ImageUrl = "devrim.jpg"
            });

            hst.Add(new Historical
            {
                Name = "Odunpazarı Modern Museum",
                ImageUrl = "omm.jpg"
            });

            BindingContext = this;
        }



        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Historical selectedItem = e.SelectedItem as Historical;
        }

        async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Historical tappedItem = e.Item as Historical;
            for (int i = 0; i < 12; i++)
            {
                if (e.ItemIndex == i)
                {
                    Historical_Details.b = i + 1;
                }
            }
            await App.Current.MainPage.Navigation.PushModalAsync(new Historical_Details(), true);



        }


        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new Details(), true);

            Details.a = 1;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                list.ItemsSource = hst;
            }

            else
            {

                list.ItemsSource = hst.Where(x => x.Name.ToLower().Contains(e.NewTextValue));
            }
        }
    }
}