using Microsoft.AspNetCore.Mvc.Rendering;
using PoS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoS.DataAccess.Data.Repository.iRepository
{
    public interface ICategory: IRepository<Category> 
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);
    }
}
