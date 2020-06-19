using System.Collections.Generic;
using System.Linq;

namespace Bageriet.Models
{
    public class MockProductRepository : IProductRepository
    {
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {Name="Bagarens favorit"},
                new Product {Name="Surdegsbröd"},
                new Product {Name="Äppelkaka"},
                new Product {Name="sockerkaka"}
            };
    }
}
