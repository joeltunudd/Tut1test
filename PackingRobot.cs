namespace Tutorial1
{
    class PackingRobot : WarehouseRobot
    {
        public PackingRobot(string name) : base(name)
        {

        }


        public override void ProcessOrder(Order o)
        {
            o.Status = "Packed";
        }
    }
}
