using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Caso_sem7
{
    internal class Program
    {
        static int max = 180;
        static string[] nombres=new string[max];
        static double[] notas= new double[max];
        static int contador = 0;
        static public void Titulo()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Sistema de gestion de notas");
            Console.WriteLine("***************************");
        }
        static public void Registrar_estudiante()
        {
            Console.WriteLine("Registro de estudiante nuevo: ");
            if (contador >= 100)
            {
                Console.WriteLine("Alcanzo la capacidad maxima: ");
                return;
            }
            Console.WriteLine("Ingresar nombre del estudiante: ");
            string nombre= Console.ReadLine();
            double nota;
            while (true)
            {
                Console.Write("Ingresar nota[0-20]: ");
                nota=double.Parse(Console.ReadLine());
                if(nota >=0 && nota <=20)
                {
                    break;
                }
                Console.WriteLine("Error, volver a ingresar la nota[0-20]");
            }
            nombres[contador] = nombre;
            notas[contador]= nota;
            contador++;
            Console.WriteLine("¡..Registrado con exito..!");
        }
        static public void buscar_estudiante()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
