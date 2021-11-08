using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Order
    {
        private static readonly int orderNumber = new Random().Next(0, 1000);
        
        public static int GetOrderNumber()
        {
            return orderNumber;
        }

        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DateTime DueDate { get; set; }
        public List<Shape> OrderedBlocks { get; set; }

        public string OrderDescription()
        {
            return $"\nName: {CustomerName}, Address: {Address}, Due Date: {DueDate}, Order #: {GetOrderNumber()}";
        }
    }
}
