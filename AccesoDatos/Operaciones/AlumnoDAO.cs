using AccesoDatos.Context;
using AccesoDatos.Models;

namespace AccesoDatos.Operaciones;

public class AlumnoDAO
{
    private ProyectoContext contexto = new ProyectoContext();

    public List<Alumno> SeleccionarTodos()
    {
        var alumnos= contexto.Alumnos.ToList<Alumno>();
        return alumnos;
    }

    public Alumno seleccionar(int id)
    {
        var alumno = contexto.Alumnos.Where(a => a.Id == id).FirstOrDefault();
        return alumno;
    }

    public bool insertar(String dni, String nombre, String direccion, int edad, String email)
    {
        try
        {
            Alumno alumno = new Alumno();
            alumno.Dni = dni;
            alumno.Nombre = nombre;
            alumno.Direccion = direccion;
            alumno.Edad = edad;
            alumno.Email = email;
            contexto.Alumnos.Add(alumno);
            contexto.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}