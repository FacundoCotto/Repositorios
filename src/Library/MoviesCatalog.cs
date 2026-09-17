//------------------------------------------------------------------------------
// <copyright file="MoviesCatalog.cs" company="Universidad Católica del Uruguay">
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
    public class MoviesCatalog
    {
        private ArrayList movies = new ArrayList();

        /// <summary>
        /// Agrega una película al catálogo.
        /// </summary>
        /// <param name="movie">La película a agregar.</param>
        public void Add(Movie movie)
        {
            if (movie != null)
            {
                this.movies.Add(movie);
            }
        }

        /// <summary>
        /// Elimina una película del catálogo.
        /// </summary>
        /// <param name="movie">La película a remover.</param>
        public void Remove(Movie movie)
        {
            this.movies.Remove(movie);
        }

        /// <summary>
        /// Busca una película en el catálogo que cumpla con un criterio
        /// específico.
        /// </summary>
        /// <param name="criteria">El criterio por el cual buscar.</param>
        /// <returns>La película encontrada que cumple el criterio especificado
        /// o null si no se encuentra ninguna.</returns>
        public Movie Find(Predicate<Movie> criteria)
        {
            foreach (Movie movie in this.movies)
            {
                if (criteria(movie))
                {
                    return movie;
                }
            }

            return null;
        }
    }
}
