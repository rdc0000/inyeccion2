using System;
using System.Linq;

namespace inyeccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyecto pro = new Proyecto();
            var lista = pro.AgregarProyecto2();


            //delegados
            /*Func<double, double, double> raiz = calcularRaiz;
            
            Console.WriteLine($"raiz es igual a {raiz(8,2)}");

            Func<int, int> doble = x => { return x *= 2; };
            Console.WriteLine($"El doble es {doble(8)}");

            Func<double, double, double> potencia = (q, y) => { return Math.Pow(q, y); };
            Console.WriteLine($"potencia es igual a {potencia(4, 2)}");*/

            Console.WriteLine("---------------Ejercicio uno-------------------------");
            var primero = lista.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            pro.imprimir(primero);

            Console.WriteLine("---------------Ejercicio dos-------------------------");
            var segundo = from q in lista
                          where (q.Nombre.StartsWith("B"))
                          select q;
            pro.imprimir(segundo.ToList());

            Console.WriteLine("---------------Ejercicio tres------------------------");
            var tercero = lista.Where(x => x.Codigo % 7 == 0).ToList();
            pro.imprimir(tercero);

            Console.WriteLine("---------------Ejercicio cuatro------------------------");
            var cuarto = lista.GroupBy(x =>
              {
                  if (x.Duracion < 6)
                  {
                      return "Menores de 6";
                  }
                  else if (x.Duracion > 6 && x.Duracion < 10)
                  {
                      return "Entre 6 y 10";
                  }
                  else
                  {
                      return "Mayores a 10";
                  }
              });
            foreach (var group in cuarto)
            {
                Console.WriteLine("*************  Proyectos " + group.Key + " ****************");
                foreach (var item in group)
                {
                    Console.WriteLine("Nombre: " + item.Nombre +
                            "\r\n" + "Codigo: " + item.Codigo +
                            "\r\n" + "Area: " + item.Area +
                            "\r\n" + "Duracion: " + item.Duracion);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            Console.WriteLine("---------------Ejercicio cinco------------------------");
            var quinto = lista.Average(x => x.Duracion);
            Console.WriteLine("El promedio de la duracion es de " + quinto);
            Console.WriteLine();

            Console.WriteLine("---------------Ejercicio seis------------------------");            
            var max = lista.Max(x => x.Duracion);
            var sexto = from y in lista
                        where y.Duracion == max
                        select (y.Nombre);
            foreach (var item in sexto)
            {
                 Console.WriteLine("Proyecto con mas duracion"+item);
            }
            Console.WriteLine();

            Console.WriteLine("---------------Ejercicio siete------------------------");
            var septimo = lista.Where(x => x.Duracion > 6).ToList();                         
            foreach (var item in septimo)
            {
                Console.WriteLine("Nombre: " + item.Nombre+" Area: "+ item.Area);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
       /*public static double calcularRaiz(double bas, double exp)
            {
                return Math.Pow(bas, exp);
            }  */     
    }
}
