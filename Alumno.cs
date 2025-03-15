using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maestro
{
    internal class Alumno
    {
        private int n1;
        private string nombre;
        private ArrayList materias = new ArrayList();
        private ArrayList calificaciones = new ArrayList();

        public int N1 { get => n1; set => n1 = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ArrayList Materias { get => materias; set => materias = value; }
        public ArrayList Calificaciones { get => calificaciones; set => calificaciones = value; }
        public void agregarMateria(string materia)
        {
            materias.Add(materia);
        }
        public void agregarCalificacion(int calificacion)
        {
            calificaciones.Add(calificacion);
        }

    }
}
