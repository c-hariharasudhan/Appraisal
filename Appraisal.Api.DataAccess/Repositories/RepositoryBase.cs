using Appraisal.Api.DataContract.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Appraisal.Api.DataAccess.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly PayrollContext _payrollContext;

        public RepositoryBase(PayrollContext payrollContext)
        {
            _payrollContext = payrollContext;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _payrollContext.AddAsync(entity);
                await _payrollContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _payrollContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Entity not found: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(UpdateAsync)} entity must not be null");
            }

            try
            {
                _payrollContext.Update(entity);
                await _payrollContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
