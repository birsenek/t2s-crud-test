var dataTable;

    $(document).ready(function () {
        loadDataTable()
    });
  
    function loadDataTable() {
        dataTable = $('#DT_load').DataTable({
            "ajax": {
                "url": "/api/movimentacao",
                "type": "GET",
                "datatype": "json"
            },
            "columns": [
                { "data": "navio", "width": "25%" },
                { "data": "tipoMovimentacao", "width": "25%" },
                {"data": "dataInicio", "width": "25%"},
                { "data": "dataFim", "width": "25%" }
            ],
            "language": {
                "emptyTable": "no data found"
            },
            "width": "100%"
        });

  
    }