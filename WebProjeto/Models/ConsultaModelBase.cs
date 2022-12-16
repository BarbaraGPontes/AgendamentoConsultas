using Microsoft.Graph;
using Org.BouncyCastle.Asn1.Cms;

namespace WebProjeto.Models
{
    public abstract class ConsultaModelBase
    {
        public abstract int id { get; set; }
        public abstract string Nome { get; set; }
        public abstract Date DataNascimento { get; set; }
        public abstract string Especialista { get; set; }
        public abstract string Especialidade { get; set; }
        public abstract Time Horario { get; set; }
        public abstract Date Data { get; set; }
    }
}