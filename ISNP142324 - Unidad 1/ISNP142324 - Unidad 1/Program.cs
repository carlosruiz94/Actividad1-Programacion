﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ISNP142324___Unidad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String cont = "s";
            while (cont == "s")
            {
                Console.WriteLine("Seleccione la opción que desea ejecutar: ");
                Console.WriteLine("1- Validador de números positivos o negativos");
                Console.WriteLine("2- Tablas de multiplicar");
                Console.WriteLine("3- Sumatoria de números positivos");
                Console.WriteLine("4- Validador de números primos");
                Console.WriteLine("5- Promedio de serie de números");

                string input = Console.ReadLine();
                int opcion;

                if (int.TryParse(input, out opcion))
                {
                    Console.Clear(); //limpia lo que hay en pantalla
                    if (opcion >= 0 && opcion <= 5)
                    {
                        switch (opcion)
                        {
                            case 1:
                                Numposneg();
                                break;
                            case 2:
                                tablas();
                                break;
                            case 3:
                                suma();
                                break;
                            case 4:
                                primos();
                                break;
                            case 5:
                                sumpromed();
                                break;
                            case 0:
                                cont = "n";
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida, intente de nuevo");
                    }
                }
                void Numposneg()
                {

                    Console.Write("Ingrese un número para saber si es positivo o negativo: ");
                    int num1 = int.Parse(Console.ReadLine());
                    if (num1 >= 1)
                    {
                        Console.WriteLine("El numero ingresado es positivo.");
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es negativo.");
                    }
                }
                void tablas()
                {
                    Console.WriteLine("ingrese un número del 1 al 10 para mostrar su tabla de multiplicar");
                    int varmult = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(varmult + " x " + i + " = " + varmult * i);
                    }

                }
                void suma()
                {
                    int sumatoria = 0;
                    while (true)
                    {
                        Console.WriteLine("Ingrese un numero: ");
                        int numero = int.Parse(Console.ReadLine());

                        if (numero > 0)
                        {
                            sumatoria += numero;
                            Console.WriteLine("La suma hasta el momento es: " + sumatoria);
                        }
                        else if (numero == 0)
                        {
                            Console.WriteLine("La suma de los numeros positivos es: " + sumatoria);
                            break;
                        }

                        else if (numero < 0)
                        {
                            Console.WriteLine("\n" + "El número ingresado es un negativo, la sumatoria de los números es: " + sumatoria);
                            break;
                        }


                    }
                }
                void primos()
                {
                    Console.WriteLine("Ingrese un número para saber si es primo: ");
                    int numero = int.Parse(Console.ReadLine());
                    int contador = 0;
                    for (int i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            contador++;
                        }
                    }
                    if (contador == 2)
                    {
                        Console.WriteLine("El numero es primo");
                    }
                    else
                    {
                        Console.WriteLine("El numero no es primo");
                    }
                }
                void sumpromed()
                {
                    int sumatoria = 0;
                    int contador = 0;
                    int numero = 0;

                    Console.WriteLine("Ingrese números para calcular el promedio. Para finalizar, ingrese 0: ");
                    while (int.TryParse(Console.ReadLine(), out numero) && numero != 0)
                    {
                        sumatoria += numero;
                        contador++;
                        Console.WriteLine("Ingrese otro numero para sumar y calcular promedio, ingresar 0 para finalizar");
                    }
                    double promedio = (double)sumatoria / contador;
                    Console.WriteLine("El promedio de los números es: " + promedio);
                }
            }
        }
    }
}
            
        

    
