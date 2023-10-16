# JQueryDataTable 🤩
Using tool for reports pagination, easy &amp; simple!

## ✨ YouTube Video 

Access: https://www.youtube.com/watch?v=JkVAhm4XHyQ

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

    $('#people-table').DataTable({
        "ordering": false,
        "paging": true,
        "searching": false,
        "olanguage": {
            "semptytable": "nenhum registro encontrado na tabela",
            "sinfo": "mostrar _start_ até _end_ de _total_ registros",
            "sinfoempty": "mostrar 0 até 0 de 0 registros",
            "sinfofiltered": "(filtrar de _max_ total registros)",
            "sinfopostfix": "",
            "sinfothousands": ".",
            "slengthmenu": "mostrar _menu_ registros por pagina",
            "sloadingrecords": "carregando...",
            "sprocessing": "processando...",
            "szerorecords": "nenhum registro encontrado",
            "ssearch": "pesquisar",
            "opaginate": {
                "snext": "proximo",
                "sprevious": "anterior",
                "sfirst": "primeiro",
                "slast": "ultimo"
            },
            "oaria": {
                "ssortascending": ": ordenar colunas de forma ascendente",
                "ssortdescending": ": ordenar colunas de forma descendente"
            }
        }
    });    
}

```
