<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_022.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            From:<br />
            <br />
            <asp:RadioButton ID="chicagoFromRadioButton" runat="server" GroupName="fromCity" Text="Chicago" />
            <br />
            <asp:RadioButton ID="newyorkFromRadioButton" runat="server" GroupName="fromCity" Text="New York" />
            <br />
            <asp:RadioButton ID="londonFromRadioButton" runat="server" GroupName="fromCity" Text="London" />
            <br />
            <br />
            To:<br />
            <br />
            <asp:RadioButton ID="chicagoToRadioButton" runat="server" GroupName="toCity" Text="Chicago" />
            <br />
            <asp:RadioButton ID="newyorkToRadioButton" runat="server" GroupName="toCity" Text="New York" />
            <br />
            <asp:RadioButton ID="londonToRadioButton" runat="server" GroupName="toCity" Text="London" />
        </div>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        </p>
        <p>
            Ticket Price: <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
