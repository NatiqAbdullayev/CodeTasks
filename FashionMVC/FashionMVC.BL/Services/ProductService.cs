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
        string path = "C:\\Users\\stduser\\Desktop\\CodeTasks\\FashionMVC\\FashionMVC.MVC\\wwwroot\\assets\\UplodedImages";

        path = Path.Combine(path, resultName);

        using FileStream stream = new FileStream(path, FileMode.Create);

        productVM.ImageFile.CopyTo(stream);

        _context.Products.Add(p);
        _context.SaveChanges();

    }

    public void Delete(int id)
    {
        Product? entity = _context.Products.Find(id);
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
        Product? entity = _context.Products.Find(id);
        if (entity is null)
        {
            throw new ProductException("Product cannot be null");
        }

        return entity;
    }

    public void Update(int id, ProductCreateVM productModel)
    {
        Product? product = _context.Products.Find(id);
        if (product is null)
        {
            throw new ProductException("Product cannot be null");
        }

        product.Description = productModel.Description;
        product.Name = productModel.Name;
        product.Price = productModel.Price;

        //File
        string fileName = Path.GetFileNameWithoutExtension(productModel.ImageFile.FileName);
        string extension = Path.GetExtension(productModel.ImageFile.FileName);
        string resultName = fileName + "-" + Guid.NewGuid().ToString() + extension;
        product.ImageName = resultName;

        //Save
        string path = "C:\\Users\\stduser\\Desktop\\CodeTasks\\FashionMVC\\FashionMVC.MVC\\wwwroot\\assets\\UplodedImages";

        path = Path.Combine(path, resultName);

        using FileStream stream = new FileStream(path, FileMode.Create);

        productModel.ImageFile.CopyTo(stream);

        _context.SaveChanges();
    }

    public ProductCreateVM ReMapping(int id)
    {
        Product? product = _context.Products.Find(id);

        if (product is null)
        {
            throw new ProductException("Product cannot be null");
        }

        return new ProductCreateVM()
        {
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
        };

    }


}
