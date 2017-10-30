<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            What is your first name?&nbsp;
            <asp:TextBox ID="firstNameTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            What is your last name?&nbsp;
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Click Me" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
