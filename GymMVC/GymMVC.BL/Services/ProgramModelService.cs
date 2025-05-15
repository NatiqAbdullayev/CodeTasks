using GymMVC.BL.ViewModels;
using GymMVC.DAL.Context;
using GymMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GymMVC.BL.Services;

public class ProgramModelService
{
    private readonly AppDbContext _context;
    public ProgramModelService(AppDbContext context)
    {
        _context = context;
    }


    private void Save() { _context.SaveChanges(); }

    public void Create(ProgramVM programModel)
    {
        //Mapping
        ProgramModel p = new ProgramModel();
        p.Title = programModel.Title;
        p.Description = programModel.Description;

        //File Rename
        string fileName = Path.GetFileNameWithoutExtension(programModel.File.FileName);
        string extension = Path.GetExtension(programModel.File.FileName);
        string finalName = fileName + Guid.NewGuid().ToString() + extension;
        p.ImageName = finalName;

        //File Save
        string path = "C:\\Users\\II Novbe\\source\\repos\\GymMVC\\GymMVC.MVC\\wwwroot\\UploadedImages";
        path = Path.Combine(path, finalName);

        using FileStream stream = new FileStream(path, FileMode.Create);

        programModel.File.CopyTo(stream);

        _context.Add(p);
        Save();
    }

    public void Delete(int id)
    {

        var entity = _context.Programs.Find(id);

        if (entity is null)
        {
            throw new Exception("Not found any entity with this id");
        }

        _context.Programs.Remove(entity);
        Save();
    }

    public void Update(int id, ProgramVM programModel)
    {

        var entity = _context.Programs.Find(id);

        if (entity is null)
        {
            throw new Exception("Not found any entity with this id");
        }

        entity.Title = programModel.Title;
        entity.Description = programModel.Description;

        //File Rename
        string fileName = Path.GetFileNameWithoutExtension(programModel.File.FileName);
        string extension = Path.GetExtension(programModel.File.FileName);
        string finalName = fileName + Guid.NewGuid().ToString() + extension;
        entity.ImageName = finalName;

        //File Save
        string path = "C:\\Users\\II Novbe\\source\\repos\\GymMVC\\GymMVC.MVC\\wwwroot\\UploadedImages";
        path = Path.Combine(path, finalName);

        using FileStream stream = new FileStream(path, FileMode.Create);

        programModel.File.CopyTo(stream);
        Save();

    }

    public ProgramVM ReMapp(ProgramModel model)
    {
        return new ProgramVM()
        {
            Title = model.Title,
            Description = model.Description
        };

    }

    public ProgramModel GetProgramById(int id) {

        var entity = _context.Programs.Find(id);

        if (entity is null)
        {
            throw new Exception("Not found any entity with this id");
        }
        return entity;
    }

    public List<ProgramModel> GetAllPrograms()
    {
        return _context.Programs.ToList();
    }

}
