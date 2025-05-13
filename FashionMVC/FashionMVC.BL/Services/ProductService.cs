using FashionMVC.BL.Exceptions;
using FashionMVC.BL.ViewModels;
using FashionMVC.DAL.Context;
using FashionMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMVC.BL.Services;

public class ProductService : IProductService
{
    private readonly AppDbContext _context;
    public ProductService()
    {
        _context = new AppDbContext();
    }
    public void Create(ProductCreateVM productVM)
    {
        if (productVM is null)
        {
            throw new ProductException("Product cannot be null");
        }
        //Mapping
        Product p = new Product();
        p.Price = productVM.Price;
        p.Description = productVM.Description;
        p.Name = productVM.Name;

        //File
        string fileName = Path.GetFileNameWithoutExtension(productVM.ImageFile.FileName);
        string extension = Path.GetExtension(productVM.ImageFile.FileName);
        string resultName = fileName + "-" + Guid.NewGuid().ToString() + extension;
        p.ImageName = resultName;

        //Save
        string path = "C:\\Users\\II Novbe\\Desktop\\CodeTasks\\FashionMVC\\FashionMVC.MVC\\wwwroot\\assets\\UplodedImages";

        path = Path.Combine(path,resultName);

        using FileStream stream = new FileStream(path,FileMode.Create);

        productVM.ImageFile.CopyTo(stream);

        _context.Products.Add(p);
        _context.SaveChanges();

    }

    public void Delete(int id)
    {
        var entity = _context.Products.Find(id);
        if (entity is null)
        {
            throw new ProductException("Product cannot be null");
        }

        _context.Products.Remove(entity);
        _context.SaveChanges();

    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public Product GetProductById(int id)
    {
        var entity = _context.Products.Find(id);
        if (entity is null)
        {
            throw new ProductException("Product cannot be null");
        }

        return entity;
    }

    public void Update(int id, Product product)
    {
        throw new NotImplementedException();
    }
}
