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
    public partial class Boutique : MasterDetailPage
    {
        public ObservableCollection<Category> Items { get; set; }
      
        public Boutique()
        {
            InitializeComponent();
            
                Items = new ObservableCollection<Category>
                {
                    new Category{name="smartphone"},
                    new Category{name="laptop"},
                    new Category{name="accessory"},
                };

            //MyListView.ItemsSource = Items;
          //  App.Database.deleteAllCategories();

            //App.Database.saveCategory(new Category { name = "smartphone" });
            //App.Database.saveCategory(new Category { name = "laptop" });
            //App.Database.saveCategory(new Category { name = "accessory" });
            // App.Database.saveProduct(new Product { name = "iphone13", price = 5000, qte = 10, image = "https://selectshop.tn/18375-medium_default/smartphone-apple-iphone-13-pro-max-128-go-bleu-alpin.jpg", category = 2 });
            //App.Database.saveProduct(new Product { name = "samsung s21", price = 4500, qte = 20, image = "https://www.tryandbuy.tn/12597-medium_default/samsung-galaxy-s21-prix-tunisie.jpg", category = 2 });
            //  App.Database.saveProduct(new Product { name = "macbook air", price = 5000, qte = 5, image = "https://leclaireur.fnac.com/wp-content/uploads/2021/11/macbookair-m1-apple-1024x683.jpg", category = 3 });
            // App.Database.saveProduct(new Product { name = "Asus Vivobook", price = 2500, qte = 30, image = "https://www.ubuy.tn/productimg/?image=aHR0cHM6Ly9tLm1lZGlhLWFtYXpvbi5jb20vaW1hZ2VzL0kvODFOYnlOREM4ZVMuX0FDX1NMMTUwMF8uanBn.jpg", category = 3 });
            //App.Database.saveProduct(new Product { name = "airpods pro", price = 1250, qte = 8, image = "https://www.ispace.tn/wp-content/uploads/2020/10/5db801414c2f854258100aac-900Wx900H-820Wx820H-copie.jpg", category = 1 });
          // App.Database.deleteAllProducts();
        }
        protected async override void OnAppearing()
        {
            MyListCategories.ItemsSource = await App.Database.getAllCategoryies();
            MyListProducts.ItemsSource = await App.Database.getAllProducts();
           
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Label lblClicked = (Label)sender;
            var item = (TapGestureRecognizer)lblClicked.GestureRecognizers[0];
            var id = item.CommandParameter;
            _ = DisplayAlert("alert", id.ToString(), "ok");
            var i = int.Parse(id.ToString());
            MyListProducts.ItemsSource = await App.Database.getProductsByCategory(i);

        }

        private void btnAfficher_Clicked(object sender, EventArgs e)
        {
            var menuitem = sender as MenuItem;
            var product = menuitem.CommandParameter as Product;
            DisplayAlert("détail","id: "+product.id.ToString()+"| name: "+product.name+"| price: "+product.price+"| quantity: "+product.qte, "OK");
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            var menuitem = sender as MenuItem;
            var product = menuitem.CommandParameter as Product;
             App.Database.deleteProduct(product.id);
        }
    }
}