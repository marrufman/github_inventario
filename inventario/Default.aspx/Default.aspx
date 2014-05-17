<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default.aspx.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuario:<asp:TextBox ID="TextBoxUsr" runat="server"></asp:TextBox>
        <br />
        Contraseña:<asp:TextBox ID="TextBoxPess" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Recuperar contraseña: (introduzca e-mail)" Visible="false"></asp:Label>
        <asp:TextBox ID="emailPass" runat="server" Visible="false"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="recuperar" OnClick="Button2_Click" Visible="false"/>
    </div>
    </form>
</body>
</html>
