using maestro;

using System.Data;

Dictionary<string, string> diccionario = new Dictionary<string, string>();

Profesor p = new Profesor();
Console.WriteLine(" bienvenido ingrese su nombre: ");
p.Nombre = Console.ReadLine();
p.capturarDatosAlumno();
p.capturarMaterias();
p.capturarCalificaciones();


//mostrar datos:
Console.WriteLine("\nMostrando datos... ");
Console.WriteLine("************");
Console.WriteLine("Nombre del profesor: " + p.Nombre);
Console.WriteLine("\nDatos del alumno: ");
Console.WriteLine("Numero de lista: " + p.Alumno1.N1);
Console.WriteLine("Nombre del alumno: " + p.Alumno1.Nombre);
Console.WriteLine("\nMaterias: ");

for (int i = 0; i < p.Alumno1.Materias.Count; i++)
{
   diccionario.Add(p.Alumno1.Materias[i].ToString(), p.Alumno1.Calificaciones[i].ToString());
}

foreach (var elementos in diccionario)
{
    Console.WriteLine(elementos.ToString());
}
foreach(string clave in diccionario.Keys)
{
    Console.WriteLine(clave);
}
foreach (string valor in diccionario.Values)
{
    Console.WriteLine(valor);
}