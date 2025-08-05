using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA.Classes
{
    class Sessao
    {
            public static int IdUsuario { get; set; }
            public static string NomeExibicao { get; set; }
            public static string Email { get; set; }
            public static string UsuarioLogin { get; set; }
            public static string SenhaHash { get; set; } 
            public static DateTime DataNascimento { get; set; }
            public static string Telefone { get; set; } 

            public static string Instagram { get; set; }
            public static string Linkedin { get; set; }

            public static byte[] FotoPerfil { get; set; }


        public static void Limpar()
            {
                Linkedin = null;
                Instagram = null;
                IdUsuario = 0;
                NomeExibicao = null;
                Email = null;
                UsuarioLogin = null;
                SenhaHash = null;
                DataNascimento = DateTime.MinValue;
                Telefone = null;
                FotoPerfil = null;
            }
        }
}
