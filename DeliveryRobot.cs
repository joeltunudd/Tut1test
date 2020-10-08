namespace Tutorial1
{
    class DeliveryRobot : WarehouseRobot
    {
        public DeliveryRobot(string name) : base(name)
        {
        }

        public override void ProcessOrder(Order o)
        {
            o.Status = "Delivered";
        }
    }
}
