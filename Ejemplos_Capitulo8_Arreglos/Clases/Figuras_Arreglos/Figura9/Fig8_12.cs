//Fig. 8.12: PruebaForEach.cs
//Uso de la instruccion foreach para totalizar los enteros en un arreglo.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura9
{
    public class Fig8_12
    {
        public static void MenuFig_9()
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            //suma el valor de cada elemento a total 
            foreach (int numero in arreglo)
            {
                total += numero;
            }

            Console.WriteLine("Total de elementos en el arreglo: {0}", total);
        } //fin de MenuFig_9
    } //fin de la clase Fig8_12
}
