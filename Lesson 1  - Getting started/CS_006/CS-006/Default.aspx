﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 342px;
        }
        .auto-style5 {
            width: 302px;
        }
        .auto-style6 {
            background-color: #FFFFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Head Line 1</h1>
        </div>
        <h2>Head Line 2</h2>
        <h3>Head Line 3</h3>
        <h4>Head Line 4</h4>
        <h5>Head Line 5</h5>
        <h6>Head Line 6</h6>
        <p class="auto-style1">
            This is some text that I want to <span class="auto-style2">apply</span> some style to.</p>
        <p class="auto-style1">
            <a href="http://bolddeveloper.com">Add a hyperlink.</a></p>
        <p class="auto-style1">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.bolddeveloper.com" Target="_blank">This is another hyperlink</asp:HyperLink>
        </p>
        <asp:Image ID="Image1" runat="server" Height="44px" ImageUrl="~/nav_logo.png" Width="172px" />
    </form>
    <table class="auto-style3">
        <tr>
            <td class="auto-style4">Player</td>
            <td>Year</td>
            <td class="auto-style5">Home Runs</td>
        </tr>
        <tr>
            <td class="auto-style4">Sammy Sosa</td>
            <td>2005</td>
            <td class="auto-style5">100</td>
        </tr>
        <tr>
            <td class="auto-style4">Mark MacGuare</td>
            <td>2005</td>
            <td class="auto-style5">102</td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <ul>
        <li class="auto-style6">This is an idea</li>
        <li class="auto-style6">&nbsp;This is an equally good idea</li>
        <li class="auto-style6">Yet one more good idea to consider</li>
    </ul>
</body>
</html>
