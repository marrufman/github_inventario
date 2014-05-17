<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaUsuarios.aspx.cs" Inherits="Default.aspx.AltaUsuarios" %>

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
        Login Usuario: <asp:TextBox ID="TextBoxlogin" runat="server"></asp:TextBox>
        <br />
        Password: <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        <br />
        email: <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox> 
        <br />
        Nombre: <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        <br />
        Apellidos:  <asp:TextBox ID="TextBoxApellidos" runat="server"></asp:TextBox>
        <br />
        Perfil:<asp:DropDownList ID="DropDownListPerfil" runat="server"></asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Usuarios" OnRowCommand="botonesSeleccion">
        <Columns>
            <asp:boundfield datafield="id_usuario" headertext="#" SortExpression="id_usuario" ItemStyle-CssClass="tdCenter tdBold"/>
            <asp:boundfield datafield="nombre_usuario" headertext="Login" SortExpression="nombre_usuario"/>
            <asp:boundfield datafield="nombre" headertext="Nombre" SortExpression="nombre"/>
            <asp:boundfield datafield="apellidos" headertext="Apellidos" SortExpression="apellidos"/>
            <asp:boundfield datafield="email" headertext="email" SortExpression="email"/>
            <asp:boundfield datafield="status" headertext="Activo" SortExpression="status"/>
            <asp:boundfield datafield="nombre_perfil" headertext="Perfil" SortExpression="nombre_perfil"/>
            <asp:boundfield datafield="password_usuario" headertext="password" SortExpression="password_usuario" />
            <asp:ButtonField Text="Editar" CommandName="editar" ItemStyle-CssClass="tdCenter"/>
            <asp:ButtonField Text="Baja" CommandName="borrar" ItemStyle-CssClass="tdCenter"/>
        </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
