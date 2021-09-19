using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace CoffeeShopProductList.Models
{
    public class DAL
    {


        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=coffeeshoproster; Uid=root;Password=@OurBe3utifulNew1Home");


        public static List<Product> GetProducts()
        {
            return DB.GetAll<Product>().ToList();
        }

    public static Product GetAProduct(string id)
        {
            return DB.Get<Product>(id);
        }

    }
}
