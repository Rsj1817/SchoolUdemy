using Microsoft.AspNetCore.Mvc;

namespace Web_api.controllers;

[Route("api")]
[ApiController]
public class PruebaController : ControllerBase
{
    [HttpGet("prueba")]
    public String pruebaApi()
    {
        return "Hola desde la API";
    }
}