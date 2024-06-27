using SharedModels;

namespace PayrolAPI.Repository.IRepository
{
    public interface IDeductionRepository : IRepository<Deduction>
    {
        Task<Deduction> UpdateAsync(Deduction entity);

    }
}
