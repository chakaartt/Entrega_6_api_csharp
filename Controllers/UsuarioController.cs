using api_myProjet.model;
using api_myProjet.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_myProjet.Controllers
{
    [ApiController] 
    [Route("api/[controller]")] 

    public class UsuarioController : ControllerBase
    {   
        // injetar a depedencia do repositorio
        private readonly IUsuarioRepository _Repository;

        public UsuarioController (IUsuarioRepository repository) {
            _Repository = repository;
        }

        [HttpGet]
       public string Hello(){
            return "oi";
       } 
        [HttpGet]
       public async  Task<IActionResult> Post(Usuario usuario){
            _Repository.AddUsuario(usuario);

            return await _Repository.SaveChangesAsync() 
            ? Ok("usuário adicinado") : BadRequest("Algum deu errado.");
       } 
    }
}