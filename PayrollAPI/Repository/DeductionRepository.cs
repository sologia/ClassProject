using Microsoft.EntityFrameworkCore;
using PayrolAPI.Repository.IRepository;
using PayrollAPI.Data;
using SharedModels;


namespace PayrolAPI.Repository
{
    public class DeductionRepository : Repository<Deduction>, IDeductionRepository
    {
        private readonly PayrollContext _context;

        public DeductionRepository(PayrollContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Deduction> UpdateAsync(Deduction entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
