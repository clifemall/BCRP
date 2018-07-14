<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Principal/MasterEvento.Master" AutoEventWireup="true" CodeBehind="PresentacionesEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.PresentacionesEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<script type="text/javascript"> 
        function fireServerButtonEvent(id)
        {
            alert(id);
            
            document.getElementById("btnSubmit").click();
        }
    </script> --%>

    <!--CONTENIDO DE FOTO | IZQUIERDO-->
    <div class="col-sm-3 barimage contentindex" style="background: url('/Images/Ima01.png') no-repeat; background-size: cover;"></div>
    <!--CONTENIDO DERECHO FORMULARIOS-->
    <div class="col-sm-9 contentindex" id="panel_evento2">
        <div class="container">
        <p id="tituloPresentaciones" runat="server" class="titulocontenedor"><u>Presentaciones</u></p>
    </div>
    <div class="col-sm-12 scrollbar-black" style="-webkit-padding-after: 20px; overflow-y: scroll; text-align: center; max-height: 490px;">
        <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
            <strong>Cambios realizados!</strong>
        </div>
        <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
            <strong>No se pudieron ahcer los cambios!</strong>
        </div>
        <br />
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="card bg-light mb-3" style="height: 50px;">
                    <div class="card-body" style="margin: -11px;">
                        <asp:LinkButton style="text-decoration: none; color:#000000; font-weight:400;" CommandArgument='<%#Eval("LinkRepositorio").ToString().Trim() %>' ID="link" runat="server"  OnClick="btnDescarga_Click" >
                        <%--<p class="card-text" style="text-align: left"><a href="#" runat="server" onclick="<%=doOpen(this.ClientID, Eval("LinkRepositorio").ToString().Trim()); %>">
                            <img src="../../Images/Document-40.png" title="Descargar" style="color: #f54d0a; display: inline-block; width: 30px; height: 30px;" /></a>&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span></p>--%>
                        
                            <asp:HiddenField ID ="_TipoRepositorio" runat="server" Value ='<%#Eval("TipoRepositorio").ToString().Trim() %>'/>
                            <p class="card-text" style="text-align: left">
                            
                            <img src="../../Images/Document-40.png" title="Descargar" style="color: #f54d0a; display: inline-block; width: 30px; height: 30px;" />&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span></p></asp:LinkButton>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
    <asp:TextBox ID="Url" runat="server" CssClass="Invisible" Visible="false"></asp:TextBox>
    <script>
        function doOpen(url) {
            var win = window.open($("#MainContent_Url").val() + url, '_blank');
            win.focus();
        }
    </script>
    </div>
    
</asp:Content>
