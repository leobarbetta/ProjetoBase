using ProjetoBase.Domain;
using ProjetoBase.ViewModel.StatusValidacao;
using System;
using System.Collections.Generic;

namespace ProjetoBase.Extensions.Common
{
    public static class StatusValidacaoEnumExtensions
    {
        public static string DisplayDescriptionsToViewModel(this List<StatusValidacaoEnum> allStatus)
        {
            string erros = string.Empty;
            try
            {
                foreach (var item in allStatus)
                {
                    StatusValidacaoEnumViewModel status = (StatusValidacaoEnumViewModel)item;
                    erros += string.Format($"{status.DisplayDescription()} ");
                }
            }
            catch (Exception ex)
            {
                erros = "Erro ao criar mensagens de erro";
            }
            return erros;
        }

        public static string DisplayDescriptionToViewModel(this StatusValidacaoEnum st)
        {
            string erro = string.Empty;
            try
            {
                StatusValidacaoEnumViewModel status = (StatusValidacaoEnumViewModel)st;
                erro += string.Format($"{status.DisplayDescription()}");
            }
            catch (Exception ex)
            {
                erro = "Erro ao criar mensagem de erro";
            }
            return erro;
        }
    }
}
