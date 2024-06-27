using Microsoft.EntityFrameworkCore;
using PayrolAPI.Repository.IRepository;
using PayrollAPI.Data;
using SharedModels;

namespace PayrolAPI.Repository
{
    public class IncomeRepository : Repository<Income>, IIncomeRepository
    {
        private readonly PayrollContext _context;

        public IncomeRepository(PayrollContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Income> UpdateAsync(Income entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
