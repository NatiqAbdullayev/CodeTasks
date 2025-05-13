using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarvillaWebApp.DAL.Models;
using CarvillaWebApp.DAL.View_Models;

namespace CarvillaWebApp.BL.Services;

public interface ICarService
{
    void Create(CarCreateVM carModel);
    void Update(int id,Car car);
    void Delete(int id);
    Car GetCarById(int id);
    List<Car> GetAllCars();
}
