using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYNDRA.Classes
{
    public class MensagemPrivada
    {
        public int Id { get; set; }
        public int RemetenteId { get; set; }
        public int DestinatarioId { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }
    }
}
