using System;
using System.Collections.Generic;

namespace Order.Management
{
    class Program
    {
        static void Main(string[] args)
        {
            var (customerName, address, dueDate) = GetCustomerInfoInput();

            List<Shape> orderedShapes = GetShapesOrder();

            GenerateInvoiceReport(customerName, address, dueDate, orderedShapes);

            GenerateCuttingListReport(customerName, address, dueDate, orderedShapes);

            GeneratePaintingReport(customerName, address, dueDate, orderedShapes);
        }

        private static (string customerName, string address, DateTime dueDate) GetCustomerInfoInput()
        {
            Console.Write("Please enter your Name: ");
            string customerName = Helpers.GetStringInput();
            
            Console.Write("Please enter your Address: ");
            string address = Helpers.GetStringInput();

            Console.Write("Please enter the expected Due Date: ");
            DateTime dueDate = Helpers.GetDateInput();

            return (customerName, address, dueDate);
        }

        private static List<Shape> GetShapesOrder()
        {
            var orderedShapes = new List<Shape>();

            foreach (var shape in Constants.ShapeType)
            {
                Console.Write($"\nPlease enter the number of Red {shape}: ");
                int redShapes = Helpers.GetNumberInput();
                Console.Write($"Please enter the number of Blue {shape}: ");
                int blueShapes = Helpers.GetNumberInput();
                Console.Write($"Please enter the number of Yellow {shape}: ");
                int yellowShapes = Helpers.GetNumberInput();

                switch (shape)
                {
                    case "Squares":
                        Square square = new Square(redShapes, blueShapes, yellowShapes);
                        orderedShapes.Add(square);
                        break;

                    case "Triangles":
                        Triangle triangle = new Triangle(redShapes, blueShapes, yellowShapes);
                        orderedShapes.Add(triangle);
                        break;

                    case "Circles":
                        Circle circle = new Circle(redShapes, blueShapes, yellowShapes);
                        orderedShapes.Add(circle);
                        break;

                    default: throw new Exception ("Invalid shape type");
                }
            }

            return orderedShapes;
        }

        private static void GeneratePaintingReport(string customerName, string address, DateTime dueDate, List<Shape> orderedShapes)
        {
            PaintingReport paintingReport = new PaintingReport(customerName, address, dueDate, orderedShapes);
            paintingReport.GenerateReport();
        }

        private static void GenerateCuttingListReport(string customerName, string address, DateTime dueDate, List<Shape> orderedShapes)
        {
            CuttingListReport cuttingListReport = new CuttingListReport(customerName, address, dueDate, orderedShapes);
            cuttingListReport.GenerateReport();
        }

        private static void GenerateInvoiceReport(string customerName, string address, DateTime dueDate, List<Shape> orderedShapes)
        {
            InvoiceReport invoiceReport = new InvoiceReport(customerName, address, dueDate, orderedShapes);
            invoiceReport.GenerateReport();
        }
    }
}
