using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Models;

namespace WebProjeto.Repositorio
{
    public interface IUsuarioRepositorio
    {
        //interface, criar metodos como contrato para metodo repositorio
        //retorna o model nomeando metodo como Agendar, entre parenteses o que metodo vai fazer, o que vai agendar? 
        //adiciona  model que vai ter comonome consulta
        UsuarioModel Adicionar(UsuarioModel usuario);
        List<UsuarioModel> BuscarTodos();

        UsuarioModel BuscarPorId(int id);

        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Apagar(int id);

        UsuarioModel BuscarPorLogin(string login);
    }
}
