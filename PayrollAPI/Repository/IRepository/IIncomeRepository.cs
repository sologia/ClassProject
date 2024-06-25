using SharedModels;

namespace PayrolAPI.Repository.IRepository
{
    public interface IIncomeRepository : IRepository<Income>
    {
        Task<Income> UpdateAsync(Income entity);

    }
}
