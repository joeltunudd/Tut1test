using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial1
{
    abstract class WarehouseRobot
    {
        private string _name;

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

        public WarehouseRobot(string name)
        {
            Name = name;
        }

        public abstract void ProcessOrder(Order o);


    }
}
