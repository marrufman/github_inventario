<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarAtributo.aspx.cs" Inherits="Default.aspx.EditarAtributo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Editar atributo: <asp:TextBox ID="TextBoxAtributo" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <br />
    </div>
    </form>
</body>
</html>
