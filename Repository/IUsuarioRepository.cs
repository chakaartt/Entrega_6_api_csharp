using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_myProjet.model;

namespace api_myProjet.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioById(int id);

        void AddUsuario(Usuario usuario);
        void AtualizarUsuario(Usuario usuario);
        void DeletarUsuario(Usuario usuario);

        Task<bool> SaveChangesAsync();
    }
}