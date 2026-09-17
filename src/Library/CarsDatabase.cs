//------------------------------------------------------------------------------
// <copyright file="CarsDatabase.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta clase representa una base de datos de autos.
    /// </summary>
    public class CarsDatabase
    {
        private ArrayList cars = new ArrayList();

        /// <summary>
        /// Agrega un auto a la base de datos.
        /// </summary>
        /// <param name="car">El auto a agregar.</param>
        public void Add(Car car)
        {
            if (car != null)
            {
                this.cars.Add(car);
            }
        }

        /// <summary>
        /// Elimina un auto de la base de datos.
        /// </summary>
        /// <param name="car">El auto a remover.</param>
        public void Remove(Car car)
        {
            this.cars.Remove(car);
        }

        /// <summary>
        /// Busca un auto en la base de datos que cumpla con un criterio
        /// específico.
        /// </summary>
        /// <param name="criteria">El criterio por el cual buscar.</param>
        /// <returns>El auto encontrado que cumple el criterio especificado o
        /// null si no se encuentra ninguno.</returns>
        public Car Find(Predicate<Car> criteria)
        {
            foreach (Car car in this.cars)
            {
                if (criteria(car))
                {
                    return car;
                }
            }

            return null;
        }
    }
}
