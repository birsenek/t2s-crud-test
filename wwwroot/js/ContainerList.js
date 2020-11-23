var dataTable;

$(document).ready(function () {
    loadDataTable()
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/container",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "cliente", "width": "20%" },
            { "data": "numeroContainer", "width": "20%" },
            { "data": "tipo", "width": "20%" },
            { "data": "status", "width": "20%" },
            { "data": "categoria", "width": "20%" }     
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}

