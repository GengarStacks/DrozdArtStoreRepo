using DrozdArtStore.DataAccess.Data.Repository.IRepository;
using DrozdArtStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrozdArtStore.DataAccess.Data.Repository
{
    public class ItemTypeRepository : Repository<ItemType>, IItemTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public ItemTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetItemTypeListForDropDown()
        {
            return _db.ItemType.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(ItemType itemType)
        {
            var objFromDb = _db.ItemType.FirstOrDefault(s => s.Id == itemType.Id);

            objFromDb.Name = itemType.Name;
            objFromDb.DisplayOrder = itemType.DisplayOrder;

            _db.SaveChanges();
        }
    }
}
