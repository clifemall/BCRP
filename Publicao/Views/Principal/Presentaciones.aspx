<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEvento.Master" AutoEventWireup="true" CodeBehind="Presentaciones.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.Presentaciones" %>

<asp:Content ID="BodyPage" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .Invisible {
            display: none;
        }
    </style>
    <div class="container">
      <p class="titulocontenedor"><u>Presentaciones</u></p>
    </div>
    <div class="col-sm-12 scrollbar-black" style="-webkit-padding-after: 20px;overflow-y: scroll;text-align: center;max-height: 490px;" >
         <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                <strong>Cambios realizados!</strong>
            </div>
            <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                <strong>No se pudieron ahcer los cambios!</strong>
            </div>
        <br />
            <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                      <div class="card bg-light mb-3">
                         <div class="card-body">
                           <p class="card-text" style="text-align:left">  <a onclick= "doOpen('<%#Eval("LinkRepositorio").ToString().Trim() %>')" ><img src="../../Images/DescargarDocumento.png"  title="Descargar" style="color:#f54d0a;display: inline-block; width: 30px;height: 30px;" /></a>&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span></p>
                         </div>
                      </div>
                    </ItemTemplate>
            </asp:Repeater>
            
        </div>
           <asp:TextBox ID="Url" runat="server" CssClass="Invisible"></asp:TextBox>
           <script>
               function doOpen(url) {
                   var win = window.open($("#MainContent_Url").val() + url, '_blank');
                   win.focus();
               }
            </script>   
</asp:Content>
