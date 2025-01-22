using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3Assignment
{
    internal class FoodItem
    {
        // Fields (making the variables this way increases security)
        private string name;
        private string category;
        private int quantity;
        private string expirationDate;

        // Constructor
        public FoodItem(string name, string category, int quantity, string expirationDate)
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }


        //TODO: create methods
    }
}
