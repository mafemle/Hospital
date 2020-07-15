<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="Hostipal.Pacientes" %>

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
            text-align: center;
        }
        .auto-style3 {
            width: 192px;
            height: 192px;
        }
        .auto-style4 {
            width: 764px;
        }
        .auto-style5 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style6 {
            width: 764px;
            text-align: right;
        }
        .auto-style7 {
            width: 764px;
            text-align: right;
            height: 46px;
        }
        .auto-style8 {
            height: 46px;
        }
        .auto-style9 {
            width: 764px;
            text-align: right;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        .auto-style11 {
            width: 245px;
        }
    </style>
</head>
<body id="imgcita">
    <form id="form1" runat="server">
        <div class="auto-style5">
            <strong>Ingreso Pacientes</strong></div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">
                    <img id="imgPaciente" alt="imgpaciente" class="auto-style3" src="imagenes/paciente.jpg" /></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Identificación:</strong></td>
                <td class="auto-style11">
                    <asp:TextBox ID="TxtId_paciente" runat="server" Height="25px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btconsultarPaciente" runat="server" BackColor="#333333" ForeColor="White" OnClick="btconsultarPaciente_Click" Text="Consultar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td colspan="2">
                    <asp:Label ID="lblConsultarPaciente" runat="server" Text="---"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Tipo Documento:</strong></td>
                <td colspan="2">
                    <asp:DropDownList ID="Droptip_doc" runat="server" Height="30px">
                        <asp:ListItem>Cédula Ciudadanía</asp:ListItem>
                        <asp:ListItem>Tarjeta Identidad</asp:ListItem>
                        <asp:ListItem>Cédula Extranjería</asp:ListItem>
                        <asp:ListItem>Registro Civil</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10" colspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Nombre Completo: </strong></td>
                <td colspan="2">
                    <asp:TextBox ID="Txtnom_paciente" runat="server" Height="25px" Width="347px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Dirección: </strong></td>
                <td colspan="2">
                    <asp:TextBox ID="Txtdir_paciente" runat="server" Height="25px" Width="259px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Teléfono:</strong></td>
                <td colspan="2">
                    <asp:TextBox ID="Txttel_paciente" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong></strong></td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Celular: </strong></td>
                <td colspan="2">
                    <asp:TextBox ID="Txtcel_paciente" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"><strong></strong></td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"><strong>Estado: </strong></td>
                <td colspan="2">
                    <asp:CheckBoxList ID="ChbactivoPaciente" runat="server">
                        <asp:ListItem>Activo</asp:ListItem>
                        <asp:ListItem>Inactivo</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8" colspan="2">
                    <asp:Button ID="btguardarPaciente" runat="server" BackColor="#333333" ForeColor="White" Text="Guardar" OnClick="btguardarPaciente_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8" colspan="2">
                    <asp:Label ID="lblguardarPaciente" runat="server" Text="---"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
