<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rutas.aspx.cs" Inherits="Default.aspx.Rutas" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Rutas del Promotor" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_ruta" headertext="#" SortExpression="id_ruta" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_ruta" headertext="Nombre" SortExpression="nombre_ruta"/>
            <asp:boundfield datafield="fecha" headertext="Fecha" SortExpression="fecha"/>
            <asp:ButtonField Text="Ver Detalle" CommandName="detalle" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br /><asp:Button ID="Button7" runat="server" Text="Valida Productos Offline" OnClick="Button7_Click" />
        <br /><asp:Button ID="Button1" runat="server" Text="Salir" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
