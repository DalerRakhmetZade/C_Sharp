﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
            <br />
            <br />
            <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
            <br />
            <br />
            If you could only eat one food for the rest of your life, whar would you choose?<br />
            <asp:RadioButton ID="pizzaButton" runat="server" Checked="True" GroupName="FoodGroup" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pizza" />
            <br />
            <asp:RadioButton ID="saladButton" runat="server" GroupName="FoodGroup" Text="Salad" />
            <br />
            <asp:RadioButton ID="pbjButton" runat="server" GroupName="FoodGroup" Text="Peanut Butter and Jelly" />
            <br />
            <br />
            <br />
            <asp:Button ID="OKButton" runat="server" OnClick="Button1_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
