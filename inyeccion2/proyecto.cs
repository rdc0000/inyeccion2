using System;
using System.Collections.Generic;
using System.Text;

namespace inyeccion2
{
    class Proyecto
    {
        public List<Proyecto> proyectos = new List<Proyecto>();

        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        public List<Proyecto> AgregarProyecto()
        {
            Console.WriteLine("Escriba Y para ingresar");
            var res = Console.ReadLine();
            while (res == "Y")
            {
                Console.WriteLine("Escriba nombre del proyecto");
                var nom = Console.ReadLine();
                Console.WriteLine("Escriba codigo del proyecto");
                var cod = Console.ReadLine();
                var miProyecto = new Proyecto()
                {
                    Nombre = nom,
                    Codigo = int.Parse(cod)
                };
                proyectos.Add(miProyecto);
                Console.WriteLine("Escriba Y para ingresar");
                res = Console.ReadLine();
            }
            return proyectos;
        }
        public List<Proyecto> AgregarProyecto2()
        {
            var proys = new List<Proyecto>()
            {
                new Proyecto()
                {
                    Nombre="Bancaria",
                    Codigo=9,
                    Area="Comercio",
                    Duracion=53
                },
                new Proyecto()
                {
                    Nombre="Mercadeo",
                    Codigo=52,
                    Area="Talento humano",
                    Duracion=8
                },
                new Proyecto()
                {
                    Nombre="Atencion primera",
                    Codigo=3,
                    Area="AIPI",
                    Duracion=1
                },
                new Proyecto()
                {
                    Nombre="Moneda",
                    Codigo=14,
                    Area="Monetaria",
                    Duracion=35
                }

            };
            return proys;
        }

        public void imprimir(List<Proyecto> proyectos)
        {
            foreach (var item in proyectos)
            {
                
                Console.WriteLine($"Nombre: {item.Nombre}");
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Area: {item.Area}");
                Console.WriteLine($"Duracion: {item.Duracion}");

            }
        }




    }
    
}
