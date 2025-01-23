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
        private uint quantity;
        private string expirationDate;


        // Constructor
        public FoodItem(string name = "alien food", string category = "outer space", uint quantity = 1, string expirationDate = "01-18-2032")
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }

        public void PrintItemAttributes()
        {
            Console.WriteLine($"\nName: {this.name}");
            Console.WriteLine($"Category: {this.category}");
            Console.WriteLine($"Quantity: {this.quantity}");
            Console.WriteLine($"Expiration Date: {this.expirationDate}");
        }


        public void PrintForDeleting() //this shows limited data for the purpose of deleting inventory
        {
            Console.Write($"Name: {this.name}\t");
            Console.WriteLine($"Expiration Date: {this.expirationDate}");
        }
    }
}
