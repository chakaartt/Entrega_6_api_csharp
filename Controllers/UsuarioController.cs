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

        [HttpGet("{id}")]
       public async Task<IActionResult> GetAll(int id){
            var usuario = await _Repository.GetUsuarioById(id);

            return usuario != null 
            ? Ok(usuario) : NotFound("Usuário ão encontrado.");
       } 
        [HttpGet]
       public async Task<IActionResult> GetById(){
            var usuarios = await _Repository.GetUsuarios();

            return usuarios.Any() ? Ok(usuarios) : NoContent();
       } 
        [HttpPost]
       public async  Task<IActionResult> Post(Usuario usuario){
            _Repository.AddUsuario(usuario);

            return await _Repository.SaveChangesAsync() 
            ? Ok("usuário adicinado.") : BadRequest("Algum deu errado.");
       } 

       [HttpPut("{id}")]
       public async Task<IActionResult> atualizar(int id, Usuario usuario){
            var UsuarioExiste = await _Repository.GetUsuarioById(id);

            if(UsuarioExiste == null) return NotFound("Usuario não encontrado.");

            UsuarioExiste.Nome = usuario.Nome ?? UsuarioExiste.Nome;
            UsuarioExiste.DataNascimento = usuario.DataNascimento != new DateTime() 
            ? usuario.DataNascimento : UsuarioExiste.DataNascimento;

            _Repository.AtualizarUsuario(UsuarioExiste);

            return await _Repository.SaveChangesAsync() 
            ? Ok("usuário atualizado.") : BadRequest("Algum deu errado.");
       }

       [HttpDelete("{id}")]
       public async Task<IActionResult> Delete(int id) {
            var UsuarioExiste = await _Repository.GetUsuarioById(id);
            if(UsuarioExiste == null) 
            return NotFound("Usuario não encontrado.");

            _Repository.DeletarUsuario(UsuarioExiste);

            return await _Repository.SaveChangesAsync() 
            ? Ok("usuário atualizado.") : BadRequest("Algum deu errado.");
       }
    }
}