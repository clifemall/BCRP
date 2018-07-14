<%@ Page Title="" Language="C#" MasterPageFile="~/InformacionGeneral.master" AutoEventWireup="true" CodeBehind="acompanante.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.acompanante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
  
   <style>
        p{
            color:#08455C;
            margin-bottom:0;
            font-weight:600;
        }
        strong,label{
            color:#08455C;
        }
        
    </style>
       <div class="col-sm-12 scrollbar-black" overflow-y: scroll;text-align: center;max-height: 490px;" >
         <div id="Div1" runat="server" class="alert alert-success" visible="false">
                <strong>Cambios realizados!</strong>
            </div>
            <div id="Div2" runat="server" class="alert alert-warning" visible="false">
                <strong>No se pudieron ahcer los cambios!</strong>
            </div>
        <br />                      
        </div>
    

    <div class="row scrollbar-black" style="overflow-y: scroll; height: 360px;">
        <div class="col-sm-12" style="text-align: left">
            <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                <strong>Cambios realizados!</strong>
            </div>
            <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                <strong>No se pudieron ahcer los cambios!</strong>
            </div>
            <strong>Nombre del acompañante</strong><br />
            <div style="height: 10px; text-align: left"></div>
            <div class="input-group">
                <asp:TextBox ID="txtNombreAcompanante" runat="server" class="form-control" />
                <span class="input-group-addon">&nbsp&nbsp</span>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" class="btn btn-primary" BackColor="#0A445B" />
            </div>
            <br />
            <strong>Acompañantes</strong>
            <div style="height: 10px; text-align: left"></div>

            
            <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div style=" text-align:left; border-bottom:1px solid" >
                        <div class="input-group">
                            <div class="col-sm-8"><br />
                           <p><%#Eval("NombreInvitado").ToString().Trim() %></p> 
                            </div>  
                           <div class="col-sm-2" style =" visibility:hidden">
                           <p><%#Eval("id_Invitado").ToString().Trim() %></p> 
                            </div>                            
                            <div class="col-sm-2">
                            &nbsp &nbsp&nbsp&nbsp&nbsp &nbsp&nbsp&nbsp
                            <asp:LinkButton ID="lnkEliminar"  CommandArgument='<%#Eval("id_Invitado")%>' runat="server" Text="Eliminar" OnClick="GridViewAgendaActividad_SelectedIndexChanged"/>
                            </div>
                      </div>
                      </div>
                    </ItemTemplate>   
                
            </asp:Repeater> 
        </div>

    </div>
</asp:Content>
