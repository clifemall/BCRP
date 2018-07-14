<%@ Page Title="" Language="C#" MasterPageFile="~/informacionGeneral.master" AutoEventWireup="true" CodeBehind="condicionesEspeciales.aspx.cs" Inherits="CapaPresentacion.condicionesEspeciales" %>

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
    <div class="row scrollbar-black " style="overflow-y: scroll; height: 360px;">
        <div class="col-sm-10" style="text-align:left">
            <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                <strong>Cambios realizados!</strong>
            </div>
            <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                <strong>No se pudieron ahcer los cambios!</strong>
            </div>
            <strong>¿Discapacidad física o sensorial?</strong><div style="padding:5px" ></div>
            <asp:CheckBox ID="chFisica" runat="server" Text="fisíca" />
            <asp:CheckBox ID="chSensorial" runat="server" Text="sensorial" />
            <br />
            <p>Especifique</p>
            <asp:TextBox ID="txtDiscapacidad" runat="server" TextMode="MultiLine" Width="100%" class="form-control"  style="resize:none"/>
            <br />

            <strong>¿tiene algún requerimiento especial, dietético o de otro tipo?</strong><div style="padding:5px" ></div>
            <asp:CheckBox ID="chDiabetico" runat="server" Text="Diabético" />
            <asp:CheckBox ID="chOtros" runat="server" Text="Otros" />
            <br />
            <p>Especifique</p>
            <asp:TextBox ID="txtRequerimiento" runat="server" TextMode="MultiLine" Width="100%" class="form-control"  style="resize:none" />
        </div>
        <br />
        <br />
        <div class="col-sm-12" style="text-align: center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" class="btn btn-primary" BackColor="#0A445B"/>
        </div>
    </div>

</asp:Content>
