using MiniProjet.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniProjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Voituree : ContentPage
    {
        public ObservableCollection<Voitures> Items { get; set; }
        private List<string> ImagesList;

        public Voituree()
        {
            InitializeComponent();
            /*
            Items = new ObservableCollection<Voitures>
            {
             new Voitures { name = "passat", image = "https://images.caradisiac.com/logos/7/2/9/8/267298/S8-fiabilite-de-la-volkswagen-passat-8-la-maxi-fiche-occasion-de-caradisiac-190890.jpg" },
            new Voitures {name="apple car",image="https://images.frandroid.com/wp-content/uploads/2021/11/apple-car-concept.jpg"},
            new Voitures {name="Ferrari",image="https://i.gaw.to/content/photos/44/38/443849-cette-nouvelle-ferrari-812-est-litteralement-unique-au-monde.jpg"},
            new Voitures {name="mercedes",image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCwVWbHAYsHUg99DsqMjnnOjMTqHXsT8K0NA&usqp=CAU"},
            new Voitures{name="citroen",image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSip-yGh_ZUb-ZCYdQIa9ieBd-cLcpyy5j5sQ&usqp=CAU"}
            };
            MyListView.ItemsSource = Items;
        
            App.Database.saveVoiture(new Voitures { name = "passat", image = "https://images.caradisiac.com/logos/7/2/9/8/267298/S8-fiabilite-de-la-volkswagen-passat-8-la-maxi-fiche-occasion-de-caradisiac-190890.jpg" });
            App.Database.saveVoiture(new Voitures { name = "apple car", image = "https://images.frandroid.com/wp-content/uploads/2021/11/apple-car-concept.jpg" });
            App.Database.saveVoiture(new Voitures { name = "Ferrari", image = "https://i.gaw.to/content/photos/44/38/443849-cette-nouvelle-ferrari-812-est-litteralement-unique-au-monde.jpg" });
            App.Database.saveVoiture(new Voitures { name = "mercedes", image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCwVWbHAYsHUg99DsqMjnnOjMTqHXsT8K0NA&usqp=CAU" });
            App.Database.saveVoiture(new Voitures { name = "citroen", image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSip-yGh_ZUb-ZCYdQIa9ieBd-cLcpyy5j5sQ&usqp=CAU" });
        */
            
        }

        protected async override void OnAppearing()
        {
       
            cv.ItemsSource = await App.Database.getAllVoitures();
        
        // MyListView.ItemsSource = await App.Database.getAllVoitures();
    }
    }
}