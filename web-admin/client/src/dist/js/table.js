$(function () {
  const table = window.document.getElementById('MainTable').children[0];

  observer = new MutationObserver(function (mutationsList, observer) {
    $("#MainTable").DataTable({
      "paging": true,
      "responsive": true,
      "lengthChange": false,
      "ordering": true,
      "autoWidth": false,
      "info": true,
      "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
    }).buttons().container().appendTo('MainTable_wrapper .col-md-6:eq(0)');
  });

  observer.observe(table, { characterData: false, childList: true, attributes: false });

});
