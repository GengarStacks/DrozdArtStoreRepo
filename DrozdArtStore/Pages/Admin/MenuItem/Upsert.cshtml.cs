using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DrozdArtStore.DataAccess.Data.Repository.IRepository;
using DrozdArtStore.Models.ViewModels;
using DrozdArtStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrozdArtStore.Pages.Admin.MenuItem
{
    [Authorize(Roles = SD.ManagerRole)]
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UpsertModel(IUnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }

        [BindProperty]
        public MenuItemVM MenuItemObj{ get; set; }
        public IActionResult OnGet(int? id)
        {
            MenuItemObj = new MenuItemVM
            {
                CategoryList = _unitOfWork.Category.GetCategoryListForDropDown(),
                ItemTypeList = _unitOfWork.ItemType.GetItemTypeListForDropDown(),
                MenuItem = new Models.MenuItem()
            };

            if (id != null)
            {
                MenuItemObj.MenuItem = _unitOfWork.MenuItem.GetFirstOrDefault(u => u.Id == id);
                if (MenuItemObj.MenuItem == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            if(!ModelState.IsValid)
            {
                return Page();
                
            }
            if(MenuItemObj.MenuItem.Id == 0)
            {
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\menuItems");
                var extension = Path.GetExtension(files[0].FileName);

                using(var fileStream = new FileStream(Path.Combine(uploads,fileName+extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                MenuItemObj.MenuItem.Image = @"\images\menuItems\" + fileName + extension;
                _unitOfWork.MenuItem.Add(MenuItemObj.MenuItem);


                
                
 
            }
            else
            {
                //edit item
                var objFromDb = _unitOfWork.MenuItem.Get(MenuItemObj.MenuItem.Id);

                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\menuItems");
                    var extension = Path.GetExtension(files[0].FileName);

                    var imagePath = Path.Combine(webRootPath, objFromDb.Image.TrimStart('\\'));

                    

                    if (System.IO.File.Exists(imagePath) )
                    {
                        System.IO.File.Delete(imagePath);
                   
                    }



                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    MenuItemObj.MenuItem.Image = @"\images\menuItems" + fileName + extension;
                    //large img


                    _unitOfWork.MenuItem.Add(MenuItemObj.MenuItem);
                }
                else
                {
                    MenuItemObj.MenuItem.Image = objFromDb.Image;

                }

                _unitOfWork.MenuItem.Update(MenuItemObj.MenuItem);
            }

            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}
