<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaRutas.aspx.cs" Inherits="Default.aspx.AltaRutas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Alta de ruta"></asp:Label>
        <br />
        Nombre Ruta: <asp:TextBox ID="TextBoxNombreRuta" runat="server"></asp:TextBox>
        <br />
        Fecha: <asp:Calendar ID="CalendarFecha" runat="server"></asp:Calendar>
        <br />
        Promotor: <asp:DropDownList ID="DropDownListPromotor" runat="server"></asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Rutas" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_ruta" headertext="#" SortExpression="id_ruta" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_ruta" headertext="Descripcion" SortExpression="nombre_ruta"/>
            <asp:boundfield datafield="fecha" headertext="Fecha" SortExpression="fecha"/>
            <asp:boundfield datafield="estatus" headertext="Abierta" SortExpression="estatus"/>
            <asp:boundfield datafield="nombre_usuario" headertext="Promotor" SortExpression="nombre_usuario"/>
            <asp:ButtonField Text="Editar" CommandName="editar" ItemStyle-CssClass="tdCenter"/>
            <asp:ButtonField Text="Puntos de Venta" CommandName="configurar" ItemStyle-CssClass="tdCenter"/>
            <asp:ButtonField Text="Eliminar" CommandName="borrar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
