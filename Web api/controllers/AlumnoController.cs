using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;

namespace Web_api.controllers;

[Route("api")]
[ApiController]
public class AlumnoController : ControllerBase
{
    private AlumnoDAO alumnoDAO = new AlumnoDAO();
    
    [HttpGet("alumnosProfesor")]
    
    
}