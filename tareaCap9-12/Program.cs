using System;

namespace tareaCap9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            static void TitulosGenerales()
            {
                Console.WriteLine("EJERCICIOS PRACTICOS || CAPITULO 1-5");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("1- Capitulo 5");
                Console.WriteLine("2- Capitulo 6");
                Console.WriteLine("3- Capitulo 7");
                Console.WriteLine("4- Capitulo 8");
                Console.WriteLine("0- Salir");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                //hola

                Console.Write("Elegir una opcion -> ");
            }

            //funcion que retorna el nombre el numero escrito

            //variables generales
            string entrada = "";
                int nav;
                int navCap5;
                int navCap6;
                int navCap7;
                int navCap8;

                do
                {
                    TitulosGenerales();
                    entrada = Console.ReadLine();
                    nav = Convert.ToInt32(entrada);

                    switch (nav)
                    {
                        //CAPITULO 5
                        case 1:
                            System.Console.Clear();
                            Console.WriteLine("1- Hacer una función que calcule el factorial de un número.");
                            Console.WriteLine("2- Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.");
                            Console.WriteLine("0- Atras");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("Elegir una opcion ->");
                            entrada = Console.ReadLine();
                            navCap5 = Convert.ToInt32(entrada);
                            switch (navCap5)
                            {
                                case 1:
                                   
                                    break;
                                case 2:
                                    
                                    break;
                                default:
                                    System.Console.Clear();
                                    break;
                            }
                            break;
                        //CAPITULO 6
                        case 2:
                            System.Console.Clear();
                            Console.WriteLine("1- Agregar el cálculo del promedio para el programa con arreglo jagged.");
                            Console.WriteLine("2- Agregar el cálculo de la menor calificación para el programa con arreglo jagged.");
                            Console.WriteLine("3- Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.");
                            Console.WriteLine("4- Modificar el programa de la escuela para que utilice funciones.");
                            Console.WriteLine("5- Crear un programa que pase un arreglo jagged como parámetro a una función.");
                            Console.WriteLine("0- Atras");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("Elegir uan opcion -->");
                            entrada = Console.ReadLine();
                            navCap6 = Convert.ToInt32(entrada);
                            switch (navCap6)
                            {
                                case 1:
                                break;
                                default:
                                    System.Console.Clear();
                                    break;

                            }
                            break;
                        //CAPITULO 7
                        case 3:
                            System.Console.Clear();
                            Console.WriteLine("1- Hacer el programa que calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList.");
                            Console.WriteLine("2- Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.");
                            Console.WriteLine("3- Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico.");
                            Console.WriteLine("0- Atras");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("Elegir una opcion --> ");
                            entrada = Console.ReadLine();
                            navCap7 = Convert.ToInt32(entrada);
                            switch (navCap7)
                            {
                                case 1:
                                    
                                    break;
                                case 2:
                                    
                                    break;
                                case 3:
                                    

                                    break;
                                default:
                                    System.Console.Clear();
                                    break;
                            }
                            break;
                        //CAPITULO 8
                        case 4:
                            System.Console.Clear();
                            Console.WriteLine("1- Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.");
                            Console.WriteLine("2- Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.");
                            Console.WriteLine("0- Atras");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.Write("Elegir una opcion --> ");
                            entrada = Console.ReadLine();
                            navCap8 = Convert.ToInt32(entrada);
                            switch (navCap8)
                            {
                                case 1:
                                    

                                    break;
                                case 2:
                                   
                                   
                                    break;
                                default:
                                    System.Console.Clear();
                                    break;
                            }
                            break;
                        //CASO SALIR
                        default:
                            System.Console.Clear();
                            Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA :) ");
                            break;

                    }

                } while (nav != 0);
            }
        }



    }


