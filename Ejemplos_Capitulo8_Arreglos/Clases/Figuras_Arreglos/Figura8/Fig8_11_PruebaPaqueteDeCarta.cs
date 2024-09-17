//Fig. 8.11: PruebaPaqueteDeCartas.cs
//Aplicacion para barajar y repartir cartas.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura8
{
    public class Fig8_11_PruebaPaqueteDeCartas
    {
        //ejecuta la aplicacion 
        public static void MenuFig_8()
        {
            Fig8_10_PaqueteDeCartas miFig8_10_PaqueteDeCartas = new Fig8_10_PaqueteDeCartas();
            miFig8_10_PaqueteDeCartas.Barajar(); //coloca las cartas en orden aleatorio 

            //imprime las 52 cartas en el orden en el que reparten 
            for (int i = 0; i < 13; i++)
            {
                //reparte e imprime 4 objetos Carta
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",
                    miFig8_10_PaqueteDeCartas.RepartirCarta(), miFig8_10_PaqueteDeCartas.RepartirCarta(),
                    miFig8_10_PaqueteDeCartas.RepartirCarta(), miFig8_10_PaqueteDeCartas.RepartirCarta());
            } //Fin de for 
        } //Fin de MenuFig_8
    } //fin de la clase PruebaPqueteDeCartas
}
