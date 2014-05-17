<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidaProductos.aspx.cs" Inherits="Default.aspx.ValidaProductos" %>

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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Productos Capturados Offline">
        <Columns>
            <asp:boundfield datafield="fecha" headertext="fecha" SortExpression="fecha" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_ruta" headertext="Ruta" SortExpression="nombre_ruta"/>
            <asp:boundfield datafield="nombre_pv" headertext="Punto de Venta" SortExpression="nombre_pv"/>
            <asp:boundfield datafield="direccion_pv" headertext="Direccion" SortExpression="direccion_pv"/>
            <asp:boundfield datafield="descripcion" headertext="Descripcion" SortExpression="descripcion"/>
            <asp:boundfield datafield="nombre_producto" headertext="Producto" SortExpression="nombre_producto"/>
            <asp:boundfield datafield="nombre_atributo" headertext="Atributo" SortExpression="nombre_atributo"/>
            <asp:boundfield datafield="valor" headertext="Valor" SortExpression="valor"/>
            <asp:ButtonField Text="Validar" CommandName="validar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
