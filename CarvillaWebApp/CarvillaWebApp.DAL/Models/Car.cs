using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvillaWebApp.DAL.Models;

public class Car
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public string Brand { get; set; }

    public string ModelYear { get; set; }

    public string EnginePower { get; set; }

    public string TransmissionType { get; set; }

    public string CarDescription { get; set; }

    public double Price { get; set; }

    public string ImageName { get; set; }

    public bool isDeleted { get; set; }

}
