using System.Collections.Generic;

namespace Bageriet.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
    }
}
