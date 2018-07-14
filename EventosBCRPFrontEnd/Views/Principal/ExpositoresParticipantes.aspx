<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalEvento.Master" AutoEventWireup="true" CodeBehind="ExpositoresParticipantes.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.ExpositoresParticipantes" %>

<asp:Content ID="BodyPage" ContentPlaceHolderID="MainContent" runat="server">
     <style>
        .img_participante {
            width: 50%;
            border-radius: 10px;
        }

        .img_expositor {
            width: 50%;
            border-radius: 10px;    
        }
        .aspNetDisabled
        {
          display: inline-block;
          font-weight: 400;
          text-align: center;
          white-space: nowrap;
          vertical-align: middle;
          -webkit-user-select: none;
          -moz-user-select: none;
          -ms-user-select: none;
          user-select: none;
          border: 1px solid transparent;
          padding: 0.375rem 0.75rem;
          font-size: 1rem;
          line-height: 1.5;
          border-radius: 0.25rem;
          transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
          color: #0a435e  ! important;
          background-color: #ffffff ! important;
          border-color: #0a435e ! important;
        }
    </style>
    <div class="container">
      <p class="titulocontenedor"><u>Expositores y Participantes</u></p>
    </div>
    <div class=" row" style="text-align: center; padding:20px">
            <asp:Button ID="btnExpositores" runat="server" Text="Expositores" class="btn btn-primary"  OnClick="btnExpositores_Click" Width="250px" /> &nbsp; &nbsp;
            <asp:Button ID="btnParticipantes" runat="server" Text="Participantes" class="btn btn-primary" OnClick="btnParticipantes_Click" Width="250px" />
    </div>
    <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
        <strong>Cambios realizados!</strong>
    </div>
    <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
        <strong>No se pudieron ahcer los cambios!</strong>
    </div>
    <div class="row scrollbar-black" style="-webkit-padding-after: 20px;overflow-y: scroll;text-align: center;max-height: 420px;" >
      
        <div class="col-sm-3">
            <asp:Label ID="txtParticiante1" runat="server"></asp:Label>
            
        </div>
        <div class="col-sm-3">
            <asp:Label ID="txtParticiante2" runat="server"></asp:Label>
        </div>
        <div class="col-sm-3">
            <asp:Label ID="txtParticiante3" runat="server"></asp:Label>
        </div>
        <div class="col-sm-3">
            <asp:Label ID="txtParticiante4" runat="server"></asp:Label>
        </div>
         
    </div>
    <div class="row scrollbar-black" style=" padding:50px; text-align: center" >
        <br />
        </div>
</asp:Content>
