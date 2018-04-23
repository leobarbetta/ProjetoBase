function carregaDataTable(id) {
    return $(document).ready(function () {
        $(id).DataTable({
            "language": {
                "paginate": {
                    "first": "Primeiro",
                    "last": "Último",
                    "next": "Pr&#243;ximo",
                    "previous": "Anterior"
                },
                "search": "Busque:",
                "info": "",
                "lengthMenu": "Exibindo _MENU_ registros",
            },
            "lengthMenu": [[15, 50, 100, -1], [15, 50, 100, "Todos"]]
        });
    });
}