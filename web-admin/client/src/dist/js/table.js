function LaodTable(tableid) {
  setTimeout(function () {
    $("#" + tableid).DataTable({
      "paging": true,
      "responsive": true,
      "lengthChange": false,
      "ordering": true,
      "autoWidth": false,
      "info": true,
      "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
    }).buttons().container().appendTo('MainTable_wrapper .col-md-6:eq(0)');
  }, 10);
}