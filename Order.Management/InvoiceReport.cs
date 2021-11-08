using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class InvoiceReport : ReportHelper
    {
        public InvoiceReport(string customerName, string customerAddress, DateTime dueDate, List<Shape> shapes)
        {
            CustomerName = customerName;
            Address = customerAddress;
            DueDate = dueDate;
            OrderedBlocks = shapes;
            tableWidth = Constants.InvoiceReportTableWidth;
        }

        public override void GenerateReport()
        {
            Console.WriteLine($"\nYour invoice report has been generated: \n{OrderDescription()}");
            GenerateTable();
            PrintOrderDetails();
            RedPaintSurcharge();
        }

        public void RedPaintSurcharge()
        {
            Console.WriteLine($"Red Color Surcharge {TotalAmountOfRedShapes()} @ ${OrderedBlocks[0].AdditionalCharge} ppi = ${TotalPriceRedPaintSurcharge()}");
        }

        int TotalAmountOfRedShapes()
        {
            int quantity = 0;

            foreach (var shape in OrderedBlocks)
                quantity += shape.NumberOfRedShapes;

            return quantity;
        }

        int TotalPriceRedPaintSurcharge()
        {
            return TotalAmountOfRedShapes() * OrderedBlocks[0].AdditionalCharge;
        }

        void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();

            foreach (var shape in OrderedBlocks)
                PrintRow(shape.Name, shape.NumberOfRedShapes.ToString(), shape.NumberOfBlueShapes.ToString(), shape.NumberOfYellowShapes.ToString());

            PrintLine();
        }

        void PrintOrderDetails()
        {
            foreach (var shape in OrderedBlocks)
                Console.WriteLine($"{shape.Name}s {shape.TotalQuantityOfShape()} @ ${shape.UnitPrice} ppi = ${shape.TotalPrice()}");
        }
    }
}
