using Avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avaliacao.DAL
{
    public class MockProductDao
    {
        public static List<Product> GetAllProducts()
        {
            var groceriesCategory = new Category(1, "Groceries");
            var beveragesCategory = new Category(2, "Beverages");
            var vegetablesCategory = new Category(3, "Vegetables");
            var fruitsCategory = new Category(4, "Fruits");
            var meatCategory = new Category(5, "Meat, Fish & Poultry");
            var bakingCategory = new Category(6, "Baking");
            string newProduct = "New";
            string fiveOff = "5% Off";
            var productList = new List<Product>(37);
            productList.AddRange(new Product[]
        {
            new Product(1,"Potato",4.50m,new Category[] {groceriesCategory,vegetablesCategory },new string[] {newProduct,fiveOff}),
            new Product(2,"Onion",2.35m,new Category[] {groceriesCategory,vegetablesCategory },new string[] {fiveOff}),
            new Product(3,"Carrot",3.90m,new Category[] {groceriesCategory,vegetablesCategory },new string[0]),
            new Product(4,"Bread",0.90m,new Category[] {groceriesCategory},new string[0]),
            new Product(5,"Butter",1.30m,new Category[] {groceriesCategory},new string[0]),
            new Product(6,"Pasta",2.35m,new Category[] {groceriesCategory},new string[0]),
            new Product(7,"Popcorn",4.12m,new Category[] {groceriesCategory},new string[0]),
            new Product(8,"Cereal",3.08m,new Category[] {groceriesCategory},new string[0]),
            new Product(9,"Vegetables Soup",2.37m,new Category[] {groceriesCategory},new string[0]),
            new Product(10,"Cookies",1.99m,new Category[] {groceriesCategory},new string[0]),
            new Product(11,"Crackers",1.89m,new Category[] {groceriesCategory},new string[0]),
            new Product(12,"Oatmeal",0.99m,new Category[] {groceriesCategory},new string[0],true),
            new Product(13,"Cheese",2.09m,new Category[] {groceriesCategory},new string[0]),
            new Product(14,"Apple",0.19m,new Category[] {groceriesCategory,fruitsCategory},new string[0]),
            new Product(15,"Pineapple",0.39m,new Category[] {groceriesCategory,fruitsCategory},new string[0]),
            new Product(16,"Orange",0.23m,new Category[] {groceriesCategory,fruitsCategory},new string[0]),
            new Product(17,"Grape",0.35m,new Category[] {groceriesCategory,fruitsCategory},new string[0],true),
            new Product(18,"Strawberrie",0.35m,new Category[] {groceriesCategory,fruitsCategory},new string[0]),
            new Product(19,"Beef",11.10m,new Category[] {groceriesCategory,meatCategory},new string[0]),
            new Product(20,"T-Bone",14.80m,new Category[] {groceriesCategory,meatCategory},new string[0]),
            new Product(21,"Salmon",8.80m,new Category[] {groceriesCategory,meatCategory},new string[0]),
            new Product(22,"Shrimp",18.80m,new Category[] {groceriesCategory,meatCategory},new string[0]),
            new Product(23,"Pork",5.90m,new Category[] {groceriesCategory,meatCategory},new string[0],true),
            new Product(24,"Turkey",5.80m,new Category[] {groceriesCategory,meatCategory},new string[0]),
            new Product(25,"Sausage",4.80m,new Category[] {groceriesCategory,meatCategory},new string[0]),
            new Product(26,"Flour",0.80m,new Category[] {groceriesCategory,bakingCategory},new string[0]),
            new Product(27,"Nuts",2.80m,new Category[] {groceriesCategory,bakingCategory},new string[0],true),
            new Product(28,"Sugar",1.50m,new Category[] {groceriesCategory,bakingCategory},new string[0]),
            new Product(29,"Vanilla",4.50m,new Category[] {groceriesCategory,bakingCategory},new string[0]),
            new Product(30,"Honey",1.65m,new Category[] {groceriesCategory,bakingCategory},new string[0]),
            new Product(31,"Beer",0.99m,new Category[] {groceriesCategory,beveragesCategory},new string[0]),
            new Product(32,"Water",0.14m,new Category[] {groceriesCategory,beveragesCategory},new string[0]),
            new Product(33,"Orange Juice",0.49m,new Category[] {groceriesCategory,beveragesCategory},new string[0]),
            new Product(34,"Apple Juice",0.49m,new Category[] {groceriesCategory,beveragesCategory},new string[0]),
            new Product(35,"Pineapple Juice",0.46m,new Category[] {groceriesCategory,beveragesCategory},new string[] { fiveOff }),
            new Product(36,"Spanish Wine",3.99m,new Category[] {groceriesCategory,beveragesCategory},new string[0]),
            new Product(37,"Italian Wine",3.99m,new Category[] {groceriesCategory,beveragesCategory},new string[0])
        });
            return productList;
        }
    }
}