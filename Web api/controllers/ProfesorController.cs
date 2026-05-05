using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;

namespace Web_api.controllers;
[Route("api")]
[ApiController]
public class ProfesorController : ControllerBase
{
    private ProfesorDAO profesorDAO = new ProfesorDAO();
    
    [HttpPost("autenticacion")]
    public String login([FromBody] Profesor prof)
    {
        var profesor = profesorDAO.login(prof.Usuario, prof.Pass);

        if (profesor != null)
        {
            return profesor.Usuario;
        }
        else
        {
            return null;
        }
    }
}