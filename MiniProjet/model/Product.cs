using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace MiniProjet.model
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public String name { get; set;}
        public float price { get; set; }
        public int qte { get; set; }
        public String image { get; set; }
        [ForeignKey(typeof(Category))]
        public int category { get; set; }

    }
}
