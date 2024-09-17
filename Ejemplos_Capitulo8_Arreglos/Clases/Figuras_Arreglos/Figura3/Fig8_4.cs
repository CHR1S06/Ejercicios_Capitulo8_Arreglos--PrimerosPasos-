//Fig. 8.4: InicioArreglo.cs
//Calculo de los valores a colocar en los elementos de un arreglo.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura3
{
    public class Fig8_4
    {
        public static void MenuGFig_3()
        {
            const int LONGITUD_ARREGLO = 10; //crea una constante con nombre 
            int[] arreglo = new int[LONGITUD_ARREGLO]; //crea el arreglo 

            //calcula el valor para cada elemento del arreglo 
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                arreglo[contador] = 2 + 2 * contador;
            }

            Console.WriteLine("{0}{1,8}", "Indice", "Valor"); //encabezados

            //imprime en pantalla el valor de cada elemento del arreglo 
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
            }
        }//fin de MenuFig_3
    }//fin de la clase Fig8_4
}
