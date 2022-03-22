using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Función para calcular la Resta de 2 números enteros
        static int Resta(int r1, int r2)
        {
            return r1 - r2;
        }

        //Función para calcular la Multiplicación de 2 números enteros
        static int Multi(int m1, int m2)
        {
            return m1 * m2;
        }

        //Función para calcular la División de 2 números enteros
        static int Divi(int d1, int d2)
        {
            return d1 / d2;
        }

        //Función para imprimir los 10 primeros números primos
        static void Primo()
        {
            int n = 2;
            int total = 1;

            while (total <= 10)
            {
                bool esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                n++;
            }

        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Conversión de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La la resta de {0} y {1} es {2}", r1, r2, Resta(r1, r2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int m1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La la Multiplicación de {0} y {1} es {2}", m1, m2, Multi(m1, m2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int d1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La la División de {0} y {1} es {2}", d1, d2, Divi(d1, d2));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primo();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Seleccione una conversión");
                        Console.WriteLine("1. C  a  F");
                        Console.WriteLine("2. F  a  C");
                        int n = Convert.ToInt32(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("Ingresa grados centigrados");
                            double c = Convert.ToDouble(Console.ReadLine());
                            double f = (c * 9 / 5) + (32);
                            Console.WriteLine(c + "C equivale a " + f + "F");
                        }
                        else
                        {
                            Console.WriteLine("Ingresa grados fahrenheit");
                            double f = Convert.ToDouble(Console.ReadLine());
                            double c = (f - 32) * 5 / 9;
                            Console.WriteLine(f + "F equivale  a " + c + "C");
                        }
                        Console.ReadKey();
                        break;
                }

            } while (!opcion.Equals("0"));

        }
    }
}
