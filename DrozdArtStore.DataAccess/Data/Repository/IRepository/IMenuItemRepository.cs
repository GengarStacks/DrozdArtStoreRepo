using DrozdArtStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrozdArtStore.DataAccess.Data.Repository.IRepository
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
    }
}
