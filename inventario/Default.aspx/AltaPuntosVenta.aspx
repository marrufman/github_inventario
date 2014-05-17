<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaPuntosVenta.aspx.cs" Inherits="Default.aspx.AltaPuntosVenta" %>

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
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Puntos de Venta" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_punto_venta" headertext="#" SortExpression="id_punto_venta" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_pv" headertext="Nombre Punto Venta" SortExpression="nombre_pv"/>
            <asp:boundfield datafield="direccion_pv" headertext="Direccion" SortExpression="direccion_pv"/>
            <asp:boundfield datafield="descripcion" headertext="Detalle" SortExpression="descripcion"/>
            <asp:ButtonField Text="Editar" CommandName="editar" ItemStyle-CssClass="tdCenter"/>
            <asp:ButtonField Text="Eliminar" CommandName="borrar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
