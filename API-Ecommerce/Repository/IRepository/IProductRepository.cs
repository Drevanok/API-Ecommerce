using System;
using API_Ecommerce.Model;

namespace API_Ecommerce.Repository.IRepository;

public interface IProductRepository
{
    ICollection<Product> GetProducts();
    ICollection<Product> GetProductsCategoryId(int categoryId);

    ICollection<Product> SearchProducts(string name);

    Product? GetProductId(int id);

    bool BuyProduct(string name, int quantity);

    bool ProductExists(int id);

    bool ProductExists(string name);

    bool CreateProduct(Product product);

    bool UpdateProduct(Product product);

    bool DeleteProduct(Product product);

    bool Save();
}
