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
    public partial class Details : ContentPage
    {
        public static readonly string TitleStyleKey = "TitleStyle";


        public static int a = 0;
        public Details()
        {
            InitializeComponent();
           
            switch (a)
            {
                case 1:
                    Resources["balaban"] = Resources["balaban"];
                    Resources["source"] = "balaban.jpg";
                    Resources["desp"] = Resources["desp"];
                    break;
                case 2:
                    Resources["balaban"] = Resources["met"];
                    Resources["source"] = "met.jpg";
                    Resources["desp"] = Resources["desp2"];
                    break;
                case 3:
                    Resources["balaban"] = Resources["ciborek"];
                    Resources["source"] = "ciborek.jpg";
                    Resources["desp"] = Resources["desp3"];
                    break;
                case 4:
                    Resources["balaban"] = Resources["yufka"];
                    Resources["source"] = "yufkali.jpg";
                    Resources["desp"] = Resources["desp4"];
                    break;
                case 5:
                    Resources["balaban"] = Resources["kiygasa"];
                    Resources["source"] = "kiygasa.jpg";
                    Resources["desp"] = Resources["desp5"];
                    break;
                case 6:
                    Resources["balaban"] = Resources["gozleme"];
                    Resources["source"] = "gozleme.jpg";
                    Resources["desp"] = Resources["desp6"];
                    break;
                case 7:
                    Resources["balaban"] = Resources["tarhana"];
                    Resources["source"] = "tarhana.jpg";
                    Resources["desp"] = Resources["desp7"];
                    break;
                case 8:
                    Resources["balaban"] = Resources["abista"];
                    Resources["source"] = "abista.jpg";
                    Resources["desp"] = Resources["desp8"];
                    break;
                case 9:
                    Resources["balaban"] = Resources["bamya"];
                    Resources["source"] = "bamya.jpg";
                    Resources["desp"] = Resources["desp9"];
                    break;
                case 10:
                    Resources["balaban"] = Resources["gobete"];
                    Resources["source"] = "gobete.jpg";
                    Resources["desp"] = Resources["desp10"];
                    break;
                case 11:
                    Resources["balaban"] = Resources["boza"];
                    Resources["source"] = "boza.jpg";
                    Resources["desp"] = Resources["desp11"];
                    break;
                case 12:
                    Resources["balaban"] = Resources["hashasli"];
                    Resources["source"] = "hashasli.jpg";
                    Resources["desp"] = Resources["desp12"];
                    break;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {



        }
    }
}