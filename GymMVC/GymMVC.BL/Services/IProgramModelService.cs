using GymMVC.BL.ViewModels;
using GymMVC.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMVC.BL.Services;

public interface IProgramModelService
{
    void Create(ProgramVM programModel);

    void Delete(int id);
    void Update(int id, ProgramVM programModel);

    ProgramVM ReMapp(ProgramModel model);

    ProgramModel GetProgramById(int id);

    List<ProgramModel> GetAllPrograms();
}
