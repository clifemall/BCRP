<%@ Page Title="" Language="C#" MasterPageFile="~/InformacionGeneral.master" AutoEventWireup="true" CodeBehind="datosPersonales.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.datosPersonales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
     <%--<style>
        p{
            color:#08455C;
            margin-bottom:0;
            font-weight:600;
        }
        strong{
            color:#08455C;
        }
    </style>--%>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    <fieldset>
    <div class="container">
        <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
            <p>Cambios realizados!</p>
        </div>
        <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
            <p>No se pudieron ahcer los cambios!</p>
        </div>
        <div class="row scrollbar-black" style="overflow-y: scroll; height: 360px;">
            <div class="col-sm-6" style="text-align: left">
              
                <p>Título (Mr/Mrs etc)</p>
                <asp:TextBox ID="txtTitulo" runat="server" class="form-control" Style="width: 80%" />
                <br />
                
                <p>Puesto</p>
                <asp:TextBox ID="txtPuesto" runat="server" class="form-control" Style="width: 80%" />
                <br />
                
                <p>Tipo Documento</p>

                <asp:DropDownList ID="dpTipoDocumento" runat="server" DataTextField="NombeTipoDocumento" DataValueField="id_TipoDocumento" AutoPostBack="true" class="btn btn-primary dropdown-toggle" Width="80%" BackColor="#0A445B" /><br />
                <div style="height: 10px; text-align: left"></div>
                <asp:TextBox ID="txtDocumento" runat="server" class="form-control" Style="width: 80%" />
                <br />
            </div>
            <div class="col-sm-6" style="text-align: left">
                <br />
                <p>Institución</p>
                <asp:TextBox ID="txtOrganizacion" runat="server" class="form-control" Style="width: 80%" />
                <br />
                
                <p>Abreviatura</p>
                <asp:TextBox ID="txtAbreviatura" runat="server" class="form-control" Style="width: 80%" />
                <br />
                
                <p>País</p>
                <asp:TextBox ID="txtPais" runat="server" class="form-control" Style="width: 80%" />
            </div>
            <div class="col-lg-12" style="text-align: center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" class="btn btn-primary" BackColor="#0A445B" />
            </div>
        </div>
    </div>
    </fieldset></ContentTemplate></asp:UpdatePanel>
</asp:Content>
