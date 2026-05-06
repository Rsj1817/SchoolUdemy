using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;

namespace Web_api.controllers;

[Route("api")]
[ApiController]
public class AlumnoController : ControllerBase
{
    private AlumnoDAO alumnoDAO = new AlumnoDAO();
    
    [HttpGet("alumnosProfesor")]
    public List<AlumnoProfesor> alumnosProfesor(String usuario)
    {
        return alumnoDAO.seleccionarAlumnosProfesor(usuario);
    }
    
    [HttpGet("alumno")]
    public Alumno getAlumno(int id)
    {
        return alumnoDAO.seleccionar(id);
    }
    
    
}