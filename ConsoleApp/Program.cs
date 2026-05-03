// See https://aka.ms/new-console-template for more information

using AccesoDatos.Operaciones;

AlumnoDAO opaAlumno = new AlumnoDAO();


//opaAlumno.insertar("20241185", "Rigoberto sanchez", "Calle azul", 20, "20243ds185@utez.edu.mx");
//opaAlumno.actualizar(1005, "20241185", "Luis angel","Calle del diablo",25,"20243gmail.com");
opaAlumno.eliminar(1005);
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

Console.WriteLine("##############################");

var alumnosasig = opaAlumno.seleccionarAlumnosAsignaturas();

foreach (var alumnoasig in alumnosasig)
{
    Console.WriteLine(alumnoasig.NombreAlumno + " - " + alumnoasig.NombreAsignatura);
}

