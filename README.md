# JQueryDataTable 🤩
Using tool for reports pagination, easy &amp; simple!

## ✨ Check out the 👉 [YouTube Video](https://www.youtube.com/watch?v=JkVAhm4XHyQ)


<div align="center">
  <img width="500rem" src="https://github.com/kaiogotyacode/JQueryDataTable/assets/43120150/02755190-1767-42df-81dd-3aa0660f80c9)">  
</div>


<div align="center">
  <img height="400em" src="https://portfolio-kaiogotya.s3.us-east-2.amazonaws.com/JQueryDataTable.png">
</div>

## CSS CDN
```html
  <link rel="stylesheet" href="//cdn.datatables.net/1.13.6/css/jquery.dataTables.min.css" asp-append-version="true" />
```
## JS CDN
```js
  <script src="//cdn.datatables.net/1.13.6/js/jquery.dataTables.min.js"></script>
```

## Applying JQuery DataTable to your Table
```js

$(document).ready(() => {

    $('#TableID').DataTable({
        "ordering": false,
        "paging": true,
        "searching": false,
        "oLanguage": {
            "sEmptytable": "nenhum registro encontrado na tabela",
            "sInfo": "mostrar _start_ até _end_ de _total_ registros",
            "sInfoEmpty": "mostrar 0 até 0 de 0 registros",
            "sInfoFiltered": "(filtrar de _max_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "mostrar _menu_ registros por pagina",
            "sLoadingRecords": "carregando...",
            "sProcessing": "processando...",
            "sZeroRecords": "nenhum registro encontrado",
            "sSearch": "pesquisar",
            "oPaginate": {
                "sNext": "proximo",
                "sPrevious": "anterior",
                "sFirst": "primeiro",
                "sLast": "ultimo"
            },
            "oAria": {
                "sSortAscending": ": ordenar colunas de forma ascendente",
                "sSortDescending": ": ordenar colunas de forma descendente"
            }
        }
    });    
}

```
