﻿using System;
using System.Collections.Generic;
using Concessionnaire.StrategyOrder;

namespace Concessionnaire
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var orders = new List<Order>();

            var orderCreator = new OrderCreator(orders);
            var orderPayer = new OrderPayer(orders);

            var paymentDate = DateTime.Now.AddYears(1);

            Console.WriteLine("--------------------------------------");

            orderCreator.CreateNewOrder(new SpotOrder(0, -5));
            orderCreator.CreateNewOrder(new ForwardOrder(1, 10, paymentDate));
            orderCreator.CreateNewOrder(new SpotOrder(2, 15));
            orderCreator.CreateNewOrder(new ForwardOrder(3, -90, paymentDate));

            orderPayer.PayAll();

            Console.WriteLine("--------------------------------------");

            Console.ReadLine();
        }
    }
}
