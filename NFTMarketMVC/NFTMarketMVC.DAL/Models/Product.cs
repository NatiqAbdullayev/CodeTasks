using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketMVC.DAL.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public string ImageName { get; set; }
    public double MaxItemCount { get; set; }
    public double MinItemCount { get; set; }

}
