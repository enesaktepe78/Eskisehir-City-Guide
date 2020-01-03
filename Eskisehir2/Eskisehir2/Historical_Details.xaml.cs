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
    public partial class Historical_Details : ContentPage
    {
        public static int b = 0;
        public Historical_Details()
        {
            InitializeComponent();
            switch (b)
            {
                case 1:
                    Resources["odunpazari"] = Resources["odunpazari"];
                    Resources["source"] = "odunpazari.jpg";
                    Resources["desp"] = Resources["desp1"];
                    break;
                case 2:
                    Resources["odunpazari"] = Resources["yazilikaya"];
                    Resources["source"] = "yazilikaya.jpg";
                    Resources["desp"] = Resources["desp2"];
                    break;
                case 3:
                    Resources["odunpazari"] = Resources["kursunlu"];
                    Resources["source"] = "kursunlu.jpg";
                    Resources["desp"] = Resources["desp3"];
                    break;
                case 4:
                    Resources["odunpazari"] = Resources["kentpark"];
                    Resources["source"] = "kentpark.jpg";
                    Resources["desp"] = Resources["desp4"];
                    break;
                case 5:
                    Resources["odunpazari"] = Resources["selale"];
                    Resources["source"] = "selale.jpg";
                    Resources["desp"] = Resources["desp5"];
                    break;
                case 6:
                    Resources["odunpazari"] = Resources["balmumu"];
                    Resources["source"] = "balmumu.jpg";
                    Resources["desp"] = Resources["desp6"];
                    break;
                case 7:
                    Resources["odunpazari"] = Resources["eti"];
                    Resources["source"] = "eti.jpg";
                    Resources["desp"] = Resources["desp7"];
                    break;
                case 8:
                    Resources["odunpazari"] = Resources["cagdas"];
                    Resources["source"] = "cagdas.jpg";
                    Resources["desp"] = Resources["desp8"];
                    break;
                case 9:
                    Resources["odunpazari"] = Resources["devrim"];
                    Resources["source"] = "devrim.jpg";
                    Resources["desp"] = Resources["desp9"];
                    break;
                case 10:
                    Resources["odunpazari"] = Resources["omm"];
                    Resources["source"] = "omm.jpg";
                    Resources["desp"] = Resources["desp10"];
                    break;
                
            }
        }

       
    }
}