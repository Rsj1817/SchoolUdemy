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

    public bool actualizar(int id, String dni, String nombre, String direccion, int edad, String email)
    {
        try
        {
            var alumno = seleccionar(id);
            if (alumno == null)
            {
                return false;
            }
            else
            {
                alumno.Dni = dni;
                alumno.Nombre = nombre;
                alumno.Direccion = direccion;
                alumno.Edad = edad;
                alumno.Email = email;
                contexto.SaveChanges();
            }
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public bool eliminar(int id)
    {
        try
        {
            var alumno = seleccionar(id);
            
            if (alumno == null)
            {
                return false;
            }
            else
            {
                contexto.Alumnos.Remove(alumno);
                contexto.SaveChanges();
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
     
    }

    public List<AlumnoAsignatura> seleccionarAlumnosAsignaturas()
    {
        var query = from a in contexto.Alumnos
            join m in contexto.Matriculas on a.Id equals m.AlumnoId
            join asig in contexto.Asignaturas on m.AsignaturaId equals asig.Id
            select new AlumnoAsignatura
            {
                NombreAlumno = a.Nombre,
                NombreAsignatura = asig.Nombre
            };
        return query.ToList();
    }

    public List<AlumnoProfesor> seleccionarAlumnosProfesor(String usuario)
    {
        var query = from a in contexto.Alumnos
            join m in contexto.Matriculas on a.Id equals m.AlumnoId
            join asig in contexto.Asignaturas on m.AsignaturaId equals asig.Id
            where asig.Profesor == usuario
            select new AlumnoProfesor
            {
                Id = a.Id,
                Dni = a.Dni,
                Nombre = a.Nombre,
                Direccion = a.Direccion,
                Edad = a.Edad,
                Email = a.Email,
                Asignatura = asig.Nombre
            };
        return query.ToList();
    }
   
    
}