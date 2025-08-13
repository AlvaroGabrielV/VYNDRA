using System;
using System.Collections.Generic;

namespace VYNDRA.Classes
{
    public static class StatusUsuarios
    {
        public static event Action<int> UsuarioFicouOnline;
        public static event Action<int> UsuarioFicouOffline;

        private static HashSet<int> usuariosOnline = new HashSet<int>();

        public static bool EstaOnline(int idUsuario)
        {
            return usuariosOnline.Contains(idUsuario);
        }

        public static void SetOnline(int idUsuario)
        {
            if (usuariosOnline.Add(idUsuario))
            {
                UsuarioFicouOnline?.Invoke(idUsuario);
            }
        }

        public static void SetOffline(int idUsuario)
        {
            if (usuariosOnline.Remove(idUsuario))
            {
                UsuarioFicouOffline?.Invoke(idUsuario);
            }
        }
    }
}
