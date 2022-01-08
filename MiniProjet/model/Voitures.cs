using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MiniProjet.model
{
    public class Voitures
    {
        [PrimaryKey , AutoIncrement]
        public int id { get; set; }
        public String name { get; set; }
        public String image { get; set; }

    }
}
