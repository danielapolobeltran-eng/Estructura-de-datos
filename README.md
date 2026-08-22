using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pp
{

    internal class Program
    {
        static void ImprimirCabezera(string nombreMateria, int grupo, string nombreEstudiante)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("         UNIVERSIDAD DEL CARIBE            ");
            Console.WriteLine($" Asignatura: {nombreMateria}");
            Console.WriteLine($" Grupo: {grupo}");
            Console.WriteLine($"Nombre del estudiante : {nombreEstudiante}");
            Console.WriteLine("===========================================");
            Console.writeline($"edad: {edadEstudiante}");
            console.writeline($"sexo: {sexoestudiante}");
            console.writeline($"carrera: {carreraqueestudia}");
            console.writeline($"semestre: {semestrecursando}");
        }
        public static void Main(string[] args) {
            //llamar a la procedimiento ImprimirCabezera
            ImprimirCabezera("fundamentos de Programacion", 1, "Daniela polo");

        }
    }
}

