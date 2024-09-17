//Fig. 8.13: PasoArreglo.cs
//Paso de arreglo y elementos individuales de arreglos a los metodos.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura10
{
    public class Fig8_13
    {
        //MenuFig_10 crea arreglo y llama a ModificarArreglo y ModificarElemento
        public static void MenuFig_10()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };

            Console.WriteLine(
                "Efectos de pasar una referencia a todo un arreglo:\n" +
                "Los valores del arreglo original son:");

            //imprime en pantalla elementos del arreglo original 
            foreach (int valor in arreglo)
            {
                Console.Write("  {0}", valor);
            }

            ModificarArreglo(arreglo); //pasa referencia al arreglo 
            Console.WriteLine("\n\nLos valores del arreglo modificado son:");

            //imprime en pantalla elementos modificados del arreglo 
            foreach (int valor in arreglo)
            {
                Console.Write("  {0}", valor);
            }

            Console.WriteLine(
                "\n\nEfectos de pasar el valor de un elemento del arreglo:\n" +
                "arreglo[3] antes de ModificarElemento: {0}", arreglo[3]);

            ModificarElemento(arreglo[3]); //trata de modificar arreglo[3]
            Console.WriteLine(
                "arreglo[3] despues de ModificarElemento: {0}", arreglo[3]);
        } //fin de Main

        //multipica cada elemento de un arreglo por 2
        public static void ModificarArreglo(int[] arreglo2)
        {
            for (int contador = 0; contador < arreglo2.Length; contador++)
            {
                arreglo2[contador] *= 2;
            }
        } //fin del metodo ModificarArreglo

        //multiplica el argumento por 2 
        public static void ModificarElemento(int elemento)
        {
            elemento *= 2;
            Console.WriteLine(
                "Valor del elemento en ModificarElemento: {0}", elemento);
        } //fin del metodo ModificarElemento
    } //fin de la clase Fig8_13
}
