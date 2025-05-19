using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillaMVC.BL.ViewModels;

public class VillaVM
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int BedroomCount { get; set; }
    public int BathroomCount { get; set; }
    public double AreaSize { get; set; }
    public int Floor { get; set; }
    public int Parking { get; set; }
    public string AdressInfo { get; set; }
    public IFormFile File { get; set; }
}
