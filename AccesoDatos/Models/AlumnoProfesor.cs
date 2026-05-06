namespace AccesoDatos.Models;

public class AlumnoProfesor
{
    public int Id { get; set; }
    public String Dni { get; set; } = null;
    public String Nombre { get; set; } = null;
    public String Direccion { get; set; } = null;
    public int Edad { get; set; }
    public String Email { get; set; } = null;
    public String Asignatura { get; set; } = null;
}