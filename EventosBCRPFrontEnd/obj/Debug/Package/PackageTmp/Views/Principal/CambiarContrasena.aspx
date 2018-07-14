<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.CambiarContrasena" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
  
    <div class="container contenedoreventos">
        <asp:UpdatePanel ID="UpdatePanelDatosPersonales" runat="server">
            <ContentTemplate>
                <div class="container">
                    <p id="tituloEvento" runat="server" class="titulocontenedor"><u>Cambiar Contraseña</u></p>
                    <p id="textoevento" runat="server" class="text-sm-left">Coloque la contraseña actual, y luego coloque la contraseña nueva. Repita la contraseña nueva por motivos de seguirdad.</p>
                    <p id="P1" runat="server" class="text-sm-left">&nbsp</p>
                    <p id="P2" runat="server" class="text-sm-left">&nbsp</p>
                </div>

                <div class="panel-body scrollbar-black" runat="server" style="overflow-y: scroll; height: 100%; max-height: 457px;">
                    <p>
                        <table class="w-100">
                            <tr>
                                <td class="text-right" style="height: 28px">Ingrese su contraseña anterior:</td>
                                <td style="height: 28px; width: 35px"></td>
                                <td class="text-left" style="height: 28px">
                                    <asp:TextBox ID="txtContraAnte" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-right">Ingrese su contraseña nueva:</td>
                                <td style="width: 35px">&nbsp;</td>
                                <td class="text-left">
                                    <asp:TextBox ID="txtContraNuev1" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-right">Repita su contraseña nueva:</td>
                                <td style="width: 35px">&nbsp;</td>
                                <td class="text-left">
                                    <asp:TextBox ID="txtContraNuev2" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </p>
                </div>
                <br />
                <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-success" Text="Cambiar Contraseña" OnClick="btnGuardar_Click" />

                <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                    <strong>Cambios realizados!</strong>
                </div>
                <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                    <strong>No se pudieron ahcer los cambios!</strong>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
