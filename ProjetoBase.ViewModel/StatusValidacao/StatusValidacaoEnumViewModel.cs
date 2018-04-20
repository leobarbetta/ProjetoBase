using System.ComponentModel;

namespace ProjetoBase.ViewModel.StatusValidacao
{
    public enum StatusValidacaoEnumViewModel
    {
        [Description("Sucesso")]
        Sucesso = 1,

        [Description("Erro interno do servidor, favor contatar o administrador")]
        ErroInterno = 2,

        [Description("Você já tem um item com esse nome cadastrado")]
        NomeExistente = 3,

        [Description("Você já tem um item com essa sigla cadastrada")]
        SiglaExistente = 4
    }
}
