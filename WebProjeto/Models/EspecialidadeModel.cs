using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjeto.Models
{
    public class EspecialidadeModel
    {
        [Key]
        public int Id_Especialidade { get; set; }
        public String Nome_Especialidade { get; set; }
       

    }
}
