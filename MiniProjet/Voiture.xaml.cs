using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MiniProjet.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniProjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Voiture : ContentPage
    {
        

        public ObservableCollection<String> Items { get; set; }

        public Voiture()
        {
            InitializeComponent();


            Voitures voiture = new Voitures { name = "golf", image = "https://www.auto-moto.com/wp-content/uploads/sites/9/2020/02/volkswagen-golf-750x410.jpg" };
            Voitures voiture2 = new Voitures { name = "mercedes", image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.caradisiac.com%2Fplus-belle-voiture-de-l-annee-2021-et-la-gagnante-est-187752.htm&psig=AOvVaw0uKYmH9nqWhVPm3IaksHKK&ust=1640696313831000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCIj05OeEhPUCFQAAAAAdAAAAABAD" };

            App.Database.saveVoiture(voiture);
            Items = new ObservableCollection<String>
            {
                "voiture",
                "voiture2"
            };
            
            MyListView.ItemsSource = Items;
        }
       /* protected override void OnAppearing()
        {
            //MyListView.ItemsSource = await App.Database.getAllVoitures();
             Voitures voiture = new Voitures { name = "golf", image = "https://www.auto-moto.com/wp-content/uploads/sites/9/2020/02/volkswagen-golf-750x410.jpg" };
             Items.Add(voiture);
            M
        }
       */
        /*    async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
            {
                if (e.Item == null)
                    return;

                await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

                //Deselect Item
                ((ListView)sender).SelectedItem = null;
            }
        */
    }
}
