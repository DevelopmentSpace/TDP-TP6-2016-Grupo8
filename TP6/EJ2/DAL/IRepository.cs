using System.Collections.Generic;

namespace EJ2.DAL
{
    /// <summary>
    /// Interface correspondiente al patron Repositorio
    /// </summary>
    /// <typeparam name="TEntity">Tipo a almacenar</typeparam>
    interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Agrega un elemento al repositorio
        /// </summary>
        /// <param name="pEntity">Elemento a agregar</param>
        void Add(TEntity pEntity);

        /// <summary>
        /// Elimina un elemento del repositorio
        /// </summary>
        /// <param name="pEntity">Elemento a eliminar</param>
        void Remove(TEntity pEntity);

        /// <summary>
        /// Obtiene un elemento del repositorio
        /// </summary>
        /// <param name="pId">id del elemento a obtener</param>
        TEntity Get(int pId);

        /// <summary>
        /// Obtiene todos los elementos en el repositorio
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

    }
}
