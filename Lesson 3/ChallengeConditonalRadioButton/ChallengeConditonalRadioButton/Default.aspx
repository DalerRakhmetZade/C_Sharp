<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditonalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Prefernces<br />
            <br />
            <asp:RadioButton ID="pencilButton" runat="server" GroupName="noteTakingTool" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penButton" runat="server" GroupName="noteTakingTool" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneButton" runat="server" GroupName="noteTakingTool" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletButton" runat="server" GroupName="noteTakingTool" Text="Tablet" />
            <br />
            <br />
            <asp:Image ID="resultImage" runat="server" />
            <br />
            <br />
            <asp:Button ID="OKButton" runat="server" OnClick="OKButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
