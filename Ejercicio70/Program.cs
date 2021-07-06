using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio70
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreAlumno, mejorAlumno=null, peorAlumno = null;
            double promedioAlumno, mejorPromedio, peorPromedio, mediaPromedio=0;
            int cantidadAprobados = 0, cantidadDesaprobados=0;
            int cantidadX;
            int nota;
            #region Ingreso de la cantidad de alumnos
            do
            {
                Console.Write("Ingrese la cantidad de alumnos:");
                if (!int.TryParse(Console.ReadLine(), out cantidadX))
                {
                    Console.WriteLine("ERROR: Número mal ingresado");
                }
                else if(cantidadX<=0)
                {
                    Console.WriteLine("ERROR: La cantidad debe ser superior a 0");
                }
                else
                {
                    break;
                }
                
            } while (true);
            #endregion
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);//Demora la ejecución del proceso
            mejorPromedio = 0;
            peorPromedio = 11;
            #region Ciclo para ingresar los alumnos y sus notas
            for (int contadorAlumnos = 0; contadorAlumnos < cantidadX; contadorAlumnos++)
            {
                Console.Clear();//Limpia la consola
                #region Ciclo para controlar si se ingresó un alumno válido
                do
                {
                    Console.Write($"Ingrese el nombre del alumno nro {contadorAlumnos + 1}:");
                    nombreAlumno = Console.ReadLine();
                    //TODO:Ver un método para controlar que no se haya ingresado un nro
                    if (!string.IsNullOrEmpty(nombreAlumno) && !string.IsNullOrWhiteSpace(nombreAlumno))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El nombre del alumno es requerido");
                    }
                } while (true);
                #endregion
                
                promedioAlumno = 0;//Variable para almacenar y calcular el promedio del alumno

                #region Ciclo para el ingreso de las notas
                for (int contadorNotas = 1; contadorNotas <= 3; contadorNotas++)
                {
                    do
                    {
                        Console.Write($"Ingrese la nota {contadorNotas}:");
                        if (!int.TryParse(Console.ReadLine(), out nota))
                        {
                            Console.WriteLine("ERROR: Nota no válida o mal ingresada");
                        }else if (nota<1 || nota>10)
                        {
                            Console.WriteLine("ERROR: La nota debe estar comprendida entre 1 y 10");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                    promedioAlumno+= nota;// promedioAlumno=promedioAlumno+nota

                }
                #endregion

                promedioAlumno/=3;
                Console.WriteLine($"{nombreAlumno} su promedio es {promedioAlumno}");
                if (promedioAlumno>=7)
                {
                    Console.WriteLine("Alumno aprobado");
                    cantidadAprobados++;
                }
                else
                {
                    Console.WriteLine("Alumno desaprobado");
                    cantidadDesaprobados++;
                }

                mediaPromedio+=promedioAlumno;
                if (promedioAlumno>mejorPromedio)
                {
                    mejorPromedio = promedioAlumno;
                    mejorAlumno = nombreAlumno;
                }

                if (promedioAlumno<peorPromedio)
                {
                    peorPromedio = promedioAlumno;
                    peorAlumno = nombreAlumno;
                }
                //TODO:Ver otra forma de delay
                Console.Write("Presione ENTER para continuar");
                Console.ReadLine();//Presionar ENTER para continuar
            }
            #endregion
            Console.WriteLine($"Cantidad de alumnos aprobados...:{cantidadAprobados}");
            Console.WriteLine($"Cantidad de alumnos desaprobados:{cantidadDesaprobados}");
            Console.WriteLine($"Media de promedios..............:{mediaPromedio/cantidadX}");
            Console.WriteLine($"El mejor alumno es {mejorAlumno} y su promedio es {mejorPromedio}");
            Console.WriteLine($"El peor alumno es {peorAlumno} y su promedio es {peorPromedio}");
            Console.ReadLine();

        }
	}
}
