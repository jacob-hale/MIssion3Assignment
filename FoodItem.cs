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


        public List<FoodItem> AddFoodItem(List<FoodItem> list)
        {
            // code to add food item into array
            list.Add(this);
            return list;
        }

        public List<FoodItem> DeleteFoodItem(List<FoodItem> list, String delName)
        {
            // code to delete food item from array
            list.RemoveAll(item => item.name.Equals(delName, StringComparison.OrdinalIgnoreCase));

            return list;
        }

        
    }
}
