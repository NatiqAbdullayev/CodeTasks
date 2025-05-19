using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillaMVC.DAL.Models;

public class Villa
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int BedroomCount { get; set; }
    public int BathroomCount { get; set; }
    public double AreaSize { get; set; }
    public int Floor { get; set; }
    public int Parking { get; set; }
    public string AdressInfo { get; set; }
    public string ImageName { get; set; }

}
