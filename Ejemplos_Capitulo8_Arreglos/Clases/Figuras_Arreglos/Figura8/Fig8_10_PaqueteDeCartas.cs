//Fig. 8.10: PaqueteDeCartas.cs
//La clase PaqueteDeCartas representa un paquete de cartas del juego.
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura8
{
    public class Fig8_10_PaqueteDeCartas
    {
        private Fig8_9_Carta[] paquete; //arreglo de objetos Carta
        private int cartaActual; //subindice de la siguiente Carta a repartir 
        private const int NUMERO_DE_CARTAS = 52; //constante para el numero de objetos Carta
        private Random numerosAleatorios; //generador de numeros aleatorios 

        //el constructor llena el paquete de objetos Carta
        public Fig8_10_PaqueteDeCartas()
        {
            string[] caras = {"As", "Dos", "Tres", "Cuatro", "Cinco", "Seis",
            "Siete", "Ocho", "Nueve", "Diez", "Joto", "Quina", "Rey"};
            string[] palos = { "Corazones", "Diamantes", "Treboles", "Espadas" };

            paquete = new Fig8_9_Carta[NUMERO_DE_CARTAS]; //crea un arreglo de objetos Carta 
            cartaActual = 0; //establece cartaActual para que la primera carta repartida sea paquete[0]
            numerosAleatorios = new Random(); //crea el generador de numeros aleatorios 

            //llena el paquete con objetos Carta
            for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
            {
                paquete[cuenta] =
                    new Fig8_9_Carta(caras[cuenta % 13], palos[cuenta / 13]);
            }
        } //fin del constructor PaqueteDeCartas

        //barajar el paquete de objetos Carta con un algoritmo de una pasada
        public void Barajar()
        {
            //despues de barajar, la reparticion debe empezar otra vez en paquete[0]
            cartaActual = 0; //reinicializa cartaActual

            //para cada Carta, selecciona otra Carta aleatoria y las intercambia 
            for (int primera = 0; primera < paquete.Length; primera++)
            {
                //selecciona un numero aleatorio entre 0 y 51
                int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);

                //intercambia la Carta actual con la Carta seleccionada al azar 
                Fig8_9_Carta temp = paquete[primera];
                paquete[primera] = paquete[segunda];
                paquete[segunda] = temp;
            } //fin de for 
        } //fin del metodo Barajar 

        //reparte una Carta 
        public Fig8_9_Carta RepartirCarta()
        {
            //determina si hay objetos Carta por repartir 
            if (cartaActual < paquete.Length)
            {
                return paquete[cartaActual++]; //devuelve la Carta actual en el arreglo 
            }
            else
            {
                return null; //devuelve null para indicar que se repartieron todos los objetos Carta
            }
        } //fin del metodo RepartirCarta
    } //fin de la clase PaqueteDeCartas
}
