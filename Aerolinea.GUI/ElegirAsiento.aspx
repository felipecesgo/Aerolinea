<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ElegirAsiento.aspx.cs" Inherits="Aerolinea.GUI.ElegirAsiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Styles/EleccionVuelo.css" rel="stylesheet" />
    <title>Eligir Asientos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <div style="margin-left: 20px">
    <asp:Label runat="server" ID="lblTitle" Text="Elegir Asiento" CssClass="title"></asp:Label>
</div>

    <table style="margin-left: 20px">
        <tr>
            <td style="padding-left: 25px; padding-right: 25px; background-color: #e2e2e2;">
             
                <table id="Plantilla" runat="server" style="margin: 0 auto; padding: 0">
                    <tr>
                        <td colspan="5" style="text-align: center">
                            <h3>Clase Ejecutiva</h3>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40px; text-align: center">A</td>
                        <td style="width: 40px; text-align: center">B</td>
                        <td style="width: 40px;"></td>
                        <td style="width: 40px; text-align: center">C</td>
                        <td style="width: 40px; text-align: center">D</td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button1" CommandArgument="1" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" CommandArgument="2" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button3" CommandArgument="3" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button4" CommandArgument="4" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td>
                            <asp:Button ID="Button5" CommandArgument="5" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button6" CommandArgument="6" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button7" CommandArgument="7" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button8" CommandArgument="8" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td colspan="5" style="text-align: center">
                            <h3>Clase Principal</h3>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40px; text-align: center">A</td>
                        <td style="width: 40px; text-align: center">B</td>
                        <td style="width: 40px;"></td>
                        <td style="width: 40px; text-align: center">C</td>
                        <td style="width: 40px; text-align: center">D</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button9" CommandArgument="9" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button10" CommandArgument="10" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button11" CommandArgument="11" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button12" CommandArgument="12" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td>
                            <asp:Button ID="Button13" CommandArgument="13" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button14" CommandArgument="14" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button15" CommandArgument="15" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button16" CommandArgument="16" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button17" CommandArgument="17" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button18" CommandArgument="18" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button19" CommandArgument="19" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button20" CommandArgument="20" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button21" CommandArgument="21" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button22" CommandArgument="22" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button23" CommandArgument="23" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button24" CommandArgument="24" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsiento_Click" />
                        </td>
                    </tr>

                </table>
            </td>

            <td style="vertical-align: top;">
                <table cellpadding="5" style="font-size: 12px;  color:black;  margin-left: 15px; margin-top: 0px;">
                   
                    <tr style="width: 100%; font-weight: bold">
                        <td colspan="3"> <asp:Label ID="lblInfoVueloIda" runat="server"></asp:Label></td>
                    </tr>

                     <tr style="width: 100%">
                        <td style="width: 100px; font-size: 11px;">Nro. de Vuelo: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblNroVuelo" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>


                    <tr style="width: 100%">
                        <td style="width: 70px">Origen: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblOrigen" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Destino: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblDestino" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Salida: </td>
                        <td style="width: 150px">
                            <asp:Label ID="lblSalida" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Llegada: </td>
                        <td style="width: 150px">
                            <asp:Label ID="lblLLegada" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Duracion: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblDuracion" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                     <tr style="width: 100%">
                        <td style="width: 70px">Avion: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblAvion" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%; font-weight: bold">
                        <td colspan="3">Asientos Seleccionados:</td>
                    </tr>
                     
               

                     <tr style="width: 100%">
                        <td style="width: 70px">Clase: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblClase" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>
                    
                    <tr style="width: 100%">
                        <td style="width: 120px; font-size: 11px;">Nro. de Pasajeros: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblPasajeros" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px; font-size: 11px;">Nro. de Asientos: </td>
                        <td style="width: 70px">
                            <asp:ListBox ID="lbAsientos" runat="server" Width="70px"></asp:ListBox>
                        </td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px;"></td>
                        <td style="width: 70px">
                            <asp:Button ID="btnEliminar" runat="server" Text="<--" OnClick="btnEliminar_Click" />
                        </td>
                        <td style="width: 70px"></td>
                    </tr>

                   
                </table>

            </td>



        </tr>


        <tr>
            <td style="padding-left: 25px; padding-right: 25px; padding-bottom: 25px; background-color: #e2e2e2;">
                 <hr style="border: 0px; border-top: 1px solid gray;" />
                <table id="PlantillaRegreso" visible="false" runat="server" style="margin: 0 auto; padding: 0">
                    <tr>
                        <td colspan="5" style="text-align: center">
                            <h3>Clase Ejecutiva</h3>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40px; text-align: center">A</td>
                        <td style="width: 40px; text-align: center">B</td>
                        <td style="width: 40px;"></td>
                        <td style="width: 40px; text-align: center">C</td>
                        <td style="width: 40px; text-align: center">D</td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button25" CommandArgument="1" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button26" CommandArgument="2" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button27" CommandArgument="3" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button28" CommandArgument="4" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td>
                            <asp:Button ID="Button29" CommandArgument="5" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button30" CommandArgument="6" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button31" CommandArgument="7" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button32" CommandArgument="8" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td colspan="5" style="text-align: center">
                            <h3>Clase Principal</h3>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 40px; text-align: center">A</td>
                        <td style="width: 40px; text-align: center">B</td>
                        <td style="width: 40px;"></td>
                        <td style="width: 40px; text-align: center">C</td>
                        <td style="width: 40px; text-align: center">D</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button33" CommandArgument="9" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button34" CommandArgument="10" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button35" CommandArgument="11" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button36" CommandArgument="12" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                    </tr>


                    <tr>
                        <td>
                            <asp:Button ID="Button37" CommandArgument="13" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button38" CommandArgument="14" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button39" CommandArgument="15" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button40" CommandArgument="16" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button41" CommandArgument="17" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button42" CommandArgument="18" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button43" CommandArgument="19" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button44" CommandArgument="20" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Button ID="Button45" CommandArgument="21" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button46" CommandArgument="22" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td style="width: 40px;"></td>
                        <td>
                            <asp:Button ID="Button47" CommandArgument="23" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button48" CommandArgument="24" runat="server" Text="  " BackColor="White" Width="40px" Height="40px" OnClick="btnAsientoRegreso_Click" />
                        </td>
                    </tr>

                </table>
            </td>

            <td style="vertical-align: top">
                <hr style="border: 0px; border-top: 1px solid gray;" />
                <table id="detalleRegreso" runat="server" visible="false"  cellpadding="5" style="font-size: 12px; color:black; margin-left: 15px; margin-top: 25px;">
                   
                    <tr style="width: 100%; font-weight: bold">
                        <td colspan="3"><asp:Label ID="lblInfoVueloRegreso" runat="server"></asp:Label></td>
                    </tr>

                     <tr style="width: 100%">
                        <td style="width: 100px; font-size: 11px;">Nro. de Vuelo: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblNroVueloRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>


                    <tr style="width: 100%">
                        <td style="width: 70px">Origen: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblOrigenRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Destino: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblDestinoRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Salida: </td>
                        <td style="width: 150px">
                            <asp:Label ID="lblSalidaRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Llegada: </td>
                        <td style="width: 150px">
                            <asp:Label ID="lblLlegadaRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px">Duracion: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblDuracionRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                     <tr style="width: 100%">
                        <td style="width: 70px">Avion: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblAvionRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%; font-weight: bold">
                        <td colspan="3">Asientos Seleccionados:</td>
                    </tr>
                     
               

                     <tr style="width: 100%">
                        <td style="width: 70px">Clase: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblClaseRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>
                    
                    <tr style="width: 100%">
                        <td style="width: 120px; font-size: 11px;">Nro. de Pasajeros: </td>
                        <td style="width: 70px">
                            <asp:Label ID="lblPasajerosRegreso" runat="server"></asp:Label></td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px; font-size: 11px;">Nro. de Asientos: </td>
                        <td style="width: 70px">
                            <asp:ListBox ID="lbAsientosRegreso" runat="server" Width="70px"></asp:ListBox>
                        </td>
                        <td style="width: 70px"></td>
                    </tr>

                    <tr style="width: 100%">
                        <td style="width: 70px;"></td>
                        <td style="width: 70px">
                            <asp:Button ID="btnEliminarRegreso" runat="server" Text="<--" OnClick="btnEliminarRegreso_Click" />
                        </td>
                        <td style="width: 70px"></td>
                    </tr>

                   
                </table>

            </td>



        </tr>



        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar y Continuar" CssClass="btn btn-primary" Visible="false"   OnClick="btnIngresar_Click"/>
                <asp:Button ID="btnRegresar" runat="server" Text="Cancelar"  Visible="true" PostBackUrl="~/Index.aspx" CssClass="btn btn-default" />
            </td>
        </tr>

         <tr>
            <td>

            </td>
         </tr>
    </table>



</asp:Content>
