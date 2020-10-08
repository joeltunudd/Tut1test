using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Första testet Task 1-9
            //Product produkt1 = new Product("Golfklubba");
            //Console.WriteLine(produkt1.Name);
            //Console.WriteLine(produkt1.Name2);

            //Console.WriteLine(".....");

            //Order order1 = new Order(produkt1);
            //Console.WriteLine(order1.Status);
            //Console.WriteLine(order1.OrderedProduct.Name); // Alltså OrderedProduct är produkten som tilldelats

            //Console.WriteLine(".....");

            //PackingRobot packingRobot = new PackingRobot("thePackerRobot1");
            //packingRobot.ProcessOrder(order1);

            //Console.WriteLine(order1.Status);
            //Console.WriteLine(order1.OrderedProduct.Name);

            //Console.WriteLine(".....");

            //DispatchRobot dispatchRobot = new DispatchRobot("theDispatchingRobot1");
            //dispatchRobot.ProcessOrder(order1);
            //Console.WriteLine(order1.OrderedProduct.Name);
            //Console.WriteLine("just nu: " + order1.Status);

            //Console.WriteLine(".....");

            //DeliveryRobot deliveryRobot = new DeliveryRobot("theDeliveryRobot1");
            //deliveryRobot.ProcessOrder(order1);
            //Console.WriteLine(order1.OrderedProduct.Name);
            //Console.WriteLine("just nu: " + order1.Status);

            //Console.WriteLine(".....");

            //// en lista med robotar
            //List<WarehouseRobot> listOfWarehouseRobots = new List<WarehouseRobot>();
            //listOfWarehouseRobots.Add(packingRobot);
            //listOfWarehouseRobots.Add(dispatchRobot);
            //listOfWarehouseRobots.Add(deliveryRobot);

            //Console.WriteLine("NU jobbar robotarna:");

            //// Vi kan bara låta alla köra samma metod trots att de gör olika saker, det är fördelen med polymorfism
            //// och polymorfism är att de alla ärver från samma men gör olika saker.. 
            //foreach (var wareHouseRobot in listOfWarehouseRobots)
            //{
            //    wareHouseRobot.ProcessOrder(order1);
            //    Console.WriteLine(order1.OrderedProduct.Name + " is " + order1.Status);
            //}
            #endregion

            #region Uppgift 10

            PackingRobot packingRobot = new PackingRobot("thePackerRobot1");
            DispatchRobot dispatchRobot = new DispatchRobot("theDispatchingRobot1");
            DeliveryRobot deliveryRobot = new DeliveryRobot("theDeliveryRobot1");

            List<WarehouseRobot> listOfWarehouseRobots = new List<WarehouseRobot>();
            listOfWarehouseRobots.Add(packingRobot);
            listOfWarehouseRobots.Add(dispatchRobot);
            listOfWarehouseRobots.Add(deliveryRobot);

            var listOfAllOrders = new List<Order>();

            Console.WriteLine("Welcome to the warehouse management. Choose one of the following:");
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine("1. Add a new order");
                Console.WriteLine("2. Display status of all orders");
                Console.WriteLine("3. Process the last order by each robot");
                Console.WriteLine("4. Exit the program");


                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("What is the first product you want to add?");
                        string productInput = Console.ReadLine();
                        Product productNew = new Product(productInput);
                        Order orderNew = new Order(productNew);
                        listOfAllOrders.Add(orderNew);
                        Console.WriteLine("Added " + productNew.Name + " as an order.");
                        break;
                    case "2":
                        PrintDeliveryStatusOfAllOrders(listOfAllOrders);
                        break;
                    case "3":
                        if (listOfAllOrders.Any())
                        {
                            Order lastOrder = listOfAllOrders[listOfAllOrders.Count - 1];
                            foreach (var robot in listOfWarehouseRobots)
                            {
                                robot.ProcessOrder(lastOrder);
                                Console.WriteLine(lastOrder.OrderedProduct.Name + " is " + lastOrder.Status);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No order added yet");
                        }

                        break;
                    case "4":
                        return;
                    default:
                        break;
                }
            }
        }

        private static void PrintDeliveryStatusOfAllOrders(List<Order> listOfAllOrders)
        {
            Console.WriteLine("------");
            Console.WriteLine("All of the products ordered:");
            foreach (var order in listOfAllOrders)
            {
                Console.WriteLine("- " + order.OrderedProduct.Name + " and status is: " + order.Status);
            }
        }

        #endregion
    }
}
