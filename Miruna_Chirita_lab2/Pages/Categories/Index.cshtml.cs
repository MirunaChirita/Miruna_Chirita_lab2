using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Miruna_Chirita_lab2.Data;
using Miruna_Chirita_lab2.Models;

namespace Miruna_Chirita_lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Miruna_Chirita_lab2.Data.Miruna_Chirita_lab2Context _context;

        public IndexModel(Miruna_Chirita_lab2.Data.Miruna_Chirita_lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        
        
        


        public async Task OnGetAsync( int? id,int? BookID)
        {
            CategoryData = new CategoryIndexData();

            CategoryData.Categories = await _context.Category
                .Include(i => i.BookCategories)
                .ThenInclude(i => i.Book)
                .ThenInclude(i => i.Author)
                .OrderBy(i => i.CategoryName)
                .ToListAsync();
            if(id != null)
            {
                CategoryID = id.Value;
                Category category = AssignedCategoryData.Categories.When(id => id.ID == id.Value).Single();
                AssignedCategoryData.BookCategories = category.BookCategories;
            }
        }
    }
}
