using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Models;

namespace WebProjeto.Data
{
    public class BancoContext : DbContext //herdando contexto do banco de dados, dbcontext é o construtor padrao
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)//construtor colocar mesmo nome do contexto, injetar como parametro de entrada o BdContextOptions e dentro dele tipar a propria classe BancoContext
        //info options passar para dentro do construtor ": base(options)"
        {
        }

        // colocar tabelas/ configurar entidade consultamodel
        //informar classse que representa tabela do banco de dados
        public DbSet<ConsultaModel> Consultas { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
