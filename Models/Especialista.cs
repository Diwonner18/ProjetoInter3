using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoInter03.Models
{
    public class Especialista
    {
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int EspecialistaId { get; set; }

        public string Especialidade { get; set; }

        public int Registro { get; set; }

        public int ConsultorioId { get; set; }
        public Consultorio Consultorio { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Consulta> Consulta { get; set; }
    }
}