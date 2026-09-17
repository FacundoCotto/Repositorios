<!-- markdownlint-disable-next-line MD033 MD041 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Programación II

# Ejercicio de aplicación

## Consigna

Analiza las clases [`CarsDatabase`](./src/Library/CarsDatabase.cs) y
[`MoviesCatalog`](./src/Library/MoviesCatalog.cs). ¿Qué problema encuentras?
¿Cómo podrías resolver ese problema?

Implementa tu solución y actualiza los casos de prueba.

> [!NOTE]
>
> Los métodos `Car CarsDatabase.FindCar(Predicate<Car>)` y `Movie
> MoviesCatalog.Find(Predicate<Movie>)` utilizan un concepto nuevo llamado
> [delegado](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/).
> Un delegado es un tipo de datos que representa métodos. En este caso el delegado
> será un
> [predicado](https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1?view=net-10.0).
> Los predicados son métodos que retornan `true` o `false`.

Por ejemplo, para buscar un auto, usarás:

```csharp
CarsDatabase database = new CarsDatabase();
…
Car found = database.FindCar(c => c.Model == "Focus");
```

El ejemplo anterior usa una [función
lambda](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)
para definir un método anónimo.

> [!IMPORTANT]
>
> Ni los delegados ni las funciones lambda son parte de los objetivos de
> aprendizaje del curso. Los mencionamos aquí porque son convenientes para este
> ejercicio.

## Uso de ![GitHub Copilot](https://img.shields.io/badge/GitHub%20Copilot-000?logo=githubcopilot&logoColor=fff)

Es posible usar GitHub Copilot en este repositorio. Consulta [cómo usar Copilot
para aprender](./COPILOT.md).
