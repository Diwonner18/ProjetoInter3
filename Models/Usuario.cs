using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoInter03.Models
{
    public class Usuario
    {
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public String Token { get; set; }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public Especialista Especialista {get; set; }
        public Paciente Paciente { get; set; }

    }
}
