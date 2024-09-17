//Fig. 8.6: GraficoBarras.cs
//Aplicacion para imprimir grafico de barras.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura5
{
    public class Fig8_6
    {
        public static void MenuFig_5()
        {
            int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

            Console.WriteLine("Distribucion de las calificaciones:");

            //para cada elemento del arreglo, mostrar en pantalla una barra del grafico 

            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                //muestra etiquetas de las barras ( "00-09: ", ..., "90-99: ", "100: ")
                if (contador == 10)
                {
                    Console.Write("100: ");
                }
                else
                {
                    Console.Write("{0:D2}-{1:D2}: ",
                        contador * 10, contador * 10 + 9);
                }

                //imprime barra de asteriscos 
                for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); //inicia una nueva linea de salida 
            }//fin de for externo
        }//fin de MenuFig_5
    }//fin de la clase Fig8_6
}
