<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="Default.aspx.EditarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
        Estado:<asp:DropDownList ID="DropDownList1Estado" runat="server">
            <asp:ListItem Value="1">Activo</asp:ListItem>
            <asp:ListItem Value="0">Inactivo</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Regresar" OnClick="Button2_Click" />
        <br />
    </div>
    </form>
</body>
</html>
