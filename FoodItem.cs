using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;

namespace MIssion3Assignment
{
    internal class FoodItem
    {
        public string name;
        public string category;
        public int quantity;
        public string expirationDate;
        public FoodItem(string name, string category, int quantity, string expirationDate) 
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;

            // array of arrays to hold food item details
        }

        public List<string[]> AddFoodItem(List<string[]> list)
        {
            // code to add food item into array
            string[] itemData = { name, category, quantity.ToString(), expirationDate };
            list.Add(itemData);
            return list;
        }

        public void DeleteFoodItem()
        {
            // code to delete food item from array
            // enter name of food item to delete
            // loop through array to find food item and delete it
        }

        
    }
}
