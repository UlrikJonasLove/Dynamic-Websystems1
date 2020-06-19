using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkitekten.Models //Mock classen är bara ett test för att testa sidan.
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {   //Kakel
                new Product{ProductId=1, Name="Vitt Kakel", Description="Det vitaste kaklet i Sverige!", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://tilesrus.se/wp-content/uploads/2017/08/kakel-metro-vit-matt-75x150-3.jpg", Price=600, ImageThumbnailUrl="https://tilesrus.se/wp-content/uploads/2017/08/kakel-metro-vit-matt-75x150-3.jpg"},
                new Product{ProductId=2, Name="Svart Kakel", Description="Det mörkaste kaklet i Sverige!", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://media.tidlostkakel.se/2016/11/Biselado-Svart-Milj%C3%B6-002.jpg", Price=600, ImageThumbnailUrl="https://media.tidlostkakel.se/2016/11/Biselado-Svart-Milj%C3%B6-002.jpg"},
                new Product{ProductId=3, Name="Grönt kakel", Description="Det grönaste kaklet i Sverige!", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://www.kakelspecialisten.se/upload/inspiration/blogg/kakel-och-badbloggen/groent-kakel-i-badrummet/valencia_image-w644.jpg", Price=600, ImageThumbnailUrl="https://www.kakelspecialisten.se/upload/inspiration/blogg/kakel-och-badbloggen/groent-kakel-i-badrummet/valencia_image-w644.jpg"},
                //Golv
                new Product{ProductId=4, Name="Mörkt Trä Golv", Description="Superfint trägolv!", Category = _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://i.pinimg.com/originals/fd/d0/3e/fdd03e3baad9f6caf773aaf1602439c9.jpg", Price=1000, ImageThumbnailUrl="https://i.pinimg.com/originals/fd/d0/3e/fdd03e3baad9f6caf773aaf1602439c9.jpg"},
                new Product{ProductId=5, Name="Ljust Trä Golv", Description="Superljust trägolv!", Category= _categoryRepository.AllCategories.ToList()[1], ImageUrl="https://www.barlinek.se/wp-content/uploads/2019/02/tragolv-ljust.jpg", Price=1000, ImageThumbnailUrl="https://www.barlinek.se/wp-content/uploads/2019/02/tragolv-ljust.jpg"},
                new Product{ProductId=6, Name="Plast Golv", Description="Billigt, men bra!", Category =_categoryRepository.AllCategories.ToList()[1], ImageUrl="https://bhgst.imgix.net/pimages/vatrumsmatta-tarkett-aquarelle-designgolv-istanbul-medium-grey__943d89bb-23c9-43a9-b523-af023f194186.jpg?auto=format,compress&w=200&h=200&dpr=2", Price=400, ImageThumbnailUrl="https://bhgst.imgix.net/pimages/vatrumsmatta-tarkett-aquarelle-designgolv-istanbul-medium-grey__943d89bb-23c9-43a9-b523-af023f194186.jpg?auto=format,compress&w=200&h=200&dpr=2"},
                //Tak
                new Product{ProductId=7, Name="Mörkt Trä Tak", Description="Superfint trä tak!", Category =_categoryRepository.AllCategories.ToList()[2], ImageUrl="https://files.elledecoration.se/uploads/sites/30/2015/11/150130_Kinfolk_BH_026-copy.jpg", Price=1000, ImageThumbnailUrl="https://files.elledecoration.se/uploads/sites/30/2015/11/150130_Kinfolk_BH_026-copy.jpg"},
                new Product{ProductId=8, Name="Ljust Trä Tak", Description="Superljust trä tak!", Category = _categoryRepository.AllCategories.ToList()[2], ImageUrl="https://thumbs.dreamstime.com/b/roterande-takfan-med-ljus-p%C3%A5-lantligt-tr%C3%A4tak-f%C3%B6r-fem-blad-som-installeras-tr%C3%A4plankatak-153334523.jpg", Price=1000, ImageThumbnailUrl="https://thumbs.dreamstime.com/b/roterande-takfan-med-ljus-p%C3%A5-lantligt-tr%C3%A4tak-f%C3%B6r-fem-blad-som-installeras-tr%C3%A4plankatak-153334523.jpg"},
                new Product{ProductId=9, Name="Plast tak", Description="Billigt, men bra!", Category =_categoryRepository.AllCategories.ToList()[2], ImageUrl="https://www.teddytassen.se/webbshop/kanin/kaninburarhus/plasttak-till-kaninburar/large/plasttak-till-kaninburar-3966.jpg", Price=400, ImageThumbnailUrl="https://www.teddytassen.se/webbshop/kanin/kaninburarhus/plasttak-till-kaninburar/large/plasttak-till-kaninburar-3966.jpg"},
                //Vägg
                new Product{ProductId=10, Name="Mörk Trä vägg", Description="Superfin trä vägg!", Category =_categoryRepository.AllCategories.ToList()[3], ImageUrl="http://cdn3.cdnme.se/cdn/6-1/2514707/images/2013/sfdf074cb2e8e97476eba5991e07c4ad1f5_800x800_50fe64eaddf2b31177766712.jpg", Price=1000, ImageThumbnailUrl="http://cdn3.cdnme.se/cdn/6-1/2514707/images/2013/sfdf074cb2e8e97476eba5991e07c4ad1f5_800x800_50fe64eaddf2b31177766712.jpg"},
                new Product{ProductId=11, Name="Ljus Trä vägg", Description="Superljus trä vägg!", Category = _categoryRepository.AllCategories.ToList()[3], ImageUrl="https://cdn2.cdnme.se/4271838/8-3/tratapet_ljus_travagg_traplankor_fondvagg_589cd2b6e087c3456ba1f34b.jpg", Price=1000, ImageThumbnailUrl="https://cdn2.cdnme.se/4271838/8-3/tratapet_ljus_travagg_traplankor_fondvagg_589cd2b6e087c3456ba1f34b.jpg"},
                new Product{ProductId=12, Name="Plast vägg", Description="Billigt, men bra!", Category =_categoryRepository.AllCategories.ToList()[3], ImageUrl="https://img.bygghemma.se/pimages/vatrumsvav-fg-135-typ-1x25m__3b5e8b97-c471-46b9-8075-9015f2782ea9.jpg?auto=format,compress&w=634&h=634&dpr=1", Price=400, ImageThumbnailUrl="https://img.bygghemma.se/pimages/vatrumsvav-fg-135-typ-1x25m__3b5e8b97-c471-46b9-8075-9015f2782ea9.jpg?auto=format,compress&w=634&h=634&dpr=1"},
                //Projekt
                new Product{ProductId=13, Name="Liten stuga", Description="Passar bra för sommarstugor!", Category = _categoryRepository.AllCategories.ToList()[4], ImageUrl="https://lyx.se/z/wp-content/uploads/2012/11/ks_60jpg.jpg", Price=500000, ImageThumbnailUrl="https://lyx.se/z/wp-content/uploads/2012/11/ks_60jpg.jpg"},
                new Product{ProductId=14, Name="Stor stuga", Description="Passar bra för året runt!", Category = _categoryRepository.AllCategories.ToList()[4], ImageUrl="https://www.bengt-martins.se/storage/ma/26ecf8a0953f4561801e99cdeae503f5/5d23a00994e44d379047ca0ff903244b/jpg/C524CF6C5FE5A83942E0AF1C165CCB3B04A9F454/Salen-Tand-fjallvilla41_31759_780_400.jpg", Price=1000000, ImageThumbnailUrl="https://www.bengt-martins.se/storage/ma/26ecf8a0953f4561801e99cdeae503f5/5d23a00994e44d379047ca0ff903244b/jpg/C524CF6C5FE5A83942E0AF1C165CCB3B04A9F454/Salen-Tand-fjallvilla41_31759_780_400.jpg"},
                new Product{ProductId=15, Name="Stort hus", Description="Perfekt för familjen!", Category = _categoryRepository.AllCategories.ToList()[4], ImageUrl="https://images7.alphacoders.com/341/341714.jpg", Price=2500000, ImageThumbnailUrl="https://images7.alphacoders.com/341/341714.jpg"}
            };
        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
