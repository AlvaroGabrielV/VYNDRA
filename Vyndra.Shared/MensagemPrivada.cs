using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VYNDRA.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Vyndra.Shared
{
    public class MensagemPrivada
    {
        public int Id { get; set; }
        public int RemetenteId { get; set; }
        public int DestinatarioId { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
    }

}
