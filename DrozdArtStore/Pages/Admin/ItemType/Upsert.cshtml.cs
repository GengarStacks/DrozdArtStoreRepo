using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrozdArtStore.DataAccess.Data.Repository.IRepository;
using DrozdArtStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrozdArtStore.Pages.Admin.ItemType
{
    [Authorize(Roles = SD.ManagerRole)]
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Models.ItemType ItemTypeObj { get; set; }

        public IActionResult  OnGet(int? id)
        {
            ItemTypeObj = new Models.ItemType();

            if(id != null)
            {
                ItemTypeObj = _unitOfWork.ItemType.GetFirstOrDefault(i => i.Id == id);
                if(ItemTypeObj == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }

        
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(ItemTypeObj.Id == 0)
            {
                _unitOfWork.ItemType.Add(ItemTypeObj);
            }
            else
            {
                _unitOfWork.ItemType.Update(ItemTypeObj);
            }

            _unitOfWork.Save();

            return RedirectToPage("./Index");
        }
    }
}
