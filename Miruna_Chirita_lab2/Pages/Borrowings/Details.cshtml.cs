using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Miruna_Chirita_lab2.Data;
using Miruna_Chirita_lab2.Models;

namespace Miruna_Chirita_lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Miruna_Chirita_lab2.Data.Miruna_Chirita_lab2Context _context;

        public DetailsModel(Miruna_Chirita_lab2.Data.Miruna_Chirita_lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}
