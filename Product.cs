using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial1
{
    class Product
    {
        private string _name;

        // Constructor, antar att detta blir rätt?
        public Product(string name)
        {
            Name = name;
            Name2 = name + "detta är bara för test, felaktiga get o setten alltså ej inkapslad";
        }

        // Property som är inkapslad korrekt.. 
        // internal ist för public ifall vi ville att endast VÅRT PROJEKT / Business logic endast ska komma åt detta.. 
        // Du kan ta bort Set för att få en readonly och vice vers.. 
        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }

        // Använd istället auto-property ifall du inte behöver logik i getter eller setter.. 
        public string Name2 { get; set; }
    }
}
