<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

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
        <strong>
        <asp:Image ID="Image1" runat="server" CssClass="auto-style1" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <br class="auto-style1" />
        <br class="auto-style1" />
        </strong><strong><span class="auto-style2">Spy New Assignment Form<br />
        <br />
        </span></strong>Spy Code Name:
        <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:
        <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment:
        <asp:Calendar ID="previousCalendar" runat="server"></asp:Calendar>
        <br />
        Start Date of New Assignment:<asp:Calendar ID="newCalendar" runat="server"></asp:Calendar>
        <br />
        Projected End Date of New Assignment:<asp:Calendar ID="endDateCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
