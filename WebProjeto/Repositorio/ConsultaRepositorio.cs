using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Data;
using WebProjeto.Models;

namespace WebProjeto.Repositorio
{
    public class ConsultaRepositorio : IConsultaRepositorio
    {
        //extrai variavel privada apenas p leitura, _ no começo é pq é privada
        private readonly BancoContext _bancoContext;

        //aqui injeta o contexto no repositorio conforme citado no metodo agendar abaixo
        public ConsultaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext; //recebe instancia  do bancoContext
        }

        public List<ConsultaModel> BuscarTodos()
        {
            return _bancoContext.Consultas.ToList();
        }

        public ConsultaModel Agendar(ConsultaModel consulta)
        {
            //gravar no banco de dados, contexto que grava, mas vamos injetar contexto para  dentro do repositorio

            _bancoContext.Consultas.Add(consulta);//insere no banco, mas precisa de uma autorizacao p commitar
            _bancoContext.SaveChanges();
            return consulta;
        }

        public ConsultaModel ListarPorId(int id)
        {
            return _bancoContext.Consultas.FirstOrDefault(x => x.Id == id);
        }

        public ConsultaModel Atualizar(ConsultaModel consulta)
        {
            ConsultaModel consultaDB = ListarPorId(consulta.Id);

            if (consultaDB == null) throw new Exception("Houve um erro na atualização da consulta!");

           // consultaDB.Especialista = consulta.Especialista;
            consultaDB.Horario= consulta.Horario;
            consultaDB.Data = consulta.Data;

            _bancoContext.Consultas.Update(consultaDB);
            _bancoContext.SaveChanges();

            return consultaDB;

        }

        public bool CancelarConsulta(int id)
        {
            ConsultaModel consultaDB = ListarPorId(id);

            if (consultaDB == null) throw new Exception("Houve um erro no cancelamento da consulta!");

            _bancoContext.Consultas.Remove(consultaDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
