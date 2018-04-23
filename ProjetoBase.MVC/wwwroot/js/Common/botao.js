function desabilitarBotao(botao) {
    botao.attr('disabled', 'disabled');
    botao.html('Enviando...');
}

function habilitarBotao(botao, textoBotao) {
    botao.removeAttr('disabled');
    botao.html(textoBotao);
}