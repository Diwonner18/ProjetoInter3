using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoInter03.Models
{
    public class Consultorio
    {
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ConsultorioId { get; set; }

        public string NomeConsultorio { get; set; }

        public string Rua { get; set; }
        
        public int Numero { get; set; }

        public string Complemento { get; set; }

        public int Cep { get; set; }
    }
}