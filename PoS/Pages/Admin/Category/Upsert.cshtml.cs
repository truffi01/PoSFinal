using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PoS.DataAccess.Data.Repository.iRepository;

namespace PoS
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitofWork _unitOfWork;

        public UpsertModel(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Models.Category CategoryObj { get; set; }

        public IActionResult OnGet(int? id)
        {
            CategoryObj = new Models.Category();
            if (id !=null)
            {
                CategoryObj = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id.GetValueOrDefault());
                if (CategoryObj == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }
    }
}