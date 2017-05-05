using XamarinUniversity.Infrastructure;
using System.Collections.ObjectModel;

namespace Portfolio.Catalog
{
    public class CatalogViewModel : SimpleViewModel
    {
        public ObservableCollection<ProductModel> Products { get; set; }

        public CatalogViewModel()
        {
			Products = new ObservableCollection<ProductModel>();
			Products.Add(new ProductModel() { Name = "Product 1", BackgroundImage = "bg1.jpg"});
			Products.Add(new ProductModel() { Name = "Product 2", BackgroundImage = "bg2.jpg"});
			Products.Add(new ProductModel() { Name = "Product 3", BackgroundImage = "bg3.jpg"});
			Products.Add(new ProductModel() { Name = "Product 4", BackgroundImage = "bg4.jpg"});
			Products.Add(new ProductModel() { Name = "Product 5", BackgroundImage = "bg5.png"});
			Products.Add(new ProductModel() { Name = "Product 6", BackgroundImage = "bg6.jpg"});
			Products.Add(new ProductModel() { Name = "Product 7", BackgroundImage = "bg7.jpg"});
			Products.Add(new ProductModel() { Name = "Product 8", BackgroundImage = "bg8.jpg"});
			Products.Add(new ProductModel() { Name = "Product 9", BackgroundImage = "bg9.jpg"});
        }
    }
}
