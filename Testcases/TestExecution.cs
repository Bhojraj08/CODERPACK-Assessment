using System;
using System.Collections.Generic;

namespace PromotionEngineApp.Testcases
{
    class TestExecution
    {
        /// <summary>Gets or sets the Pridcut Code.</summary>
        /// <value>The Pridcut Code.</value>
        public string ProductCode { get; set; }

        /// <summary>Gets or sets the Product Price.</summary>
        /// <value>The Product Price.</value>
        public decimal ProductPrice { get; set; }

        public TestExecution(string productCode)
        {
            this.ProductCode = productCode;
            switch (productCode)
            {
                case "A":
                    this.ProductPrice = 50m;

                    break;
                case "B":
                    this.ProductPrice = 30m;

                    break;
                case "C":
                    this.ProductPrice = 20m;

                    break;
                case "D":
                    this.ProductPrice = 2015m;
                    break;
            }
        }

        public static int GetTotalPriceTest(List<ProductsList> products)
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
            catch (Exception ex)
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
