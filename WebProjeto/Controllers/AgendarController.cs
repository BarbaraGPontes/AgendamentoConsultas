using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjeto.Models;
using WebProjeto.Repositorio;

namespace WebProjeto.Controllers
{
    public class AgendarController : Controller
    {
        private readonly IConsultaRepositorio _consultaRepositorio;

        public AgendarController(IConsultaRepositorio consultaRepositorio)
        {
            _consultaRepositorio = consultaRepositorio;
        }

        // GET: AgendarController
        public IActionResult AgendarConsulta()
        {
            return View();
        }

        public IActionResult HorarioConsulta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgendarConsulta(ConsultaModel consultas)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _consultaRepositorio.Agendar(consultas);
                    TempData["MensagemSucesso"] = "Consulta agendada com sucesso!";
                    return RedirectToAction("AgendarConsulta");
                }
                return View(consultas);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não conseguimos agendar sua consulta, tente novamente! Detalhe do erro: {erro.Message}";
                return RedirectToAction("AgendarConsulta");
            }
        }
    }
}
