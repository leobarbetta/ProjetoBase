using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBase.ViewModel.Setor
{
    public class CreateSetorViewModel
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [DisplayName("Sigla")]
        [Required(ErrorMessage = "O campo Sigla é obrigatório")]
        public string Sigla { get; set; }

        [DisplayName("Está ativo?")]
        public bool IsAtivo { get; set; }
    }
}
