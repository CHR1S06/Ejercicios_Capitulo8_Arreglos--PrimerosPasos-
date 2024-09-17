//Fig. 8.7: TirarDado.cs
//Tirar 6000 veces un dado de seis lados.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura6
{
    public class Fig8_7
    {
        public static void MenuFig_6()
        {
            Random numerosAleatorios = new Random(); //generador de numeros aleatorios 
            int[] frecuencia = new int[7]; //arreglo de contadores de frecuencia 

            //tira el dado 6000 veces; usa el valor del dado como subindice de frecuencia
            for (int tiro = 1; tiro <= 6000; tiro++)
            {
                ++frecuencia[numerosAleatorios.Next(1, 7)];
            }

            Console.WriteLine("{0}{1,10}", "Cara", "Frecuencia");

            //Imprime en pantalla el valor de cada elemento del arreglo 
            for (int cara = 1; cara < frecuencia.Length; cara++)
            {
                Console.WriteLine("{0,4}{1,10}", cara, frecuencia[cara]);
            }

        }//fin de MenuFig_6
    }//fin de la clase Fig8_7
}
