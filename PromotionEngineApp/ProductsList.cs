/// <summary>This Prmotion Engine ProductList.cs class  is for learning purpose this code not supose to use in real application</summary>
namespace PromotionEngineApp
{
    /// <summary>Product List class</summary>
    public class ProductsList
    {
        /// <summary>Gets or sets the Pridcut Code.</summary>
        /// <value>The Pridcut Code.</value>
        public string ProductCode { get; set; }

        /// <summary>Gets or sets the Product Price.</summary>
        /// <value>The Product Price.</value>
        public decimal ProductPrice { get; set; }

        /// <summary>Initializes a new instance of the product list <a onclick="return false;" href="ProductsList" originaltag="see">ProductsList</a> class.</summary>
        /// <param name="productCode">The identifier.</param>
        public ProductsList(string productCode)
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
    }
}
