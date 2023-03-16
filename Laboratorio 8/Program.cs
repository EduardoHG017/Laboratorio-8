using System;

namespace Laboratorio03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //"\t" = tabular y "\n" = nueva linea
            //MENU
            Console.WriteLine("a. SUMATORIA: ");
            Console.WriteLine("b. TABLAS DE MULTIPLICAR: ");
            Console.WriteLine("c. NUMEROS PERFECTOS: ");

            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {

                case 'a':
                    Console.WriteLine("INGRESE UN NUMERO: ");
                    int n = Convert.ToInt32(Console.ReadLine());


                    int resultado = 0;

                    do
                    {
                        resultado = resultado + n;
                        n--;

                    } while (n > 0);

                    Console.WriteLine("SUMATORIA = " + resultado);
                    break;

                case 'b':

                    for (int i = 1; i <= 10; i++)
                    {

                        Console.Write(i + ": ");
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write((i * j) + "\t");
                        }
                        Console.Write("\n");
                    }

                    break;

                case 'c':
                    Console.WriteLine("Ingrese el numero que desea evaluar: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    int c = 0;
                    int b = n;
                    for (int x = 1; x < b; x++)
                    {
                        if (n % x == 0)
                        {
                            c = c + x;
                        }
                    }
                    if (c == n)
                    {
                        Console.WriteLine(n + " es un numero perfecto");
                    }
                    else
                    {
                        Console.WriteLine(n + " no es un numero perfecto");
                    }

                    break;

            }











        }
    }
}