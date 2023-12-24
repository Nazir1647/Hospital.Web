using Hospital.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HospitalsController : Controller
    {
        private IHospitalInfoService _hospitalInfoService;

        public HospitalsController(IHospitalInfoService hospitalInfoService)
        {
            _hospitalInfoService = hospitalInfoService;
        }

        public IActionResult Index(int pageNumber = 1,int pageSize = 10)
        {
            return View(_hospitalInfoService.GetAll(pageNumber, pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
