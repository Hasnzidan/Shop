namespace Shop.Models
{
    public class ProductBL
    {
        List<Product> products;

        public ProductBL()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1 , Name = "Laptop", Description="empty",Price=20000, ImageURL= "Laptop.jpg" });
            products.Add(new Product() { Id = 2 , Name = "taplet", Description="empty",Price=11000, ImageURL= "Taplet.jpg" });
            products.Add(new Product() { Id = 3 , Name = "mouse", Description="empty",Price=200, ImageURL= "Mouse.jpg" });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProductsById(int id)
        {
            return products.FirstOrDefault(s => s.Id == id);
        }

    }
}
