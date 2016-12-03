using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EJ2.DAL.EntityFramework
{
    /// <summary>
    /// Implementacion del repositorio para entidades de EntityFramework
    /// </summary>
    /// <typeparam name="TEntity">Tipo de elemento (clase)</typeparam>
    /// <typeparam name="TDbContext">Tipo de contexto (DbContext)</typeparam>
    abstract class EFRepository<TEntity, TDbContext> : IRepository<TEntity>
        where TEntity : class
        where TDbContext : DbContext
    {
        //Contexto a utilizar
        protected readonly TDbContext iDbContext;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pContext">Contexto a utilizar</param>
        public EFRepository(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
        }

        /// <summary>
        /// Agrega un elemento al repositorio
        /// </summary>
        /// <param name="pEntity">Elemento a agregar</param>
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        /// <summary>
        /// Obtiene un elemento del repositorio
        /// </summary>
        /// <param name="pId">Id del elemento a obtener</param>
        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Elimina un elemento del repositorio
        /// </summary>
        /// <param name="pEntity">Elemento a eliminar</param>
        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
