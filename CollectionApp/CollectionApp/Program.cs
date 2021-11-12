using CollectionApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("KidsToys", 500, 3));
            basket.Add("Hello AurionPro...");
            foreach(object item in basket)
            {
                Console.WriteLine(item.g);
                Console.WriteLine(item.GetPrice); 
                Console.WriteLine(item.GetQuantity);
            }
        }
        public static void CaseStudy()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("KidsToys", 500, 3));
            basket.Add(new LineItem("pen", 15, 2));
            basket.Add(new LineItem("bag", 500, 1));
            double totalCost = 0;
            foreach (LineItem item in basket)
            {
                Console.WriteLine("Items:{0}\t\tPriceName:{0}\t\tPrice:{0}\t\tQuantity:{0}", item.GetProductName(), item.GetPrice(), item.
                    ());
                totalCost += item.TotalPrice();
            }
            Console.WriteLine("\n Total Cost:", totalCost);
        }

        
    }
}
