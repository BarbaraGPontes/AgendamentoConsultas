using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Models;
using WebProjeto.Repositorio;

namespace WebProjeto.Controllers
{
    public class AgendadasController : Controller
    {
        private readonly IConsultaRepositorio _consultaRepositorio;

        public AgendadasController(IConsultaRepositorio consultaRepositorio)
        {
            _consultaRepositorio = consultaRepositorio;
        }
        public IActionResult Index()
        {

            List<ConsultaModel> consultas = _consultaRepositorio.BuscarTodos();

            return View(consultas);
        }

        public IActionResult Alterar(int id)
        {
            ConsultaModel consultaid = _consultaRepositorio.ListarPorId(id);

            return View(consultaid);
        }
        public IActionResult CancelarConsultaConfirmacao(int id)
        {
            ConsultaModel consultaid = _consultaRepositorio.ListarPorId(id);

            return View(consultaid);
        }

        public IActionResult CancelarConsulta(int id)
        {
            try
            {
                _consultaRepositorio.CancelarConsulta(id);
                TempData["MensagemSucesso"] = "Consulta cancelada com sucesso";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cancelar consulta, tente novamente! Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public IActionResult Alterar(ConsultaModel consultas)
        {

            try
            {
                    _consultaRepositorio.Atualizar(consultas);
                    TempData["MensagemSucesso"] = "Consulta alterada com sucesso!";
                    return RedirectToAction("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao alterar consulta, tente novamente! Detalhe do erro: {erro.Message }";

                return RedirectToAction("Index");
            }
        }
    }
}
