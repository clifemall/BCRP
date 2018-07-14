<%@ Page Title="" Language="C#" MasterPageFile="~/Inscripcion.master" AutoEventWireup="true" CodeBehind="delegarInformacion.aspx.cs" Inherits="CapaPresentacion.delegarInformacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">

    <strong>DELEGAR INVITACIÓN</strong>

    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                <p>Nombre</p>
                <asp:TextBox ID="lblNombre" runat="server" /><br />
                <br />
                <p>Email</p>
                <asp:TextBox ID="txtEmail" runat="server" /><br />
            </div>
            <div class="col-sm-6">
                <p>Apellido</p>
                <asp:TextBox ID="lblApellido" runat="server" /><br />
                <br />
                <p>Institución</p>
                <asp:TextBox ID="lblInstitucion" runat="server" /><br />
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-8" style="text-align:center">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" />
            </div>
        </div>
    </div>

</asp:Content>
