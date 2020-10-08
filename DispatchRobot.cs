namespace Tutorial1
{
    class DispatchRobot : WarehouseRobot
    {
        public DispatchRobot(string name) : base(name)
        {
        }

        public override void ProcessOrder(Order o)
        {
            o.Status = "Dispatched";
        }
    }
}
