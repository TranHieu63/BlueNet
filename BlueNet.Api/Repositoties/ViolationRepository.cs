using BlueNet.Api.Data;
using BlueNet.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueNet.Api.Repositoties
{
    public class ViolationRepository : IViolationRepository
    {
        private readonly BlueNetDbContext _context;

        public ViolationRepository(BlueNetDbContext context)
        {
            _context = context;
        }

        public async Task<List<Violation>> GetViolationList()
        {
            return await _context.Violations.ToListAsync();
        }
    }
}
