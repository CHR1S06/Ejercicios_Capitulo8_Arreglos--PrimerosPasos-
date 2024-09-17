using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura1;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura10;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura11;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura12;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura2;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura3;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura4;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura5;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura6;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura7;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura8;
using Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura9;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases
{
    public class Menu
    {
        // Variable para almacenar la respuesta del usuario en el menú
        private int RespuestaMenu;

        // Método principal para mostrar el menú y ejecutar las opciones seleccionadas
        public void MenuProgram()
        {
            // Limpiamos la consola y mostramos un mensaje de bienvenida y las opciones del menú
            Console.Clear();
            Console.WriteLine(@"Bienvenido al programa Arreglos

1- (Figura 1) Inicio Arreglo.
2- (Figura 2) Inicializador de los elementos de un arreglo.
3- (Figura 3) Calculo de los valores en los elementos de un arreglo.
4- (Figura 4) Suma de los elementos de un arreglo.
5- (Figura 5) Impresion de grafico de barras.
6- (Figura 6) Tirada de un dado de seis lados 6000 veces.
7- (Figura 7) Analizadora de encuesta.
8- (Figura 8) Barajar y Repartir Paquete de cartas.
9- (Figura 9) Uso foreach para totalizar los enteros de un arreglo.
10- (Figura 10) Paso de arreglos y elementos de arreglos a los metodos.
11- (Figura 11) Paso de arreglos por valor y por referencia.
12- (Figura 12) Libro de calificaciones.
13- Salir del programa");

            // Solicitamos al usuario que ingrese su opción
            Console.Write("\nDigite su respuesta aquí: ");

            // Bucle que controla la selección válida del menú
            while (true)
            {
                try
                {
                    // Convertimos la entrada del usuario a entero
                    RespuestaMenu = Convert.ToInt32(Console.ReadLine());

                    // Verificamos si la respuesta está dentro del rango de opciones del menú
                    if (RespuestaMenu >= 1 && RespuestaMenu <= 12)
                    {
                        // Ejecutamos la acción correspondiente a la opción seleccionada
                        switch (RespuestaMenu)
                        {
                            // Opción 1: Ejecuta la aplicación (Creacion de un arreglo)
                            case 1:
                                Console.Clear(); //Limpia la consola
                                Fig8_2_InicioArreglo.MenuFig_1(); // Llamada al método principal de la figura 1
                                break;

                            // Opción 2: Ejecuta la aplicación (Inicializador de los elementos de un arreglo)
                            case 2:
                                Console.Clear(); //Limpia la consola
                                Fig8_3.MenuFig_2(); // Llamada al método principal de la figura 2
                                break;

                            // Opción 3: Ejecuta la aplicación (Calculo de los valores en los elementos de un arreglo)
                            case 3:
                                Console.Clear();
                                Fig8_4.MenuGFig_3(); // Llamada al método principal de la figura 3
                                break;

                            // Opción 4: Ejecuta la aplicación (Suma de los elementos de un arreglo)
                            case 4:
                                Console.Clear(); //Limpia la consola
                                Fig8_5.MenuFig_4(); // Llamada al método principal de la figura 4
                                break;

                            // Opción 5: Ejecuta la aplicación (Impresion de grafico de barras)
                            case 5:
                                Console.Clear(); //Limpia la consola
                                Fig8_6.MenuFig_5(); // Llamada al método principal de la figura 5
                                break;

                            // Opción 6: Ejecuta la aplicación (Tirada de un dado de seis lados 6000 veces)
                            case 6:
                                Console.Clear(); //Limpia la consola
                                Fig8_7.MenuFig_6(); // Llamada al método principal de la figura 6
                                break;

                            // Opción 7: Ejecuta la aplicación (Analizadora de encuesta)
                            case 7:
                                Console.Clear(); //Limpia la consola
                                Fig8_8.MenuFig_7(); // Llamada al método principal de la figura 7
                                break;

                            // Opción 8: Ejecuta la aplicación (Barajar y Repartir Paquete de cartas)
                            case 8:
                                Console.Clear(); //Limpia la consola
                                Fig8_11_PruebaPaqueteDeCartas.MenuFig_8(); // Llamada al método principal de la figura 8
                                break;

                            // Opción 9: Ejecuta la aplicación (Uso foreach para totalizar los enteros de un arreglo)
                            case 9:
                                Console.Clear(); //Limpia la consola
                                Fig8_12.MenuFig_9(); // Llamada al método principal de la figura 9
                                break;

                            // Opción 10: Ejecuta la aplicación (Paso de arreglos y elementos de arreglos a los metodos)
                            case 10:
                                Console.Clear(); //Limpia la consola
                                Fig8_13.MenuFig_10(); // Llamada al método principal de la figura 10
                                break;

                            // Opción 11: Ejecuta la aplicación (Paso de arreglos por valor y por referencia)
                            case 11:
                                Console.Clear(); //Limpia la consola
                                Fig8_14.MenuFig_11(); // Llamada al método principal de la figura 11
                                break;

                            // Opción 12: Ejecuta la aplicación (Libro de calificaciones)
                            case 12:
                                Console.Clear(); //Limpia la consola
                                Fig8_16_GradeBookTest.MenuFig_12(); // Llamada al método principal de la figura 12
                                break;

                            // Opción 13: Salir del programa
                            case 13:
                                return; //sale del programa
                        }

                        // Rompe el bucle si se seleccionó una opción válida y se ejecutó la acción
                        break;
                    }
                    else
                    {
                        // Mensaje si el usuario ingresó un número fuera del rango
                        Console.WriteLine("Por favor limítese a digitar uno de los números mostrados en pantalla");
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre una excepción (como ingreso inválido), mostramos el mensaje de error
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
