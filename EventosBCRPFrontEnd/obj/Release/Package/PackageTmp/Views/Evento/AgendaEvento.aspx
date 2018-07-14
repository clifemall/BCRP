<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Principal/MasterEvento.Master" AutoEventWireup="true" CodeBehind="AgendaEvento.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Evento.AgendaEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style>
        .titulocontenedor {
            color: #0A435E !important;
        }

        .btn05 {
            background-color: #0A435E !important;
            margin-top: 1em !important;
            width: 22vh;
            color: #fff;
        }

        .big02 {
            color: #0B425F;
            font-weight: 700;
            font-size: 13px !important;
            margin-bottom: 0.1em;
        }

        .big03 {
            font-weight: 700;
            font-size: 12px !important;
            margin-bottom: 0.1em;
        }

        .big04 {
            font-weight: 400;
            font-size: 12px !important;
            margin-bottom: 0.1em;
        }
    </style>
    <!--CONTENIDO DE FOTO | IZQUIERDO-->
    <div class="col-sm-3 barimage contentindex" style="background: url('/Images/Ima01.png') no-repeat; background-size: cover;"></div>
    <!--CONTENIDO DERECHO FORMULARIOS-->
    <div class="col-sm-9 contentindex" id="panel_evento2">
        <div class="container">
            <p id="tituloAgenda" runat="server" class="titulocontenedor"><u>Agenda</u></p>
        </div>
        <div class="row" style="text-align: center">
            <div class="col-sm-12">
                <div id="seccionVerde" runat="server" class="alert alert-success " visible="false">
                    <strong>Cambios realizados!</strong>
                </div>

                <div id="seccionNaranja" runat="server" class="alert alert-warning" visible="false">
                    <strong>No se pudieron ahcer los cambios!</strong>
                </div>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="card bg-light mb-3">

                            <div class="card-body">
                                <%--    <%--<p class="card-text" style="text-align: left"><a href="#" runat="server" onclick="<%=doOpen(this.ClientID, Eval("LinkRepositorio").ToString().Trim()); %>">
                            <img src="../../Images/Document-40.png" title="Descargar" style="color: #f54d0a; display: inline-block; width: 30px; height: 30px;" /></a>&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span></p>--%>
                                <%--<p class="card-text" style="text-align: left">--%>

                                <%-- <asp:LinkButton CommandArgument='<%#Eval("LinkRepositorio").ToString().Trim() %>' ID="link" runat="server"  OnClick="btnDescarga_Click" >
                            <img src="../../Images/Document-40.png" title="Descargar" style="color: #f54d0a; display: inline-block; width: 30px; height: 30px;" /></asp:LinkButton>&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span></p>--%>--%>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <h2 id="txtTitulo" style="text-align: center;" runat="server" class="big02">9na Conferencia Anual BCRP - BRETTON WOODS</h2>
                <p id="txtDireccion" style="text-align: center;" runat="server" class="big03">Plazoleta, Santo Domingo 259</p>
                <p id="txtFecha" style="text-align: center;" runat="server" class="big04">Abril 8, 2018</p>

                <br />
                <div class="panel-body scrollbar-black horizontalajust" runat="server" style="overflow-y: scroll; height: 100%; max-height: 430px;">
                    <asp:Repeater ID="ParentRepeater" runat="server" OnItemDataBound="ItemBound">
                        <ItemTemplate>
                            <!--CABECERA FECHA-->
                            <div class="navbar" style="background-color: #0A435E; color: whitesmoke;">
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("CabeceraFecha").ToString() %>'></asp:Label>
                            </div>
                            <!--CABECERA ACTIVIDAD POR FECHA-->
                            <asp:Repeater ID="ChildRepeater" runat="server" OnItemDataBound="ItemBound2">
                                <HeaderTemplate>
                                    <table class="table table-responsive-sm ">
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr class="colorline">
                                        <th style="width: 9%">
                                            <div style="display: inline-block;">
                                                <p class="nomargin" style="font-size: 13px; font-weight: normal; color: #0B425F;"><%# EventosBCRPFrontEnd.Functions.clGetSplitIndex.Read(Eval("DuracionActividad").ToString(), "\\n\\r", 0) %></p>
                                                <p class="nomargin" style="font-size: 13px; font-weight: normal; color: #0B425F;"><%# EventosBCRPFrontEnd.Functions.clGetSplitIndex.Read(Eval("DuracionActividad").ToString(), "\\n\\r", 2) %></p>
                                            </div>
                                        </th>

                                        <th style="width: 8%">

                                            <div id="container-main">

                                                <div class="accordion-container">

                                                    <a href="#" class="accordion-titulo">.<span class="toggle-icon"></span></a>
                                                    <div class="accordion-content" style="padding-bottom: 0px; padding-top: 0px;">
                                                        <asp:Label ID="LabelID" Font-Size="1px" runat="server" Text='<%#Eval("id_Actividad").ToString() %>'></asp:Label>
                                                        <asp:Repeater ID="ChildRepeater2" runat="server">
                                                            <ItemTemplate>
                                                                <div class="card bg-light mb-3" style=" margin-bottom: 5px !important;">
                                                                    <div class="card-body" style="height: 30px;">
                                                                        <%--<p class="card-text" style="text-align: left"><a href="#" runat="server" onclick="<%=doOpen(this.ClientID, Eval("LinkRepositorio").ToString().Trim()); %>">
                                                                        <img src="../../Images/Document-40.png" title="Descargar" style="color: #f54d0a; display: inline-block; width: 30px; height: 30px;" /></a>&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span></p>--%>
                                                                        <asp:LinkButton  style="text-decoration: none; color:#000000; font-size:12px; font-weight:400;" CommandArgument='<%#Eval("LinkRepositorio").ToString().Trim() %>' ID="link" runat="server" OnClick="btnDescarga_Click" >
                                                                        <p class="card-text" style="margin: -14px; text-align: left";>
                                                                            
                                                                            <img src="../../Images/Document-40.png" title="Descargar" style="color: #f54d0a; display: inline-block; width: 25px; height: 25px;" />&emsp;&emsp;<span><%#Eval("NombreReporsitorio").ToString().Trim() %></span>
                                                                        </p></asp:LinkButton>
                                                                    </div>
                                                                </div>

                                                            </ItemTemplate>
                                                        </asp:Repeater>
                                                        <%--<asp:TextBox ID="Url1" runat="server" CssClass="Invisible" Visible="false"></asp:TextBox>--%>
                                                        <%--<script>
                                                            function doOpen(url1) {
                                                                var win = window.open($("#MainContent_Url").val() + url1, '_blank');
                                                                win.focus();
                                                            }
                                                        </script>--%>


                                                        <p></p>
                                                    </div>
                                                </div>
                                            </div>

                                        </th>

                                        <th>
                                            <div class="ellipsis" style="font-size: 13px; font-weight: normal; text-align: left; color: #0B425F; width: 90%;">
                                                <%#Eval("DetalleActividad").ToString() %>
                                            </div>
                                        </th>
                                        <%--    <th>
                                            <asp:LinkButton ID="btnIngresar" runat="server" Text="¿Olvidó su contraseña?" CssClass="btn btn03 btn-primary btn-md btn-block" data-dismiss="modal" data-toggle="modal" data-target="#myModal2" />
                                        </th>--%>
                                    </tr>
                                </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>



                    </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <br />
            <br />
        </div>
    </div>


</asp:Content>
