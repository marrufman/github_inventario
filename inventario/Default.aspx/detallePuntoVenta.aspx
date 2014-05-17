<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detallePuntoVenta.aspx.cs" Inherits="Default.aspx.detallePuntoVenta" %>

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
        <br />Agregar Producto:
        <asp:DropDownList ID="DD_id_producto" runat="server"></asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Agregar Producto" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Productos de Punto de Venta" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_producto" headertext="#" SortExpression="id_producto" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_producto" headertext="Nombre Producto" SortExpression="nombre_producto"/>
            <asp:ButtonField Text="Capturar" CommandName="capturar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Regresar" OnClick="Button3_Click" />
        <asp:Button ID="Button2" runat="server" Text="Salir" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
