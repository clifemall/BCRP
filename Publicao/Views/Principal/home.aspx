<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEvento.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.home" %>
<asp:Content ID="BodyPage" ContentPlaceHolderID="MainContent" runat="server">
   

    <h3 id="txtTitulo" runat="server" style="text-align: center"></h3>
    <h2 id="txtDireccion" runat="server"></h2>
    <p id="txtFecha" runat="server"></p>

    <div class="container">
        <asp:Image ID="imgBackApp" runat="server" Style="height:100%; width: 100%" class="img-thumbnail" />
    </div>
    
</asp:Content>
