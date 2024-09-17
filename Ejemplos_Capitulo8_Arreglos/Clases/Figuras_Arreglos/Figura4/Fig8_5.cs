//Fig. 8.5: SumaArreglo.cs
//Calculo de la suma de los elementos de un arreglo.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura4
{
    public class Fig8_5
    {
        public static void MenuFig_4()
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            //sumar el valor de cada elemento al total 
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                total += arreglo[contador];
            }

            Console.WriteLine("Total de los elementos del arreglo: {0}", total);
        }//fin de MenuFig_4
    }//Fin de la clase Fig8_5
}
