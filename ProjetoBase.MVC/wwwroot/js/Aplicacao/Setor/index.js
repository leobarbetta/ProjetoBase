$(document).ready(function () {
    lista()
});

function createSetor() {
    baseEnviaCreate("Setores/Create", undefined, undefined, function () {
        lista();
    })
}

function updateSetor() {
    baseEnviaUpdate("Setores/Update", undefined, undefined, function () {
        lista();
    })
}

function carregaCreate() {
    escrevePreLoader("#corpoModal");
    $("#corpoModal").load("Setores/CarregaCreate");
}

function carregaUpdate(id) {
    escrevePreLoader("#corpoModal");
    $("#corpoModal").load("Setores/CarregaUpdate/" + id);
}

function lista() {
    escrevePreLoader("#lista");
    $("#lista").load("setores/lista", function () {
        carregaDataTable('#tableSetores')
    });
}