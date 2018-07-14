<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosPersonalesEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.DatosPersonalesEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
            <p>Cambios realizados!</p>
        </div>
        <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
            <p>No se pudieron ahcer los cambios!</p>
        </div>
        <div class="row scrollbar-black" style="overflow-y: scroll; height: 360px;">
            <div class="col-sm-6" style="text-align: left">
              
                <p class="nopadding nomargin">Título (Mr/Mrs etc)</p>
                <asp:TextBox ID="txtTitulo" runat="server" class="form-control" />
                <br />
                
                <p class="nopadding nomargin">Puesto</p>
                <asp:TextBox ID="txtPuesto" runat="server" class="form-control" />
                <br />
                
                <p class="nopadding nomargin">Tipo Documento</p>

                <asp:DropDownList ID="dpTipoDocumento" runat="server" DataTextField="NombeTipoDocumento" DataValueField="id_TipoDocumento" AutoPostBack="true" class="btn btn-secondary dropdown-toggle"  BackColor="#0A445B" /><br />
                <div style="height: 10px; text-align: left"></div>
                <asp:TextBox ID="txtDocumento" runat="server" class="form-control"  />
                <br />
            </div>
            <div class="col-sm-6" style="text-align: left">
                <p class="nopadding nomargin">Institución</p>
                <asp:TextBox ID="txtOrganizacion" runat="server" class="form-control"/>
                <br />
                
                <p class="nopadding nomargin">Abreviatura</p>
                <asp:TextBox ID="txtAbreviatura" runat="server" class="form-control"  />
                <br />
                
                <p class="nopadding nomargin">País</p>
                <asp:TextBox ID="txtPais" runat="server" class="form-control"  />
            </div>
            <div class="col-lg-12" style="text-align: center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" class="btn btn-primary" BackColor="#0A445B" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
