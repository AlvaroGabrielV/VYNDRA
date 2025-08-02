using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA.Classes
{
    public static class UsuarioSession
    {
        private static Dictionary<int, string> _usuarios = new Dictionary<int, string>();

        public static void AdicionarUsuario(int id, string usuario)
        {
            if (!_usuarios.ContainsKey(id))
            {
                _usuarios.Add(id, usuario);
            }
        }

        public static string ObterUsuario(int id)
        {
            if (_usuarios.ContainsKey(id))
            {
                return _usuarios[id];
            }
            return null;  // Retorna null se o usuário não estiver presente
        }
    }

}
