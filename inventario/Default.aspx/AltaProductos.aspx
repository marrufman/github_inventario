<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaProductos.aspx.cs" Inherits="Default.aspx.AltaProductos" %>

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
        Agregar producto: <asp:TextBox ID="TextBoxNuevoProducto" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Productos" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_cat_producto" headertext="#" SortExpression="id_cat_producto" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_producto" headertext="Nombre" SortExpression="nombre_producto"/>
            <asp:ButtonField Text="Editar" CommandName="editar" ItemStyle-CssClass="tdCenter"/>
            <asp:ButtonField Text="Borrar" CommandName="borrar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
