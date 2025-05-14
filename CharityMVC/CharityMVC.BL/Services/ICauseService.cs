using CharityMVC.BL.ViewModels;
using CharityMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMVC.BL.Services;

public interface ICauseService
{
    void Add(CauseVM causeModel);
    void Delete(int id);
    void Update(int id,CauseVM causeModel);
    Cause GetCauseById(int id);
    List<Cause> GetAllCauses();
    public CauseVM ReMapping(Cause model);
}
