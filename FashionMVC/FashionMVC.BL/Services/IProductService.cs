using FashionMVC.BL.ViewModels;
using FashionMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMVC.BL.Services;

public interface IProductService
{
    void Create(ProductCreateVM productVM);
    void Delete(int id);
    void Update(int id,Product product);
    Product GetProductById(int id);
    List<Product> GetAllProducts();
}
