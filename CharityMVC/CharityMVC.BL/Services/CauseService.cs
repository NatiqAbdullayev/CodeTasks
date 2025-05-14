using CharityMVC.BL.Exceptions;
using CharityMVC.BL.ViewModels;
using CharityMVC.DAL.Context;
using CharityMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMVC.BL.Services;

public class CauseService : ICauseService
{

    private readonly AppDbContext _context;
    public CauseService()
    {
        _context = new AppDbContext();
    }


    public void Add(CauseVM causeModel)
    {
        if (causeModel is null)
        {
            throw new CauseException("Entity cannot be null before creating");
        }

        //Mapping
        Cause c = new Cause();
        c.Title = causeModel.Title;
        c.Description = causeModel.Description;
        c.Price = causeModel.Price;
        c.Goal = causeModel.Goal;

        //File Rename
        string fileName = Path.GetFileNameWithoutExtension(causeModel.File.FileName);
        string extension = Path.GetExtension(causeModel.File.FileName);
        string finalName = fileName + Guid.NewGuid().ToString() + extension;
        c.ImageName = finalName;

        //File Save
        string path = "C:\\Users\\II Novbe\\source\\repos\\CharityMVC\\CharityMVC.MVC\\wwwroot\\assets\\UploadedImages";
        path = Path.Combine(path, finalName);

        using FileStream stream = new FileStream(path, FileMode.Create);
        causeModel.File.CopyTo(stream);

        _context.Causes.Add(c);
        _context.SaveChanges();

    }

    public void Delete(int id)
    {
        
        Cause? entity = _context.Causes.Find(id);

        if (entity is null)
        {
            throw new CauseException("Cannot find any entity with this id");
        }
        Console.WriteLine(entity.Id);
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<Cause> GetAllCauses()
    {
        return _context.Causes.ToList();
    }

    public Cause GetCauseById(int id)
    {
        Cause? entity = _context.Causes.Find(id);

        if (entity is null)
        {
            throw new CauseException("Cannot find any entity with this id");
        }

        return entity;
    }

    public void Update(int id,CauseVM causeModel)
    {
        Cause? entity = _context.Causes.Find(id);
        if (entity is null)
        {
            throw new CauseException("Cannot find any entity with this id");
        }
        entity.Title = causeModel.Title;
        entity.Description = causeModel.Description;
        entity.Price = causeModel.Price;
        entity.Goal = causeModel.Goal;
        if (causeModel.File is not null)
        {
            //File Rename
            string fileName = Path.GetFileNameWithoutExtension(causeModel.File.FileName);
            string extension = Path.GetExtension(causeModel.File.FileName);
            string finalName = fileName + Guid.NewGuid().ToString() + extension;
            entity.ImageName = finalName;

            //File Save
            string path = "C:\\Users\\II Novbe\\source\\repos\\CharityMVC\\CharityMVC.MVC\\wwwroot\\assets\\UploadedImages";
            path = Path.Combine(path, finalName);

            using FileStream stream = new FileStream(path, FileMode.Create);
            causeModel.File.CopyTo(stream);
        }
        

        _context.SaveChanges();
    }

    public CauseVM ReMapping(Cause model)
    {
        return new CauseVM()
        {
            Title = model.Title,
            Description = model.Description,
            Price = model.Price,
            Goal = model.Goal
        };
    }
}
