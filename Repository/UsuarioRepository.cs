
using api_myProjet.DataBase;
using api_myProjet.model;

namespace api_myProjet.Repository
{
  public class UsuarioRepository : IUsuarioRepository
  {
    // injetar depedencia do contexto

    private readonly UsuarioDbContext _context;

    public UsuarioRepository(UsuarioDbContext context) {
        _context = context;
    }

    public void AddUsuario(Usuario usuario)
    {
      _context.Add(usuario);
    }

    public void AtualizarUsuario(Usuario usuario)
    {
      throw new NotImplementedException();
    }

    public void DeletarUsuario(Usuario usuario)
    {
      throw new NotImplementedException();
    }

    public Task<Usuario> GetUsuarioById(int id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Usuario>> GetUsuarios()
    {
      throw new NotImplementedException();
    }

    public async Task<bool> SaveChangesAsync()
    {
      return await _context.SaveChangesAsync() > 0;
    }
  }
}