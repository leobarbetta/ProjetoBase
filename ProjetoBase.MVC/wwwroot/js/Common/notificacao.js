function notificaSucesso(texto) {
    new PNotify({
        title: 'Sucesso!',
        text: texto,
        styling: "bootstrap3",
        type: 'success',
        Buttons: {
            closer: true
        }
    });
}

function notificaFalha(texto) {
    new PNotify({
        title: 'Falha!',
        text: texto,
        styling: "bootstrap3",
        type: 'error'
    });
}

function notificaInfo(texto) {
    new PNotify({
        title: 'Aviso!',
        text: texto,
        styling: "bootstrap3",
        type: 'info'
    });
}