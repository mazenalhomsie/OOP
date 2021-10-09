using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Order
    {
        public int ID
        {
            get => ID;
            set => ID.GetHashCode();
        }

        public DateTime purchaseOrderDate
        {
            get => purchaseOrderDate;
            set => purchaseOrderDate = DateTime.Now;
        }

    }
}
