using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}