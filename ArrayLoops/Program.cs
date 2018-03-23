using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoops
{
    class Program
    {
        private enum Opcion
        {
            Suma = 1,
            Resta = 2,
            Multiplicacion = 3,
            Division = 4,
            Salir = 5
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la calculadora");
            var opcion = Menu();
            while (opcion != Opcion.Salir)
            {
                int resultado = PideDatos(opcion);
                Console.WriteLine("El resultado es {0}", resultado);
                Console.WriteLine("");
                opcion = Menu();
            }
        }

        private static int PideDatos(Opcion opcion)
        {
            ICalculadora calc = new Calculadora();
            int num1, num2, resultado = 0;
            Console.WriteLine("Introduce el primer número de la operación");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número de la operación");
            num2 = Convert.ToInt32(Console.ReadLine());


            switch (opcion)
            {
                case Opcion.Suma:
                    return calc.Suma(num1, num2);
                case Opcion.Resta:
                    return calc.Resta(num1, num2);
                case Opcion.Multiplicacion:
                    return calc.Multiplicacion(num1, num2);
                case Opcion.Division:
                    return calc.Division(num1, num2);
                default:
                    return resultado;
            }
        }

        private static Opcion Menu()
        {
            Console.WriteLine("Que opción quieres realizar");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Dividir");
            Console.WriteLine("5.- Salir de la aplicación");
            var seleccion = Convert.ToInt32(Console.ReadLine());
            return (Opcion)Convert.ToInt32(seleccion);
        }


    }
}
