//Fig. 8.3: InicioArreglo.cs
//Inicializacion de los elementos de un arreglo, mediante un iniciazador de arreglos.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura2
{
    public class Fig8_3
    {
        public static void MenuFig_2()
        {
            //la lista inicializadora especifica el valor para cada elemento 
            int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

            Console.WriteLine("{0}{1,8}", "indice", "Valor"); //encabezados 

            //imprime en pantalla el valor de cada elemento del arreglo 
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
            }
        }//fin de MenuFig_2
    }//fin de la clase Fig8_3
}
