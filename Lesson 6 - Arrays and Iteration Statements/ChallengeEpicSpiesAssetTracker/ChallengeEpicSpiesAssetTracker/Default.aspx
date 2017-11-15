<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <br />
            <strong><span class="auto-style2">Asset Performance Tracker</span><br class="auto-style1" />
            </strong>
            <br />
            Asset Name:
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged:
            <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
