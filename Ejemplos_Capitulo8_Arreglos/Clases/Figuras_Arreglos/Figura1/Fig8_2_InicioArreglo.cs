//Fig. 8.2: InicioArreglo.cs
//Creacion de un arreglo.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura1
{
    public class Fig8_2_InicioArreglo
    {
        public static void MenuFig_1()
        {
            int[] arreglo; //declara un arreglo llamado arreglo 

            //crea el espacio para el arreglo y lo inicializa con ceros predeterminados
            arreglo = new int[10]; //10 elementos int

            Console.WriteLine("{0}{1,8}", "indice", "Valor"); //encabezados

            //imprime en pantalla el valor de cada elemento del arreglo 
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
            }
        }//fin de MenuFig_1
    }//fin de la clase InicioArreglo
}
