<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculatorChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            font-size: medium;
            background-color: #99CCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">Simple Calculator</span></strong><br />
            <br />
            <span class="auto-style2">First Value:</span>
            <asp:TextBox ID="firstValueTextBox" runat="server" OnTextChanged="firstValueTextBox_TextChanged"></asp:TextBox>
            <br />
            <span class="auto-style2">Second Value: </span>
            <asp:TextBox ID="secondValueTextBox" runat="server" OnTextChanged="secondValueTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" Width="29px" />
&nbsp;<asp:Button ID="minusButton" runat="server" OnClick="Button2_Click" Text="-" Width="29px" />
&nbsp;<asp:Button ID="multiplicationButton" runat="server" OnClick="multiplicationButton_Click" Text="*" Width="29px" />
&nbsp;<asp:Button ID="devisionButton" runat="server" OnClick="Button4_Click" Text="/" Width="29px" />
            <br />
            <br />
        </div>
        <strong>
        <asp:Label ID="returnLabel" runat="server" CssClass="auto-style3"></asp:Label>
        </strong>
    </form>
</body>
</html>
