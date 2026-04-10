using System.Linq.Expressions;

namespace SmartStock.Classes.Data.Interfaces
{
    /// <summary>
    /// Interfață generică pentru operații CRUD.
    /// Oferă accesul la date într-o manieră standardizată și ușor de testat.
    /// </summary>
    /// <typeparam name="T">Tipul entiității de model</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Returnează o interogare IQueryable pentru entitățile de tip T.
        /// Permite filtrarea, paginarea și alte operații LINQ în memoria query-ului.
        /// </summary>
        /// <returns>IQueryable pentru entitățile de tip T</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Obține o entitate după ID-ul primar.
        /// </summary>
        /// <param name="id">ID-ul primar al entiității</param>
        /// <returns>Entitatea sau null dacă nu există</returns>
        Task<T> GetByIdAsync(object id);

        /// <summary>
        /// Obține entități care satisfac o condiție specificată.
        /// </summary>
        /// <param name="predicate">Expresia de filtrare</param>
        /// <returns>Task cu lista entiților care satisfac condiția</returns>
        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Adaugă o nouă entitate în context.
        /// </summary>
        /// <param name="entity">Entitatea de adăugat</param>
        void Add(T entity);

        /// <summary>
        /// Adaugă mai multe entități în context.
        /// </summary>
        /// <param name="entities">Colecția entiților de adăugat</param>
        void AddRange(IEnumerable<T> entities);

        /// <summary>
        /// Actualizează o entitate existentă.
        /// </summary>
        /// <param name="entity">Entitatea de actualizat</param>
        void Update(T entity);

        /// <summary>
        /// Elimină o entitate din context.
        /// </summary>
        /// <param name="entity">Entitatea de eliminat</param>
        void Delete(T entity);

        /// <summary>
        /// Elimină mai multe entități din context.
        /// </summary>
        /// <param name="entities">Colecția entiților de eliminat</param>
        void DeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// Salvează toate modificările în baza de date.
        /// </summary>
        /// <returns>Task care se completează când salvarea este finalizată</returns>
        Task<int> SaveAsync();

        /// <summary>
        /// Anulează toate modificările din sesiunea curentă.
        /// </summary>
        Task<int> SaveAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Detașează toate entitățile urmărite din change tracker.
        /// Folosit pentru a preveni eșecurile în cascadă când un SaveAsync eșuează
        /// și entitățile rămân în stare Added pe contextul partajat.
        /// </summary>
        void ClearChanges();
    }
}
