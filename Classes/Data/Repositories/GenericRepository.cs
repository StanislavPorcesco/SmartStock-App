using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using System.Linq.Expressions;

namespace SmartStock.Classes.Data.Repositories
{
    /// <summary>
    /// Implementarea generică a IRepository<T>.
    /// Oferă operații CRUD standard pentru orice entitate.
    /// </summary>
    /// <typeparam name="T">Tipul entiității de model</typeparam>
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly SmartStockContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(SmartStockContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Returnează IQueryable pentru a permite filtrări și paginări suplimentare.
        /// </summary>
        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        /// <summary>
        /// Obține o entitate după ID.
        /// </summary>
        public virtual async Task<T> GetByIdAsync(object id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _dbSet.FindAsync(id);
        }

        /// <summary>
        /// Obține entități care satisfac o condiție.
        /// </summary>
        public virtual async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return await _dbSet.Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Adaugă o nouă entitate.
        /// </summary>
        public virtual void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Add(entity);
        }

        /// <summary>
        /// Adaugă mai multe entități.
        /// </summary>
        public virtual void AddRange(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            _dbSet.AddRange(entities);
        }

        /// <summary>
        /// Actualizează o entitate.
        /// </summary>
        public virtual void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);
        }

        /// <summary>
        /// Elimină o entitate.
        /// </summary>
        public virtual void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Remove(entity);
        }

        /// <summary>
        /// Elimină mai multe entități.
        /// </summary>
        public virtual void DeleteRange(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            _dbSet.RemoveRange(entities);
        }

        /// <summary>
        /// Salvează modificările în baza de date.
        /// </summary>
        public virtual async Task<int> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("An error occurred while saving changes.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An unexpected error occurred while saving.", ex);
            }
        }

        /// <summary>
        /// Salvează modificările în baza de date cu support pentru CancellationToken.
        /// </summary>
        public virtual async Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await _context.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("An error occurred while saving changes.", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An unexpected error occurred while saving.", ex);
            }
        }
    }
}
