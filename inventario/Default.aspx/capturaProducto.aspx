<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="capturaProducto.aspx.cs" Inherits="Default.aspx.capturaProducto" %>

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
        Atributo:
        <asp:DropDownList ID="DD_id_atributo_producto" runat="server"></asp:DropDownList>
        Valor del atributo:
        <asp:TextBox ID="TextBoxValorAtributo" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Atributos del Producto">
        <Columns>
            <asp:boundfield datafield="nombre_atributo" headertext="Atributo" SortExpression="nombre_atributo"/>
            <asp:boundfield datafield="detalle_txt" headertext="Valor" SortExpression="detalle_txt"/>
        </Columns>
        </asp:GridView>
        <asp:Button ID="Button3" runat="server" Text="Regresar" OnClick="Button3_Click" />
        <asp:Button ID="Button2" runat="server" Text="Salir" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
