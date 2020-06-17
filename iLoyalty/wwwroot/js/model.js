var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/DashBoard/predict/",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "16%" },
            { "data": "address", "width": "16%" },
            { "data": "phone_number", "width": "16%" },
            { "data": "email", "width": "16%" },
            { "data": "predicted_churn", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                    <a href="#" class='btn btn-success text-white p-1' style='cursor:pointer; width:80px;'> EMAIL</a>
                    <a href="#" class='btn btn-info text-white p-1' style='cursor:pointer; width:80px;'>SMS</a>
                    </div>`;
                }, "width": "26%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}