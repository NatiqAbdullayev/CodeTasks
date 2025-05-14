using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMVC.BL.ViewModels;

public class CauseVM
{
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Goal { get; set; }
    public IFormFile File{ get; set; }
}
