using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoBase.Domain;
using ProjetoBase.Extensions.Common;
using ProjetoBase.Service.Interfaces;
using ProjetoBase.ViewModel.Setor;
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
            if (!ModelState.IsValid)
                return Json(new { MensagemErro = ModelState.DisplayErros() });

            Setor setor = Mapper.Map<Setor>(viewModel);

            List<StatusValidacaoEnum> status = _setorService.ValidaSetor(setor);

            if (status.Count > 0)
                return Json(new { MensagemErro = status.DisplayDescriptionsToViewModel() });

            if (_setorService.Insert(setor))
                return Json(new { MensagemSucesso = "Setor incluso com sucesso" });
            else
                return Json(new { MensagemErro = "Erro ao adicionar setor" });
        }

        [HttpGet]
        public IActionResult CarregaUpdate(int id)
        {
            Setor setor = _setorService.SelectById(id);

            if (setor == null)
                return PartialView("_Create");

            UpdateSetorViewModel viewModel = Mapper.Map<UpdateSetorViewModel>(setor);

            return PartialView("_Update", viewModel);
        }

        [HttpPost]
        public IActionResult Update(UpdateSetorViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return Json(new { MensagemErro = ModelState.DisplayErros() });

            Setor setor = Mapper.Map<Setor>(viewModel);

            List<StatusValidacaoEnum> status = _setorService.ValidaSetor(setor);

            if (status.Count > 0)
                return Json(new { MensagemErro = status.DisplayDescriptionsToViewModel() });

            if (_setorService.Update(setor))
                return Json(new { MensagemSucesso = "Setor atualizado com sucesso" });
            else
                return Json(new { MensagemErro = "Erro ao atualizar setor" });
        }

        [HttpGet]
        public IActionResult Lista()
        {
            List<ViewSetorViewModel> viewModels = Mapper.Map<List<ViewSetorViewModel>>(_setorService.Select());
            return PartialView("_Lista", viewModels);
        }
    }
}