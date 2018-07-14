<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformacionGeneralEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.InformacionGeneralEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .btninfo {
            width:24.5%;
             background-color: #f7f7f7;
            border: none;
            color: black !important;
            font-size:14px;
            height:50px;
            text-align:center;
            vertical-align:central;
            line-height:40px;
        }
        #menuinfo{
            width:100%;
        }
        .activated2{
            background-color: #3cafe5 !important;
            color: white !important;

        }
        .margintopinfo{
            margin:0px;
            margin-top:4px;
        }

    </style>
    <script>

        $(document).ready(function () {
           $('#infocontent').load('DatosPersonalesEvento.aspx');
            $('.btninfo').click(function () {
                //alert('asdsad');
                var header = document.getElementById("menuinfo");
                var btns = header.getElementsByClassName("insup");
                //alert(btns[0]);
                for (var i = 0; i < btns.length; i++) {
                    btns[i].className = btns[i].className.replace(" activated2", "");
                }
                //this.className = this.className.replace(" btn-navins", "");
                this.className += " activated2";
                //alert(this.className);
                var page = $(this).attr('id');
               
                //alert(page);
                
                    //$('#panel_evento').load(page + '.aspx');
               
                $.get(page + '.aspx', function (data) {
                    alert(data);
                    $("#infocontent").html(data); 
                });
            });
            
            


         });
   </script>
</head>
<body>
    <form id="form3" runat="server">
        <div class="container-fluid nopadding text-right" style="">
        <div id="menuinfo" style="display: inline-block;">
            <a id="DatosPersonalesEvento" class="btn btninfo insup activated2">Datos Personales</a>
            <a id="DatosContactoEvento" class="btn btninfo insup ">Datos de Contacto</a>
            <a id="CondicionesEspecialesEvento" class="btn btninfo insup ">Condiciones Especiales</a>
            <a id="AcompanantesEvento" class="btn btninfo insup ">Acompañantes</a> 
        </div>
        <div class="row nomargin" style="padding-right:0px;height:100%;">
           
            <div id="infocontent" class="col-sm-12 margintopinfo"  style="padding :20px;background-color: #f7f7f7; height:100%;">
                
            </div> 

        </div>
    </div>
    </form>
</body>
</html>
