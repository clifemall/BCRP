<%@ Page Title="" Language="C#" MasterPageFile="~/informacionGeneral.master" AutoEventWireup="true" CodeBehind="datosContacto.aspx.cs" Inherits="CapaPresentacion.datosContacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
     
    <div class="container">
        <div class="row scrollbar-black" style="overflow-y: scroll; ">
            <div class="col-sm-6" style="text-align:left">
                <div id="seccionVerde" runat="server" class="alert alert-success" visible="false">
                    <strong>Cambios realizados!</strong>
                </div>
                <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                    <strong>No se pudieron ahcer los cambios!</strong>
                </div>
                <p>Ciudad</p>
                <asp:TextBox ID="txtCiudad" runat="server" class="form-control" style="width:100%"  />
                <br />
                <p>Teléfono</p>
                <asp:TextBox ID="txtTelefono" runat="server" class="form-control" style="width:100%"  />
                <br />
                <p>Correo de emergencia</p>
                <asp:TextBox ID="txtCorreoEmergencia" runat="server" class="form-control" style="width:100%"  />
                <br />
            </div>

            <div class="col-sm-6" style="text-align:left">
                
                <p>Dirección</p>
                <asp:TextBox ID="txtDireccion" runat="server" class="form-control" style="width:100%"  />
                <br />
                <p>Teléfono de emergencia</p>
                <asp:TextBox ID="txtTelefonoEmergencia" runat="server" class="form-control" style="width:100%" />
                <br />
                <p>Contacto de emergencia</p>
                <asp:TextBox ID="txtContactoEmergencia" runat="server" class="form-control" style="width:100%" />
            </div>
            <br />
            <div class="col-lg-12" style="text-align: center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" class="btn btn-primary" BackColor="#0A445B"/>
            </div>
        </div>
    </div>
</asp:Content>
