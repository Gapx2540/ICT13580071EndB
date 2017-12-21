using System;
using SQLite;
using ICT13580071EndB.Models;
using System.Collections.Generic;
using System.Linq;

namespace ICT13580071EndB.Helpers
{
    public class DbHelper
    {
        SQLiteConnection db;
        public DbHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();
        }
        public int AddProduct(Product product)
        {
            db.Insert(product);
            return product.Id;

        }
           
        public List<Product> GetProduct()
        {
            return db.Table<Product>().ToList();
        }
        public int UpdateProduct(Product product)
        {
            return db.Update(product);
        }
        public int DeleteProduct(Product product)
        {
            return db.Delete(product);
        }
    }
}




