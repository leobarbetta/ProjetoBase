function baseEnviaCreate(url, textoBotao, fechaModel, callback) {
    var objeto = $("#formCreate").serialize();
    var botao = $("#btnCreate");
    desabilitarBotao(botao);
    $.ajax({
        url: url,
        type: "POST",
        data: objeto,
        datatype: "json",
        success: function (data) {

            if (textoBotao == undefined)
                habilitarBotao(botao, 'Adicionar');
            else
                habilitarBotao(botao, textoBotao);

            if (data.MensagemSucesso != undefined) {
                notificaSucesso(data.MensagemSucesso)
                $("#formularios").html("");


                if (fechaModel == undefined || fechaModel == false)
                    $('#myModal').modal('hide')

                if (callback != undefined)
                    callback(data);

            } else {
                notificaFalha(data.MensagemErro)
            }
        }
    });
}

function baseEnviaUpdate(url, textoBotao, fechaModel, callback) {
    var objeto = $("#formUpdate").serialize();
    var botao = $("#btnUpdate");
    desabilitarBotao(botao);
    $.ajax({
        url: url,
        type: "POST",
        data: objeto,
        datatype: "json",
        success: function (data) {

            if (textoBotao == undefined)
                habilitarBotao(botao, 'Adicionar');
            else
                habilitarBotao(botao, textoBotao);

            if (data.MensagemSucesso != undefined) {
                notificaSucesso(data.MensagemSucesso)
                $("#formularios").html("");


                if (fechaModel == undefined || fechaModel == false)
                    $('#myModal').modal('hide')

                if (callback != undefined)
                    callback(data);

            } else {
                notificaFalha(data.MensagemErro)
            }
        }
    });
}