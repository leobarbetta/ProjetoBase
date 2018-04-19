using System.ComponentModel;

namespace ProjetoBase.ViewModel
{
    public class ViewSetorViewModel
    {
        public int SetorId { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Sigla")]
        public string Sigla { get; set; }

        [DisplayName("Está ativo?")]
        public bool IsAtivo { get; set; }
    }
}
