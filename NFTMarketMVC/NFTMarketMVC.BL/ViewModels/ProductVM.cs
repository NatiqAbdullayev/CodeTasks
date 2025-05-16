using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketMVC.BL.ViewModels;

public class ProductVM
{
    public string Title { get; set; }
    public string Category { get; set; }
    public IFormFile File { get; set; }
    public double MaxItemCount { get; set; }
    public double MinItemCount { get; set; }
}
