using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInter03.Models
{
    public class Paciente
    {
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int PacienteId { get; set; }

        public long numeroCartao { get; set; }

        public DateTime validade { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Consulta> Consulta { get; set; }
    }
}
