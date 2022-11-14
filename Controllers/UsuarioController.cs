using Microsoft.AspNetCore.Mvc;

namespace api_myProjet.Controllers
{
    [ApiController] 
    [Route("api/[controller]")] 

    public class UsuarioController : ControllerBase
    {   
        [HttpGet]
       public string Hello(){
            return "oi";
       } 
    }
}