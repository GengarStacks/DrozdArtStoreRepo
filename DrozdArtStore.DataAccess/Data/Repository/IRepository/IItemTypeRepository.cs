using DrozdArtStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrozdArtStore.DataAccess.Data.Repository.IRepository
{
    public interface IItemTypeRepository : IRepository<ItemType>
    {
        IEnumerable<SelectListItem> GetItemTypeListForDropDown();

        void Update(ItemType itemType);
    }
}
