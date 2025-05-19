using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaMVC.BL.Exceptions;
using VillaMVC.BL.Services.Abstract;
using VillaMVC.BL.ViewModels;
using VillaMVC.DAL.Context;
using VillaMVC.DAL.Models;

namespace VillaMVC.BL.Services.Concrete;

public class VillaService : IVillaService
{

    private readonly AppDbContext _context;

    public VillaService(AppDbContext context)
    {
        _context = context;
    }

    private void Save() { _context.SaveChanges(); }

    public void Create(VillaVM model)
    {

        //File rename
        string fileName = Path.GetFileNameWithoutExtension(model.File.FileName);
        string extension = Path.GetExtension(model.File.FileName);
        string newName = fileName + Guid.NewGuid().ToString() + extension;

        //File save
        string path = "C:\\Users\\II Novbe\\source\\repos\\VillaMVC\\VillaMVC.PL\\wwwroot\\uploadedImages";

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        path = Path.Combine(path, newName);

        using FileStream stream = new FileStream(path, FileMode.Create);
        model.File.CopyTo(stream);

        //Mapping
        Villa villa = new()
        {
            Name = model.Name,
            Price = model.Price,
            BedroomCount = model.BedroomCount,
            BathroomCount = model.BathroomCount,
            AreaSize = model.AreaSize,
            Floor = model.Floor,
            Parking = model.Parking,
            AdressInfo = model.AdressInfo,
            ImageName = newName
        };

        _context.Villas.Add(villa);
        Save();
    }

    public void Delete(int id)
    {
        var entity = GetVillaById(id);

        _context.Villas.Remove(entity);
        Save();
    }

    public List<Villa> GetAllVillas()
    {
        return _context.Villas.ToList();
    }

    public Villa GetVillaById(int id)
    {
        var entity = _context.Villas.Find(id);
        if (entity is null)
        {
            throw new VillaException("Villa fileds cannot be null");
        }
        return entity;
    }

    public VillaVM ReMap(Villa model)
    {
        return new VillaVM()
        {
            Name = model.Name,
            Price = model.Price,
            BedroomCount = model.BedroomCount,
            BathroomCount = model.BathroomCount,
            AreaSize = model.AreaSize,
            Floor = model.Floor,
            Parking = model.Parking,
            AdressInfo = model.AdressInfo,
        };
    }

    public void Update(int id, VillaVM model)
    {
        var entity = GetVillaById(id);

        if (model is null)
        {
            throw new VillaException("Villa fileds cannot be null");
        }

        if (model.File is not null)
        {
            //File rename
            string fileName = Path.GetFileNameWithoutExtension(model.File.FileName);
            string extension = Path.GetExtension(model.File.FileName);
            string newName = fileName + Guid.NewGuid().ToString() + extension;

            //File save
            string path = "C:\\Users\\II Novbe\\source\\repos\\VillaMVC\\VillaMVC.PL\\wwwroot\\uploadedImages";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = Path.Combine(path, newName);

            using FileStream stream = new FileStream(path, FileMode.Create);
            model.File.CopyTo(stream);
            entity.ImageName = newName;
        }

        //Update
        entity.Name = model.Name;
        entity.Price = model.Price;
        entity.BedroomCount = model.BedroomCount;
        entity.BathroomCount = model.BathroomCount;
        entity.AreaSize = model.AreaSize;
        entity.Floor = model.Floor;
        entity.Parking = model.Parking;
        entity.AdressInfo = model.AdressInfo;

        Save();
    }
}
