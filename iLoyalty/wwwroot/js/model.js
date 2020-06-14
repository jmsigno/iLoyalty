function CreateModel(data) {
    if (data.success) {
        toastr.success(data.message); 8
        dataTable.ajax.reload();
    } else {
        toastr.error(data.message);
    }
}














/*
var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/Model/getall/",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "phone_number" },
            { "data": "state" },
            { "data": "account_length"},
            { "data": "area_code" },
            { "data": "international_plan" },
            { "data": "voice_mail_plan" },
            { "data": "number_vmail_messages" },
            { "data": "customer_service_calls" },
            { "data": "churn" }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}
*/