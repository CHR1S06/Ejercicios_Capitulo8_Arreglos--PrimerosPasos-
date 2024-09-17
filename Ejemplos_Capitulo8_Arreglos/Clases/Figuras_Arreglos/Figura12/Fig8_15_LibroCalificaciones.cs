using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura12
{
    public class Fig8_15_LibroCalificaciones
    {
        private string nombreCurso; //nombre del curso que representa este LibroCalificaciones 
        private int[] calificaciones; //arreglo de calificaciones de los estudiantes 

        //el constructor de dos parametros inicializa nombreCurso y el arreglo calificaciones

        public Fig8_15_LibroCalificaciones(string nombre, int[] arregloCalificaciones)
        {
            nombreCurso = nombre; //inicializa nombreCurso
            calificaciones = arregloCalificaciones; //inicializa el arreglo calificaciones 
        }//fin del constructor LibroCalificaciones con dos parametros 

        //propiedad que obtiene (get) y establece (set) el nombre del curso 
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }//fin de get
            set
            {
                nombreCurso = value;
            }//fin de set
        }//fin de la propiedad NombreCurso

        //muestra un mensaje de bienvenida al usuario de LibroCalificaciones
        public void MostrarMensaje()
        {
            //la propiedad NombreCurso obtiene el nombre del curso 
            Console.WriteLine("¡Bienvenido al libro de calificaciones para \n{0}!\n",
                NombreCurso);
        }//fin del metodo MostrarMensaje

        //realiza varias operaciones sobre los datos 
        public void ProcesarCalificaciones()
        {
            //imprime en pantalla el arreglo calificaciones 
            ImprimeCalificaciones();

            //llama al metodo ObtenerPromedio para calcular la califiacion promedio
            Console.WriteLine("\nEl promedio de la clase es {0:F2}", ObtenerPromedio());

            //llama a los metodos ObtenerMinimo y ObtenerMaximo
            Console.WriteLine("La califiacion mas baja es {0}\nLa calificacion mas alta es {1}\n",
                ObtenerMinimo(), ObtenerMaximo());

            //llama a ImprimirGraficoBarras para imprimir el grafico de distribucion de calificaciones
            ImprimirGraficoBarras();
        }//fin del metodo ProcesarCalificaciones

        //busca la calificacion minima 
        public int ObtenerMinimo()
        {
            int califBaja = calificaciones[0]; //asume que calificaciones [0] es la mas baja

            //itera a traves del arreglo califiaciones 
            foreach (int calificacion in calificaciones)
            {
                //si calificacion es menor que califBaja, la asigna a califBaja
                if (calificacion < califBaja)
                {
                    califBaja = calificacion; //nueva calificacion mas baja 
                }
            }//fin de foreach

            return califBaja; //devuelve la califiacion mas baja
        }//fin del metodo ObtenerMinimo

        //busca la calificacion maxima
        public int ObtenerMaximo()
        {
            int califAlta = calificaciones[0]; //asume que calificaciones[0] es la mas alta

            //itera a traves del arreglo calificaciones
            foreach (int calificacion in calificaciones)
            {
                //si califican es mayor que califAlta, la asigna a califAlta
                if (calificacion > califAlta)
                {
                    califAlta = calificacion; //nueva califiacion mas alta
                }
            }//fin de foreach

            return califAlta; //devuelve la calificacion mas alta
        }//fin del metodo ObtenerMaximo

        //determina la calificacion promedio para la prueba 
        public double ObtenerPromedio()
        {
            int total = 0; //inicializa el total

            //suma las calificaciones para un estudiante 
            foreach (int calificacion in calificaciones)
            {
                total += calificacion;
            }

            //devuelve el promedio de las calificaciones 
            return (double)total / calificaciones.Length;
        }//fin del metodo ObtenerPromedio

        //imprime grafico de barras que muestra la distribucion de las calificaciones 
        public void ImprimirGraficoBarras()
        {
            Console.WriteLine("Distribucion de calificaciones:");

            //almacena la frecuencia de las calificaciones en cada rango de 10 calificaciones 
            int[] frecuencia = new int[11];

            //para cada calificacion, incrementa la frecuencia apropiada
            foreach (int calificacion in calificaciones)
            {
                ++frecuencia[calificacion / 10];
            }

            //para cada frecuencia de calificaciones, imprime la barra en el grafico
            for (int cuenta = 0; cuenta < frecuencia.Length; cuenta++)
            {
                //imprime etiqueta de las barras ("00-09: ", ..., "90-99: ", "100: ")
                if (cuenta == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write("{0:D2}-{1:D2}: ",
                        cuenta * 10, cuenta * 10 + 9);
                }

                //imprime barra de asteriscos 
                for (int estrellas = 0; estrellas < frecuencia[cuenta]; estrellas++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); //inicia una nueva linea de salida 
            }//fin de for externo 
        }//fin del metodo ImprimirGraficoBarras

        //imprime el contenido del arreglo calificaciones
        public void ImprimeCalificaciones()
        {
            Console.WriteLine("Las calificaciones son:\n");

            //imprime la calificacion de cada estudiante
            for (int estudiante = 0; estudiante < calificaciones.Length; estudiante++)
            {
                Console.WriteLine("Estudiante {0,2}: {1,3}",
                    estudiante + 1, calificaciones[estudiante]);
            }
        }//fin del metodo ImprimeCalificaciones
    }//fin de la clase LibroCalificaciones
}
