using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CarvillaWebApp.DAL.View_Models;

public class CarCreateVM
{
    public string FullName { get; set; }

    public string Brand { get; set; }

    public string ModelYear { get; set; }

    public string EnginePower { get; set; }

    public string TransmissionType { get; set; }

    public string CarDescription { get; set; }

    public double Price { get; set; }

    public IFormFile ImageFile { get; set; }

}
