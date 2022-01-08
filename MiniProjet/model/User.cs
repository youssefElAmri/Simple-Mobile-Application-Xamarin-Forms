using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MiniProjet.model
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int id { get ; set; }
        public String username { get ; set; }
        public String password { get; set; }
        public String confPassword { get; set; }
    }
}
