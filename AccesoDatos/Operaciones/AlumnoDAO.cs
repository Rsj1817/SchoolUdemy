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

}