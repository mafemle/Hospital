<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="Hostipal.Citas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: right;
            width: 713px;
        }
        .auto-style4 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style5 {
            width: 256px;
            height: 256px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            text-align: left;
            width: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" colspan="4">
            <strong>Ingreso Cita</strong></td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="4">
                    <img alt="imgCita" class="auto-style5" src="imagenes/cita.png" /></td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Codigo Cita:</strong></td>
                <td class="auto-style2" colspan="2">
                    <asp:TextBox ID="Txtcod_cita" runat="server" Height="25px" Width="124px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    
                    <asp:Button ID="btncita" runat="server" BackColor="#333333" ForeColor="White" Height="35px" OnClick="btncita_Click" Text="Confirmar Cita" />
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:Label ID="LblConfirmacionCita" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Fecha: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="TxtIfechaCita" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Hora: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="TxtHoraCita" runat="server" Height="25px" Width="123px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Identificación Paciente: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="TxtId_paciente" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style7">
                    <asp:Label ID="LblNombrePaciente" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="LblTelPaciente" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnBuscarPaciente" runat="server" BackColor="#333333" ForeColor="White" Height="35px" Text="Buscar Paciente" Width="131px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Identificación Médico: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="Txtid_medico" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style7">
                    <asp:Label ID="LblNombreMedico" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="LblEspecialidad" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnBuscarMedico" runat="server" BackColor="#333333" ForeColor="White" Height="35px" Text="Buscar Médico" Width="131px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Valor: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="Txtvalor" runat="server" Height="25px" Width="130px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Diagnóstico: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="Txtdiagnostico" runat="server" Height="99px" Width="539px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Nombre Acompañante: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:TextBox ID="TxtNom_acompanante" runat="server" Height="25px" Width="315px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Estado: </strong></td>
                <td class="auto-style2" colspan="3">
                    <asp:CheckBoxList ID="ChbactivoCita" runat="server">
                        <asp:ListItem>Activo</asp:ListItem>
                        <asp:ListItem>Inactivo</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="btnGuardar" runat="server" BackColor="#333333" ForeColor="White" Height="35px" Text="Guardar" Width="131px" OnClick="btnGuardar_Click" />
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" colspan="3">
                    &nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
