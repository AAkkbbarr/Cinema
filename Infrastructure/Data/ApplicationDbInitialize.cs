using Application.Commons;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbInitialize : IApplicationDbInitialize
    {
        private readonly ApplicationDBContext _context;

        public ApplicationDbInitialize(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Database.IsRelational())
            {
                _context.Database.Migrate();
            }
        }
    }
}
