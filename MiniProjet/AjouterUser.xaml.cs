using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProjet.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniProjet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjouterUser : ContentPage
    {
        public AjouterUser()
        {
            InitializeComponent();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            if (username.Text==null || password.Text==null || confPassword.Text==null)
            {
                await DisplayAlert("erreur", "il faut remplir tout les champs", "cancel");
            } else if (!password.Text.Equals(confPassword.Text))
            {
                await DisplayAlert("erreur", "le confirmer Password doit etre identique ", "cancel");

            }
            else
            {
                User user = new User
                {
                    username = username.Text,
                    password = password.Text,
                    confPassword = confPassword.Text
                };
                await App.Database.saveUser(user);
                await DisplayAlert("ajoutUser", "user added", "OK");
                await Navigation.PushAsync(new Login());
            }
        }
    }
}