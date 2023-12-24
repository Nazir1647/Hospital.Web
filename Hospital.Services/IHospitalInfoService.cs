using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public interface IHospitalInfoService
    {
        PagedResult<HospitalInfoViewModel> GetAll(int pageNo, int pageSize);
        HospitalInfoViewModel GetHospitalById(int id);
        void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo);
        void DeleteHospitalInfo(int id);
    }
}
