using System;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"G:\BRIDGELABZ\StockAccountManagement\StockManagement\StocksFile.json";

            Console.WriteLine(" Welcome to Stock account Management system \n");
            StockMain sm = new StockMain();
            sm.ReadJsonFile(filePath);
        }
    }
}
