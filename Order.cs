using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial1
{
    class Order
    {
        private Product _orderedProduct;



        // ctor
        public Order(Product product)
        {
            OrderedProduct = product;
            Status = "Ordered";
        }

        // Vet inte om denna behövde vara inkapslad men gjorde det ändå. 
        public Product OrderedProduct
        {
            get
            {
                return _orderedProduct;
            }
            set
            {
                _orderedProduct = value;
            }
        }

        // Ej inkapslad än.. 
        public string Status { get; set; }

    }
}
