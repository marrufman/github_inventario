<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarRuta.aspx.cs" Inherits="Default.aspx.EditarRuta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Editar Ruta"></asp:Label>
        <br />
        Nombre Ruta: <asp:TextBox ID="TextBoxNombreRuta" runat="server"></asp:TextBox>
        <br />
        Fecha: <asp:Calendar ID="CalendarFecha" runat="server"></asp:Calendar>
        <br />
        Estado:<asp:DropDownList ID="DropDownListEstado" runat="server">
            <asp:ListItem Value="1">Ruta Abierta</asp:ListItem>
            <asp:ListItem Value="0">Ruta Cerrada</asp:ListItem>
        </asp:DropDownList>
        <br />
        Promotor: <asp:DropDownList ID="DropDownListPromotor" runat="server"></asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
