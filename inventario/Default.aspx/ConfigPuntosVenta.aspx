<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfigPuntosVenta.aspx.cs" Inherits="Default.aspx.ConfigPuntosVenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Ruta: <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Caption="Puntos de venta disponibles" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_punto_venta" headertext="#" SortExpression="id_punto_venta" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_pv" headertext="Nombre de Punto de Venta" SortExpression="nombre_pv"/>
            <asp:boundfield datafield="direccion_pv" headertext="Direccion" SortExpression="direccion_pv"/>
            <asp:boundfield datafield="descripcion" headertext="Descripcion" SortExpression="descripcion"/>
            <asp:ButtonField Text="agregar" CommandName="agregar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView> 
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Puntos de venta asignados" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_punto_venta" headertext="#" SortExpression="id_punto_venta" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_pv" headertext="Nombre de Punto de Venta" SortExpression="nombre_pv"/>
            <asp:boundfield datafield="direccion_pv" headertext="Direccion" SortExpression="direccion_pv"/>
            <asp:boundfield datafield="descripcion" headertext="Descripcion" SortExpression="descripcion"/>
            <asp:ButtonField Text="eliminar" CommandName="eliminar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
