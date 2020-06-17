var dataTable;

$(document).ready(function () {
    loadDatePicker();
    loadDataTable();
    loadFrenchToast();
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

function loadDatePicker() {
    $('.datepicker').datepicker({
        dateFormat:'dd-M-yy',
        changeMonth: true,
        changeYear: true,
        showOn: "button",
        buttonText:'<span class="fa fa-calendar fa-2x" aria-hidden="true" style="color:darkgray;"></span>'
    });
}

function loadFrenchToast() {
    $('#info').click(function (event) {
        toastr.info('This may take a while...', "Creating Model",
            toastr.options = {
                "closeButton": false,
                "debug": false,
                "newestOnTop": false,
                "progressBar": true,
                "positionClass": "toast-top-right",
                "preventDuplicates": false,
                "onclick": null,
                "showDuration": "500",
                "hideDuration": "1000",
                "timeOut": "9999",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            })
    });

    $('.toaster').load(function (event) {
        toastr.info('This may take a while...', "Creating Model",
            toastr.options = {
                "closeButton": false,
                "debug": false,
                "newestOnTop": false,
                "progressBar": true,
                "positionClass": "toast-top-right",
                "preventDuplicates": false,
                "onclick": null,
                "showDuration": "500",
                "hideDuration": "1000",
                "timeOut": "9999",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            })
    });
}
 