using System;

namespace Netcore{

    class Program{

        //Función para calcular la suma de 2 números entereos

        static int Suma(int a,int b){
            return a + b;
        }

        static void Main(string[] args){
            System.Console.WriteLine("PROGRAMA PARA SUMA DE 2 NUMEROS");
            Console.WriteLine("Ingrese el primer número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int b = Convert.ToInt32(Console.ReadLine());
            int resultado = Suma(a,b);
            Console.WriteLine("La suma de {0} y {1} es {2}",a,b,resultado);
        }
    }
}
