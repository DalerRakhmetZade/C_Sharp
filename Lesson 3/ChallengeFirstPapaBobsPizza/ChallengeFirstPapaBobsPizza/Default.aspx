<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style3 {
            background-color: #000000;
        }
        .auto-style4 {
            color: #000000;
        }
        .auto-style5 {
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="papaImage" runat="server" ImageUrl="~/PapaBob.png" />
            <span class="auto-style1"><strong>Papa Bob&#39;s Pizza and Software<br />
            </strong></span>
        </div>
        <asp:RadioButton ID="babySizeRadioButton" runat="server" GroupName="Size" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaSizeRadioButton" runat="server" GroupName="Size" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaSizeRadioButton" runat="server" GroupName="Size" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="Crust" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepRadioButton" runat="server" GroupName="Crust" Text="Deep Dish(+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni(+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions(+0.75)" />
        <br />
        <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers(+$0.50)" />
        <br />
        <asp:CheckBox ID="redPeppersCheckBox" runat="server" OnCheckedChanged="CheckBox4_CheckedChanged" Text="Rep Peppers(+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies(+$2)" />
        <br />
        <br />
        <strong><span class="auto-style1">Papa Bob&#39;s <span class="auto-style2">Special Deal
        <br />
        <br />
        </span></span></strong><span class="auto-style4"><span class="auto-style5">Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</span><span class="auto-style3"><br class="auto-style5" />
        <br />
        <br />
        </span>
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        </span>
        <asp:Label ID="totalLabel" runat="server" Text="Total: $0.00"></asp:Label>
        <br />
        <asp:Label ID="returnLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only...we need a better website! </form>
</body>
</html>
