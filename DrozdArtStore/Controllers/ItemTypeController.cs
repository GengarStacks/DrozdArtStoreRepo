using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrozdArtStore.DataAccess;
using DrozdArtStore.DataAccess.Data.Repository.IRepository;
using DrozdArtStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace DrozdArtStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = SD.ManagerRole)]
    public class ItemTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(new { data = _unitOfWork.ItemType.GetAll() });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.ItemType.GetFirstOrDefault(u => u.Id == id);
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.ItemType.Remove(objFromDb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Deleting successful" });
        }
    }
}
