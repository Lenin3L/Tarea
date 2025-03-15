using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maestro
{
    internal class Profesor
    {
        private string nombre;
        private Alumno alumno1=new Alumno();

        public string Nombre { get => nombre; set => nombre = value; }
        internal Alumno Alumno1 { get => alumno1; set => alumno1 = value; }
        public void capturarDatosAlumno()
        {
            string nombre;
            int n1;
            Console.WriteLine(" Imgrese Nl: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ingrese nombre: ");
            nombre = Console.ReadLine();
            alumno1.N1 = n1;
            alumno1.Nombre = nombre;
        }
        public void capturarMaterias()
        {
            string materia;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese materia: ");
                materia = Console.ReadLine();
                alumno1.agregarMateria(materia);
            }
        }
        public void capturarCalificaciones()
        {
            int calificacion;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese calificacion: " + alumno1.Materias[i]);
                calificacion = Convert.ToInt32(Console.ReadLine());
                alumno1.agregarCalificacion(calificacion);
            }
        }
    }
}
