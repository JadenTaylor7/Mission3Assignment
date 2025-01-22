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

        public FoodItem(string name = "alien food", string category = "outer space", uint quantity = 1, string expirationDate = "2032-01-18")
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
        }

        // Constructor



        //TODO: create methods
    }
}
