<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admon.aspx.cs" Inherits="Default.aspx.Admon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Aadministracion del sistema
        <br />
        <asp:Button ID="Button3" runat="server" Text="Alta de Productos" OnClick="Button3_Click" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Alta de Usuarios" OnClick="Button4_Click" />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Alta de Puntos de Venta" OnClick="Button5_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Alta de Rutas" OnClick="Button2_Click" />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Alta de Atributos" OnClick="Button6_Click" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Salir" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
