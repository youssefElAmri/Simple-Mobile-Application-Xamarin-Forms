using MiniProjet.model;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btn.Clicked += (sender, e) => {
                
                //User user1 = new User { username = "admin", password = "admin", confPassword = "admin" };
                //App.Database.saveUser(user1);
                Task<User> user = App.Database.verifPassword(username.Text,password.Text);
                //Console.WriteLine("user "+user.Result.ToString());
                if (user.Result != null) { Navigation.PushAsync(new Home()); }
                else
                {
                    DisplayAlert("alert", username.Text + " n ' existe pas", "cancel");
                }
                                               
            };
        }

        private void signUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AjouterUser());
        }
    }
}