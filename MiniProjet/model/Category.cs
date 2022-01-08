using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace MiniProjet.model
{
    public class Category
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public String name { get; set; }
        [OneToMany]
        public List<Product> products { get; set; }
    }
}
