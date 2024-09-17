//Fig. 8.9: Carta.cs
//La clase carta representa una carta de juego.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura8
{
    public class Fig8_9_Carta
    {
        private string cara; //cara de la carta ("As", "Dos", ...)
        private string palo; //palo de la carta ("Corazones", "Diamantes", ...)

        //el constructor con dos parametros inicializa la cara y el palo de la carta 
        public Fig8_9_Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta; //inicializa la cara de la carta 
            palo = paloCarta; //inicializa el palo de la carta 
        } //fin del constructor de Carta con dos parametros 

        //devuelve representacion de cadena del objeto Carta 
        public override string ToString()
        {
            return cara + " de " + palo;
        } //fin del metodo ToString
    } //fin de la clase carta
}
