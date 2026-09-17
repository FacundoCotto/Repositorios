//------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T Find(Predicate<T> item);
    }
}
