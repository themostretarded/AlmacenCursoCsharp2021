using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var estudiantes = new[]
            {
                new
                {
                    EstudianteID = 1,
                    Nombre = "Héctor",
                    ApellidoPaterno = "Pérez",
                    Universidad = "Real de Brasil"
                },
                new
                {
                    EstudianteID = 2,
                    Nombre = "Ana",
                    ApellidoPaterno = "Nepomuceno",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 3,
                    Nombre = "Pedro",
                    ApellidoPaterno = "Sánchez",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 4,
                    Nombre = "José",
                    ApellidoPaterno = "Infante",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 5,
                    Nombre = "Regina",
                    ApellidoPaterno = "Bustamante",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    ApellidoPaterno = "Jiménez",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Hernández",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    ApellidoPaterno = "Monroe",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    ApellidoPaterno = "Estrada",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    ApellidoPaterno = "Rojas",
                    Universidad = "Real de Brasil"
                },
            };

            var universidades = new[]
            {
                new
                {
                    Universidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new
                {
                    Universidad = "Oxford",
                    Ciudad = "Oxford",
                    Pais = "Reino Unido"
                },
                new
                {
                    Universidad = "Harvard",
                    Ciudad = "Cambridge",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
            };

            //var nombreEstudiantes = estudiantes.Select(e => new  {
            //    Nombre = e.Nombre,
            //    Apellido = e.ApellidoPaterno
            //});

            //var nombresEstudiantes = from nombres in estudiantes
            //                             //select nombres.Nombre;
            //                         select new { nombres.Nombre, nombres.ApellidoPaterno };

            //foreach (var nombre in nombresEstudiantes) {
            //    Console.WriteLine(nombre);
            //}

            //var universidadesEu = universidades
            //    .Where(u => u.Pais == "Estados Unidos")
            //    .Select(u => u.Universidad);

            //var universidadEU = from u in universidades
            //                    where string.Equals(u.Pais, "Estados Unidos")
            //                    select u.Universidad;

            //foreach (var u in universidadEU)
            //{
            //    Console.WriteLine(u);
            //}

            //IEnumerable<string> nombresUniversidaades =
            //    universidades
            //    .OrderBy(u => u.Universidad)
            //    .ThenBy(u => u.Pais)
            //    .Select(u => u.Universidad);

            //var nombresUniversidades = from u in universidades
            //                           orderby u.Universidad descending
            //                           select u.Universidad;
            //foreach (var u in nombresUniversidades)
            //{
            //    Console.WriteLine(u);
            //}


            //foreach (var universidad in universidadesPais)
            //{
            //    Console.WriteLine( universidad);
            //}

            //var universidadesPais = universidades
            //    .GroupBy(u => u.Pais);

            //var universidadesPais = from u in universidades
            //                        group u by u.Pais;



            //int numeroUniversidades =
            //    universidades
            //    .Select(x => x.Universidad)
            //    .Count();

            //int numeroUniversidades = (from u in universidades select u.Universidad).Distinct().Count();
            //Console.WriteLine(numeroUniversidades);

            //int numeroPaises =
            //    universidades
            //    .Select(x => x.Pais)
            //    .Distinct()
            //    .Count();

            //var join = estudiantes
            //    .Select(e => new
            //    {
            //        e.Nombre,
            //        e.ApellidoPaterno,
            //        e.Universidad
            //    })
            //    .Join(universidades, e => e.Universidad, u => u.Universidad, (e, u) => new {e.Nombre,e.ApellidoPaterno,u.Pais });

            //var join = from u in universidades
            //           join e in estudiantes
            //           on u.Universidad equals e.Universidad
            //           select new { e.Nombre, e.ApellidoPaterno, u.Pais };
            //foreach (var fila in join)
            //{
            //    Console.WriteLine(fila);
            //}

            //Take(6)
            //var parte = estudiantes.Skip(2).Take(3);
            //foreach (var estudiante in parte)
            //{
            //    Console.WriteLine(estudiante.Nombre);    
            //}

            //var cualquiera = estudiantes.Any(x => x.Nombre.StartsWith("H"));
            //var todos = estudiantes.All(x => x.Nombre != "");
            //var primero = estudiantes.FirstOrDefault(x => x.Nombre.StartsWith("H"));
            //if (primero != null)
            //{
            //    //chingaderas
            //}

            var estudiantesNombres = estudiantes.Select(x => x.Nombre).ToList();
            foreach (var est in estudiantesNombres)
            {
                Console.WriteLine(est);
            }
            estudiantes[0] = new
            {
                EstudianteID = 1,
                Nombre = "Francisco",
                ApellidoPaterno = "Rodriguez",
                Universidad = "Hardvard"
            };
            foreach (var est in estudiantesNombres)
            {
                Console.WriteLine(est);
            }

            Console.ReadLine();

        }
    }
}
