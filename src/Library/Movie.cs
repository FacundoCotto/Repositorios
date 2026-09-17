//------------------------------------------------------------------------------
// <copyright file="Movie.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta clase representa una película.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">El nombre de la película.</param>
        /// <param name="year">El año de la película.</param>
        public Movie(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }

        /// <summary>
        /// El nombre de la película.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// El año de la película.
        /// </summary>
        public int Year { get; set; }
    }
}
