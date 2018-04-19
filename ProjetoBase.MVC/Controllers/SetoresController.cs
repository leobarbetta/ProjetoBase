using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Domain.Entities;
using ProjetoBase.Service.Interfaces;
using ProjetoBase.ViewModel;
using System.Collections.Generic;

namespace ProjetoBase.Controllers
{
    public class SetoresController : Controller
    {
        private readonly ISetorService _setorService;
        public SetoresController(ISetorService setorService)
        {
            _setorService = setorService;
        }

        [HttpGet]
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult CarregaCreate() => PartialView("_Create");

        [HttpPost]
        public IActionResult Create(CreateSetorViewModel viewModel)
        {
            Setor setor = Mapper.Map<Setor>(viewModel);

            if (_setorService.Insert(setor))
                return Json(new { MensagemSucesso = "Setor incluso com sucesso" });
            else
                return Json(new { MensagemErro = "Erro ao adicionar setor" });
        }

        [HttpGet]
        public IActionResult Lista()
        {
            List<ViewSetorViewModel> viewModels = Mapper.Map<List<ViewSetorViewModel>>(_setorService.Select());
            return PartialView("_Lista", viewModels);
        }
    }
}