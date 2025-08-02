using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA.Classes
{
    public class PedidoAmizade
    {
        public int Id { get; set; }
        public int DeUsuario { get; set; }
        public int ParaUsuario { get; set; }
        public string Status { get; set; }
        public DateTime DataSolicitacao { get; set; }
    }

}
