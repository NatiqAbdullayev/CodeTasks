﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMVC.BL.ViewModels;

public class ProgramVM
{
    public string Title { get; set; }
    public string Description { get; set; }
    public IFormFile File { get; set; }
}
