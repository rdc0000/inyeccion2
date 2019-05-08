using System;

namespace inyeccion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Proyecto pro = new Proyecto();
            pro.imprimir();
            
            //delegados
            /*Func<double, double, double> raiz = calcularRaiz;
            
            Console.WriteLine($"raiz es igual a {raiz(8,2)}");

            Func<int, int> doble = x => { return x *= 2; };
            Console.WriteLine($"El doble es {doble(8)}");

            Func<double, double, double> potencia = (q, y) => { return Math.Pow(q, y); };
            Console.WriteLine($"potencia es igual a {potencia(4, 2)}");*/

            Console.ReadLine();
        }
       public static double calcularRaiz(double bas, double exp)
            {
                return Math.Pow(bas, exp);
            }        
    }
}
