//------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta clase representa un catálogo de películas.
    /// </summary>
    public class Repository<T> : IRepository<T>
    {
        private ArrayList items = new ArrayList();

        public void Add(T item)
        {
            if (item != null)
            {
                this.items.Add(item);
            }
        }
        public void Remove(T item)
        {
            this.items.Remove(item);
        }

        public T Find(Predicate<T> criteria)
        {
            foreach (T item in this.items)
            {
                if (criteria(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}
