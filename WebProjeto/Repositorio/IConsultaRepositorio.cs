using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Models;

namespace WebProjeto.Repositorio
{
    public interface IConsultaRepositorio
    {
        //interface, criar metodos como contrato para metodo repositorio
        //retorna o model nomeando metodo como Agendar, entre parenteses o que metodo vai fazer, o que vai agendar? 
        //adiciona  model que vai ter comonome consulta
        ConsultaModel Agendar(ConsultaModel consulta);
        List<ConsultaModel> BuscarTodos();

        ConsultaModel ListarPorId(int id);

        ConsultaModel Atualizar(ConsultaModel consulta);

        bool CancelarConsulta(int id);
    }
}
