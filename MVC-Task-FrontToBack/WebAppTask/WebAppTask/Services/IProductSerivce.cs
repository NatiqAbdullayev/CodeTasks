using WebAppTask.Models;

namespace WebAppTask.Services;

public interface IProductSerivce
{
    void Add(Product p);
    void Update(int id,Product p);
    Product GetProductById(int id);
    List<Product> GetAllProducts();
    void Delete(int id);
}
