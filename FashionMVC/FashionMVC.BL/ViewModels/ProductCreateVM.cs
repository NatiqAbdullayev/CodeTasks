using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMVC.BL.ViewModels;

public class ProductCreateVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public IFormFile ImageFile{ get; set; }
}
