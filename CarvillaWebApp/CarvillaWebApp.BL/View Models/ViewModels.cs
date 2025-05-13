using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarvillaWebApp.DAL.Models;
using CarvillaWebApp.DAL.View_Models;

namespace CarvillaWebApp.BL.View_Models;

public class ViewModels
{
    public Car CarEntityModel { get; set; }
    public CarCreateVM CarCreateModel { get; set; }
}
