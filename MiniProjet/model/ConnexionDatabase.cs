using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace MiniProjet.model
{
    public class ConnexionDatabase
    {
        readonly SQLiteAsyncConnection connexion;

        public ConnexionDatabase(String dbPath)
        {
            connexion = new SQLiteAsyncConnection(dbPath);
            connexion.CreateTableAsync<User>().Wait();
            connexion.CreateTableAsync<Voitures>().Wait();
            connexion.CreateTableAsync<Product>().Wait();
            connexion.CreateTableAsync<Category>().Wait();
        }

        public Task<int> deleteAllProducts()
        {
            return connexion.DeleteAllAsync<Product>();
        }
        public Task<int> deleteAllCategories()
        {
            return connexion.DeleteAllAsync<Category>();
        }
        public void deleteProduct(int id)
        {
            Object[] args = { id };
           connexion.QueryAsync<Product>("DELETE FROM Product WHERE id=?",args);
        }
        public Task<List<Product>> getProductsByCategory(int id)
        {
            Object[] args = { id };
            return connexion.QueryAsync<Product>("SELECT * FROM Product WHERE category=?",args);
        }
        public Task<List<Product>> getAllProducts()
        {
            return connexion.Table<Product>().ToListAsync();
        }
        public Task<List<Category>> getAllCategoryies()
        {
            return connexion.Table<Category>().ToListAsync();
        }
        public Task<int> saveProduct(Product product)
        {
            if (product.id != 0)
            {
                return connexion.UpdateAsync(product);
            }
            else
            {
                return connexion.InsertAsync(product);
            }
        }
       
        public Task<int> deleteCategory(Category category)
        {
            return connexion.DeleteAsync(category);
        }
        public Task<int> saveCategory(Category category)
        {
            if (category.id != 0)
            {
                return connexion.UpdateAsync(category);
            }
            else
            {
                return connexion.InsertAsync(category);
            }

        }
        public Task<int> saveUser(User user)
        {
            if (user.id != 0)
            {
                return connexion.UpdateAsync(user);
            }
            else
            {
                return connexion.InsertAsync(user);
            }

        }
        
         public Task<User> verifPassword(String username , String password)
        {
            return connexion.Table<User>().Where(u => u.username.Equals(username) && u.password.Equals(password)).FirstOrDefaultAsync();  
        }
        public Task<int> saveVoiture(Voitures voiture)
        {
            if (voiture.id != 0)
            {
                return connexion.UpdateAsync(voiture);
            }
            else
            {
                return connexion.InsertAsync(voiture);
            }
        }
        public Task<List<Voitures>> getAllVoitures()
        {
            return connexion.Table<Voitures>().ToListAsync();
        }
        
    }
}
