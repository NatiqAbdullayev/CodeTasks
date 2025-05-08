using WebAppTask.Context;
using WebAppTask.Models;

namespace WebAppTask.Services;

public class ProductService : IProductSerivce
{
    private readonly AppDbContext _context;

    public ProductService()
    {
        _context = new AppDbContext();
    }

    public void Add(Product p)
    {
        _context.Products.Add(p);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        Product? product = _context.Products.Find(id);

        if (product is null)
        {
            throw new Exception("This entity is not founf");
        }

        _context.Products.Remove(product);
        _context.SaveChanges();

    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public Product GetProductById(int id)
    {
        Product? p = _context.Products.Find(id);

        if (p is null) { throw new Exception("This entity is not found"); }

        return p;
    }

    public void Update(int id, Product p)
    {
        Product? product = _context.Products.Find(id);

        if (product is null)
        {
            throw new Exception("This entity is not founf");
        }

        product.Title = p.Title;
        product.Description = p.Description;
        product.Price = p.Price;
        _context.SaveChanges();
    }

}
