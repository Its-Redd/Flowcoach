namespace FlowCoach.DataAccess
{
    /// <summary>
    /// Represents a generic repository interface for CRUD operations.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);

        /// <summary>
        /// Updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(T entity);

        /// <summary>
        /// Deletes an entity from the repository by its ID. * what the f... is this?
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        void Delete(int id);

        /// <summary>
        /// Gets all entities from the repository.
        /// </summary>
        /// <returns>An enumerable collection of entities.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Gets an entity from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to get.</param>
        /// <returns>The entity with the specified ID.</returns>
        T GetBy(int id);
    }

}
