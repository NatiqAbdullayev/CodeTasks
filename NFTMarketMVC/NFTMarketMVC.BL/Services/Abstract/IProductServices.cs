using NFTMarketMVC.BL.ViewModels;
using NFTMarketMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketMVC.BL.Services.Abstract;

public interface IProductServices
{
    void Create(ProductVM productVM);
    void Delete(int id);
    void Update(int id,ProductVM productVM);
    Product GetProductById(int id);
    List<Product> GetAllProducts();
    ProductVM GetProductVM(Product product);
}
