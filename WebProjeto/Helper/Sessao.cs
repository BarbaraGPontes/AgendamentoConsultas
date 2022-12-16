using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Models;

namespace WebProjeto.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext) //injecao de dependencia /construtor
        {
            _httpContext = httpContext;
        }

        public UsuarioModel BuscarSessaoDoUsuario()
        {
            
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado"); //busca chave sessaoUsuarioLogado que estou procurando

            if (string.IsNullOrEmpty(sessaoUsuario)) return null; //verifica se for nulo ou vazio minha sessa retorna null

            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario); // transformar objeto, deserializar ele, para nossa usuariomodel
        }

        public void CriarSessaoDoUsuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario); //serializar objeto e tranformar em string serializada

            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor); //Converte em padrao json p entender o string

        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
