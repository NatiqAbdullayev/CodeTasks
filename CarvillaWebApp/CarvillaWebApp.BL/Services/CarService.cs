using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarvillaWebApp.BL.Exceptions;
using CarvillaWebApp.DAL.Context;
using CarvillaWebApp.DAL.Models;
using CarvillaWebApp.DAL.View_Models;
using Microsoft.EntityFrameworkCore;

namespace CarvillaWebApp.BL.Services;

public class CarService : ICarService
{

    private readonly AppDbContext _context;

    public CarService()
    {
        _context = new AppDbContext();
    }


    public void Create(CarCreateVM carModel)
    {

        if (carModel is null)
        {
            throw new CarException("Car object cannot be null");
        }
        //Mapping
        Car car = new Car();
        car.Brand = carModel.Brand;
        car.ModelYear = carModel.ModelYear;
        car.Price = carModel.Price;
        car.CarDescription = carModel.CarDescription;
        car.EnginePower = carModel.EnginePower;
        car.TransmissionType = carModel.TransmissionType;
        car.FullName = carModel.FullName;
        car.isDeleted = false;
        //Image save proccess
        string fileName = Path.GetFileNameWithoutExtension(carModel.ImageFile.FileName);
        string extension = Path.GetExtension(carModel.ImageFile.FileName);
        string newName = fileName + "-" + Guid.NewGuid().ToString() + extension;

        car.ImageName = newName;

        string localPath = "C:\\Users\\stduser\\source\\repos\\CarvillaWebApp\\CarvillaWebApp.MVC\\wwwroot\\assets\\UploadedImages";

        localPath = Path.Combine(localPath, newName);

        using FileStream stream = new FileStream(localPath, FileMode.Create);

        carModel.ImageFile.CopyTo(stream);


        _context.Cars.Add(car);
        _context.SaveChanges();

    }

    public void Delete(int id)
    {
        Car? car = _context.Cars.Find(id);

        if (car is null)
        {
            throw new CarException("Car object cannot be null");
        }

        _context.Cars.Remove(car);
        _context.SaveChanges();

    }

    public List<Car> GetAllCars()
    {
        return _context.Cars.ToList();
    }

    public Car GetCarById(int id)
    {
        Car? car = _context.Cars.Find(id);

        if (car is null)
        {
            throw new CarException("Cannot find any enitity with this id");
        }

        return car;
    }

    public void Update(int id, Car car)
    {
        if (id != car.Id)
        {
            throw new CarException("The request ID does not match the entity ID");
        }
        Car? entity = _context.Cars.Find(id);

        if (entity is null)
        {
            throw new CarException("Cannot find any enitity with this id");
        }

        entity.FullName = car.FullName;
        entity.Brand = car.Brand;
        entity.ModelYear = car.ModelYear;
        entity.EnginePower = car.EnginePower;
        entity.TransmissionType = car.TransmissionType;
        entity.CarDescription = car.CarDescription;
        entity.Price = car.Price;
        entity.ImageName = car.ImageName;


        _context.SaveChanges();

    }
}
