using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkitekten.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Kakel", Description="Finaste kaklet!"},
                new Category{CategoryId=2, CategoryName="Golv", Description="Bästa golvet!"},
                new Category{CategoryId=3, CategoryName="Tak", Description="Bästa taket!"},
                new Category{CategoryId=4, CategoryName="Vägg", Description="Bästa väggar!"},
                new Category{CategoryId=5, CategoryName="Projekt", Description="Lägg till ett nytt projekt."}
            };
    }
}
