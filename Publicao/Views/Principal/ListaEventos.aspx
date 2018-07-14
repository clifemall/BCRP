<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListaEventos.aspx.cs" Inherits="EventosBCRPFrontEnd.Views.Principal.ListaEventos" %>

<asp:Content ID="BodyPage" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="col-sm-6 float-left">
                <div class="table table-responsive-sm col-sm-6 float-left" id="sidebar" style="background-color: #F7F7F7; border-radius: 10px; margin-bottom: 10px; margin-right: 0px; padding-right: 13px; width: 100%; max-height: fit-content;">
                    <table class="table" style="/* border-radius: 10px; */padding-left: 0px; padding-right: 0px; /* padding-top: 30px; */margin-top: 10px; background-color: transparent;">
                        <tbody>
                            <tr>
                                <td style="text-align: left;">
                                    <%--<img src="<%# EventosBCRPFrontEnd.Functions.clGetFileFTP.ReadImage(Eval("FotoEvento").ToString()) %>" />--%>
                                    <img src="<%# EventosBCRPFrontEnd.Functions.clGetRepositorio.Read(Eval("FotoEvento").ToString()) %>" style="max-width: 170px; height: 220px; border-radius: 10px;" />
                                </td>
                                <td style="text-align: center; text-justify: auto;">
                                    <div style="font-size: 14px">
                                        <p><%#Eval("NombreEvento").ToString().Trim() %></p>
                                    </div>
                                    <div class="ellipsis" style="font-size: 13px">
                                        <p><%#Eval("DescripcionEvento").ToString().Trim() %></p>
                                    </div>
                                    <p><%#Eval("LugarEvento").ToString().Trim() %></p>

                                    <div class="container-fluid nopadding">
                                        <div class="col-sm-12">
                                            <div class="container-fluid nopadding" style="float: left">
                                                <%--<div class="col-sm-3">--%>
                                                <span class="glyphicon glyphicon-calendar" style="display: inline-block; font-size: 30px;"></span>
                                                <%--</div>--%>
                                                <div style="display: inline-block;">
                                                    <p class="nomargin" style="font-size: 12px;"><%#DateTime.Parse(Eval("FechaInicioEvento").ToString()).ToString("dd/MM/yyyy H:mm")%></p>
                                                    <p class="nomargin" style="font-size: 12px;"><%#DateTime.Parse(Eval("FechaFinEvento").ToString()).ToString("dd/MM/yyyy H:mm")%></p>
                                                </div>
                                                <div style="display: inline-block;">
										        <br/>
										        <p><a href="<%#Eval("LinkHomeEvento").ToString().Trim()%>" ><span class="glyphicon glyphicon-menu-right" aria-hidden="true" style="color:#f54d0a;display: inline-block; font-size: 30px;"></span></a> </p>
                                               </div>
                                            </div>                                    
                                        </div>      
                                    </div>
                                </td>
                            </tr> 
                      </tbody>
                </table>
            </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>