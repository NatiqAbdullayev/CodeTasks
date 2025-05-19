using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaMVC.BL.ViewModels;
using VillaMVC.DAL.Models;

namespace VillaMVC.BL.Services.Abstract;

public interface IVillaService
{
    Villa GetVillaById(int id);
    List<Villa> GetAllVillas();
    void Create(VillaVM model);
    void Update(int id,VillaVM model);
    void Delete(int id);
    VillaVM ReMap(Villa model);
}
