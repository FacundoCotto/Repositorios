//------------------------------------------------------------------------------
// <copyright file="Car.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta clase representa un auto.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Car"/>.
        /// </summary>
        /// <param name="model">El modelo del auto.</param>
        /// <param name="maker">El fabricante del auto.</param>
        /// <param name="year">El año del auto.</param>
        public Car(string model, string maker, int year)
        {
            this.Model = model;
            this.Maker = maker;
            this.Year = year;
        }

        /// <summary>
        /// Obtiene o establece el modelo del auto.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Obtiene o establece el fabricante del auto.
        /// </summary>
        public string Maker { get; set; }

        /// <summary>
        /// Obtiene o establece el año del auto.
        /// </summary>
        public int Year { get; set; }
    }
}
