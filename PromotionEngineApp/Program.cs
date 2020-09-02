/// <summary>This Prmotion Engine code is for learning purpose this code not supose to use in real application</summary>
namespace PromotionEngineApp
{
    using System;
    using System.Collections.Generic;

    /// <summary> Program is the main class from where code will execute</summa

   public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            List<ProductsList> products = new List<ProductsList>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                ProductsList productsList  = new ProductsList(type);
                products.Add(productsList);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        /// <summary>Gets the total price.</summary>
        /// <param name="products">The products.</param>
        /// <returns>The Price of product </returns>
        private static int GetTotalPrice(List<ProductsList> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int counterofC = 0;
            int priceofC = 20;
            int counterofD = 0;
            int priceofD = 15;
            try
            {
                foreach (ProductsList productsList in products)
                {
                    if (productsList.ProductCode == "A" || productsList.ProductCode == "a")
                    {
                        counterofA = counterofA + 1;
                    }

                    if (productsList.ProductCode == "B" || productsList.ProductCode == "b")
                    {
                        counterofB = counterofB + 1;
                    }

                    if (productsList.ProductCode == "C" || productsList.ProductCode == "c")
                    {
                        counterofC = counterofC + 1;
                    }

                    if (productsList.ProductCode == "D" || productsList.ProductCode == "d")
                    {
                        counterofD = counterofD + 1;
                    }
                }

                int totalProductPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
                int totalProductPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
                int totalProductPriceofC = (counterofC * priceofC);
                int totalProductPriceofD = (counterofD * priceofD);
                return totalProductPriceofA + totalProductPriceofB + totalProductPriceofC + totalProductPriceofD;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine("Total Price Display Below :");
            }
        }
    }
}
