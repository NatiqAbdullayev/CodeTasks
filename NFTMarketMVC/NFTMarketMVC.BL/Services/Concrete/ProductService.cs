using NFTMarketMVC.BL.Exceptions;
using NFTMarketMVC.BL.Services.Abstract;
using NFTMarketMVC.BL.ViewModels;
using NFTMarketMVC.DAL.Context;
using NFTMarketMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketMVC.BL.Services.Concrete;

public class ProductService : IProductServices
{
    private readonly AppDbContext _context;

    public ProductService(AppDbContext context)
    {
        _context = context;
    }

    private void Save() { _context.SaveChanges(); }

    public void Create(ProductVM productVM)
    {
        if (productVM is null)
        {
            throw new ProductException("Creation object cannot be null");
        }

        //Mapping
        Product p = new Product()
        {
            Title = productVM.Title,
            Category = productVM.Category,
            MaxItemCount = productVM.MaxItemCount,
            MinItemCount = productVM.MinItemCount
        };
        //Image rename
        string fileName = Path.GetFileNameWithoutExtension(productVM.File.FileName);
        string extension = Path.GetExtension(productVM.File.FileName);
        string newName = fileName + Guid.NewGuid().ToString() + extension;
        p.ImageName = newName;

        //File Save
        string path = @"C:\\Users\\II Novbe\\source\\repos\\NFTMarketMVC\\NFTMarketMVC.PL\\wwwroot\\UploadedImages";
        path = Path.Combine(path, newName);

        

        using FileStream stream = new FileStream(path, FileMode.Create);
        productVM.File.CopyTo(stream);

        _context.Products.Add(p);
        Save();
    }

    public void Delete(int id)
    {
        var entity = _context.Products.Find(id);

        if (entity is null)
        {
            throw new ProductException("Creation object cannot be null");
        }

        _context.Products.Remove(entity);
        Save();

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
            throw new ProductException("Creation object cannot be null");
        }

        return entity;
    }

    public ProductVM GetProductVM(Product product)
    {
        return new ProductVM()
        {
            Title = product.Title,
            Category = product.Category,
            MaxItemCount = product.MaxItemCount,
            MinItemCount = product.MinItemCount
        };
    }

    public void Update(int id, ProductVM productVM)
    {
        var entity = _context.Products.Find(id);

        if (entity is null)
        {
            throw new ProductException("Creation object cannot be null");
        }

        //Update fields
        entity.Title = productVM.Title;
        entity.Category = productVM.Category;
        entity.MinItemCount = productVM.MinItemCount;
        entity.MaxItemCount = productVM.MaxItemCount;

        if (productVM.File is not null)
        {
            //Image rename
            string fileName = Path.GetFileNameWithoutExtension(productVM.File.FileName);
            string extension = Path.GetExtension(productVM.File.FileName);
            string newName = fileName + Guid.NewGuid().ToString() + extension;
            entity.ImageName = newName;

            //File Save
            string path = "C:\\Users\\II Novbe\\source\\repos\\NFTMarketMVC\\NFTMarketMVC.PL\\wwwroot\\UploadedImages";
            path = Path.Combine(path, newName);


            using FileStream stream = new FileStream(path, FileMode.Create);
            productVM.File.CopyTo(stream);
        }

     

        Save();

    }
}
