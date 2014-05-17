<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarPuntoVenta.aspx.cs" Inherits="Default.aspx.EditarPuntoVenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        Nombre del Punto de Venta: <asp:TextBox ID="TextBoxNombrePV" runat="server"></asp:TextBox>
        <br />
        Direccion Punto Venta:  <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
        <br />
        Descripcion: <asp:TextBox ID="TextBoxDescripcion" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
