// See https://aka.ms/new-console-template for more information

using AccesoDatos.Operaciones;

AlumnoDAO opaAlumno = new AlumnoDAO();

var alumnos = opaAlumno.SeleccionarTodos();

foreach (var alumno in alumnos)
{
    Console.WriteLine(alumno.Nombre);
}

Console.WriteLine("###############################");

var alumnoa = opaAlumno.seleccionar(1);
if (alumnoa != null)
{
   Console.WriteLine(alumnoa.Nombre);
}

