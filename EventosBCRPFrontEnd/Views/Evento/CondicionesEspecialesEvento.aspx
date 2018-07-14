<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CondicionesEspecialesEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.CondicionesEspecialesEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row scrollbar-black " style="overflow-y: scroll; height: 360px;">
            <div class="col-sm-10" style="text-align: left">
                <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                    <strong>Cambios realizados!</strong>
                </div>
                <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                    <strong>No se pudieron ahcer los cambios!</strong>
                </div>
                <strong>¿Discapacidad física o sensorial?</strong><div style="padding: 5px"></div>
                <asp:CheckBox ID="chFisica" runat="server" Text="fisíca" />
                <asp:CheckBox ID="chSensorial" runat="server" Text="sensorial" />
                <br />
                <p>Especifique</p>
                <asp:TextBox ID="txtDiscapacidad" runat="server" TextMode="MultiLine" Width="100%" class="form-control" Style="resize: none" />
                <br />

                <strong>¿tiene algún requerimiento especial, dietético o de otro tipo?</strong><div style="padding: 5px"></div>
                <asp:CheckBox ID="chDiabetico" runat="server" Text="Diabético" />
                <asp:CheckBox ID="chOtros" runat="server" Text="Otros" />
                <br />
                <p>Especifique</p>
                <asp:TextBox ID="txtRequerimiento" runat="server" TextMode="MultiLine" Width="100%" class="form-control" Style="resize: none" />
            </div>
            <br />
            <br />
            <div class="col-sm-12" style="text-align: center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" class="btn btn-primary" BackColor="#0A445B" />
            </div>
        </div>
    </form>
</body>
</html>
