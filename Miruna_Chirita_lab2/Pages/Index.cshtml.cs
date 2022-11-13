using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Miruna_Chirita_lab2.Data;
using Miruna_Chirita_lab2.Models;

namespace Miruna_Chirita_lab2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Miruna_Chirita_lab2.Data.Miruna_Chirita_lab2Context _context;

        public IndexModel(Miruna_Chirita_lab2.Data.Miruna_Chirita_lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
