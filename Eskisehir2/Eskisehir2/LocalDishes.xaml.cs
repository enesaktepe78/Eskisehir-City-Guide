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
    public partial class LocalDishes : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }

        public LocalDishes()
        {
            InitializeComponent();

            Monkeys = new List<Monkey>();
            list.ItemsSource = Monkeys;
            Monkeys.Add(new Monkey
            {
                Name = "Balaban Köfte",
                ImageUrl = "balaban.jpg"

            });

            Monkeys.Add(new Monkey
            {
                Name = "Met Helvası",
                ImageUrl = "met.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Çibörek",
                ImageUrl = "ciborek.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = " Yufkalı Büryan",
                ImageUrl = "yufkali.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Kıygaşa",
                ImageUrl = "kiygasa.png"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Haşhaşlı Gözleme",
                ImageUrl = "gozleme.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Göceli Tarhana",
                ImageUrl = "tarhana.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Abısta",
                ImageUrl = "abista.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Bamya Çorbası",
                ImageUrl = "bamya.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Göbete",
                ImageUrl = "gobete.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Boza",
                ImageUrl = "boza.jpg"
            });

            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Monkey selectedItem = e.SelectedItem as Monkey;

        }

        async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {

            Monkey tappedItem = e.Item as Monkey;
            Console.WriteLine(tappedItem);

            //binding ile yapabilirsin resource değiştirmeyi

            for (int i = 0; i < 12; i++)
            {
                if (e.ItemIndex == i)
                {
                    Details.a = i + 1;
                }
            }


            await App.Current.MainPage.Navigation.PushModalAsync(new Details(), true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Resources["balaban"] = "as";

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                list.ItemsSource = Monkeys;
            }

            else
            {

                list.ItemsSource = Monkeys.Where(x => x.Name.ToLower().Contains(e.NewTextValue));
            }
        }
    }
}