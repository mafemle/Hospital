<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicos.aspx.cs" Inherits="Hostipal.Medicos" %>

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
            font-size: x-large;
        }
        .auto-style3 {
            width: 211px;
            height: 217px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            width: 732px;
            text-align: right;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            text-align: left;
            width: 218px;
            height: 35px;
        }
        .auto-style9 {
            width: 732px;
            text-align: right;
            height: 35px;
        }
        .auto-style10 {
            text-align: left;
            height: 35px;
        }
        .auto-style11 {
            width: 732px;
            text-align: right;
            height: 26px;
        }
        .auto-style12 {
            text-align: left;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3"><strong>Ingresar Médico</strong></td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="3">
                    <img id="imgMedico" alt="imgmedico" class="auto-style3" src="imagenes/medico.jpg" /></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9"><strong>Identificación:</strong></td>
                <td class="auto-style8">
                    <asp:TextBox ID="Txtid_medico" runat="server" Height="25px"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="btConsultarMedico" runat="server" BackColor="#333333" ForeColor="White" OnClick="btConsultarMedico_Click" Text="Consultar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7" colspan="2">
                    <asp:Label ID="lblConsultarMedico" runat="server" Text="---"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Nombre Completo: </strong></td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="Txtnom_medico" runat="server" Height="25px" Width="405px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Especialidad: </strong></td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="Txtespecialidad" runat="server" Height="25px" Width="259px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Teléfono:</strong></td>
                <td class="auto-style7" colspan="2">
                    <asp:TextBox ID="Txttel_medico" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>Estado:</strong></td>
                <td class="auto-style7" colspan="2">
                    <asp:CheckBoxList ID="ChbactivoMedico" runat="server">
                        <asp:ListItem>Activo</asp:ListItem>
                        <asp:ListItem>Inactivo</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td id="btnactivo" class="auto-style11"></td>
                <td class="auto-style12" colspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7" colspan="2">
                    <asp:Button ID="btguardarMedico" runat="server" BackColor="#333333" ForeColor="White" Text="Guardar" OnClick="btguardarMedico_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7" colspan="2">
                    <asp:Label ID="lblguardarMedico" runat="server" Text="---"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
