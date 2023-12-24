using Hospital.Models;
using Hospital.Repositories.Interfaces;
using Hospital.Utilities;
using Hospital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Services
{
    public class HospitalInfoService : IHospitalInfoService
    {
        private IUnitOfWork _unitOfWork;
        public HospitalInfoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void DeleteHospitalInfo(int id)
        {
            var model = _unitOfWork.GenericRepository<HospitalInfo>().GetById(id);
            _unitOfWork.GenericRepository<HospitalInfo>().Delete(model);
            _unitOfWork.Save();
        }
        public PagedResult<HospitalInfoViewModel> GetAll(int pageNo, int pageSize)
        {
            var vm = new HospitalInfoViewModel();
            int totalCount;
            List<HospitalInfoViewModel> vmList = new List<HospitalInfoViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNo) - pageSize;
                var modelList = _unitOfWork.GenericRepository<HospitalInfo>().GetAll().
                    Skip(ExcludeRecords).Take(pageSize).ToList();
                totalCount = _unitOfWork.GenericRepository<HospitalInfo>().GetAll().ToList().Count;
                vmList = ConvertModelToViewModelList(modelList);
            }
            catch (Exception)
            {

                throw;
            }
            var result = new PagedResult<HospitalInfoViewModel>
            {
                Data = vmList,
                TotalItems = vmList.Count,
                PageNo = pageNo,
                PageSize = pageSize
            };
            return result;

        }
        public HospitalInfoViewModel GetHospitalById(int id)
        {
            var model = _unitOfWork.GenericRepository<HospitalInfo>().GetById(id);
            var vm = new HospitalInfoViewModel(model);
            return vm;
        }
        public void InsertHospitalInfo(HospitalInfoViewModel hospitalInfo)
        {
            var model = new HospitalInfoViewModel().ConvertViewModel(hospitalInfo);
            _unitOfWork.GenericRepository<HospitalInfo>().Add(model);
            _unitOfWork.Save();
        }
        public void UpdateHospitalInfo(HospitalInfoViewModel hospitalInfo)
        {
            var Data = _unitOfWork.GenericRepository<HospitalInfo>().GetById(hospitalInfo.Id);
            Data.Name = hospitalInfo.Name;
            Data.City = hospitalInfo.City;
            Data.PinCode = hospitalInfo.PinCode;
            Data.Country = hospitalInfo.Country;
            _unitOfWork.GenericRepository<HospitalInfo>().Update(Data);
            _unitOfWork.Save();

        }
        private List<HospitalInfoViewModel> ConvertModelToViewModelList(List<HospitalInfo> modelList)
        {
            return modelList.Select(x => new HospitalInfoViewModel(x)).ToList();
        }
    }
}
