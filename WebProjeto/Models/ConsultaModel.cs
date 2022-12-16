
using System;
using System.ComponentModel.DataAnnotations;

namespace WebProjeto.Models
{
    public class ConsultaModel
    {
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public TimeSpan Horario { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public String Nome { get; set; }

        public String Especialista { get; set; }

        public String Especialidade { get; set; }

        public int Id { get; set; }
    }
}
