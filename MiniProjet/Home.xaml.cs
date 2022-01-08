using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniProjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            b.Clicked += (sender, e) => { Navigation.PushAsync(new Boutique()); };
            v.Clicked += (sender, e) => { Navigation.PushAsync(new Voituree()); };
            isetr.Clicked += (sender, e) => { Navigation.PushAsync(new IsetRades()); };
        }
    }
}