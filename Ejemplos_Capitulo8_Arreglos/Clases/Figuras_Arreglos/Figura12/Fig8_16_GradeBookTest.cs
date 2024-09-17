//Fig. 8.16: PruebaLibroCalificaciones.cs
//Crea objeto LibroCalificaciones que utiliza un arreglo de calificaciones
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos_Capitulo8_Arreglos.Clases.Figuras_Arreglos.Figura12
{
    public class Fig8_16_GradeBookTest
    {
        //El metodo MenuFig_12 comienza la ejecucion de la aplicacion
        public static void MenuFig_12()
        {
            //arreglo unidimensional de calificaciones de estudiantes
            int[] arregloCalificaciones = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

            Fig8_15_LibroCalificaciones miLibroCalificaciones = new Fig8_15_LibroCalificaciones(
                "CS101 Introduccion a la programacion en C#", arregloCalificaciones);
            miLibroCalificaciones.MostrarMensaje();
            miLibroCalificaciones.ProcesarCalificaciones();
        }
    }
}
