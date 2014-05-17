<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detalleruta.aspx.cs" Inherits="Default.aspx.detalleruta" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Puntos de Venta de Ruta" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_punto_venta" headertext="#" SortExpression="id_punto_venta" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_pv" headertext="Nombre" SortExpression="nombre_pv"/>
            <asp:boundfield datafield="direccion_pv" headertext="Direccion" SortExpression="direccion_pv"/>
            <asp:ButtonField Text="Ver Detalle" CommandName="detalle" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Regresar" OnClick="Button3_Click" />
        <asp:Button ID="Button1" runat="server" Text="Salir" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
