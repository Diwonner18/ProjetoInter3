using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInter03.Models
{
    public class Consulta
    {
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        
        public int ConsultaId { get; set; }

        public DateTime Data { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public int EspecialistaId { get; set; }
        public Especialista Especialista { get; set; }
    }
}
