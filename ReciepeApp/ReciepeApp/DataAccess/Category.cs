using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReciepeApp.DataAccess
{
    class Category
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
