using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace StockManagement
{
    class StockMain
    {
        public void ReadJsonFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);

                    StockModel jsonObjectarray = JsonConvert.DeserializeObject<StockModel>(jsonData);

                    Console.WriteLine(" - - - Stocks Report - - - ");
                    Console.WriteLine(" Company_Name  Number_of_shares Shares_price  Total_price");

                    List<StockClass> stock = jsonObjectarray.StocksList;
                    foreach (var item in stock)
                    {
                        Console.WriteLine(" {0}\t\t {1}\t\t {2}\t\t {3}", item.CompanyName, item.NumberOfShare, item.SharePrice, StockTotal(item.NumberOfShare,item.SharePrice));
                    }
                    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    return;
                
                    int StockTotal(int numbers, int price)
                    {
                        int total = numbers * price;
                        return total;
                    }
                
                }
                
                else
                {
                    Console.WriteLine(" \n Specified filepath does not exist.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
