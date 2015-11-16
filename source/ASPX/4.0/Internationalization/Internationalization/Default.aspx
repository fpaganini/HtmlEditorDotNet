<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Samples.Default" %>
<%@ Register Assembly="pgnWebHTMLEditor" Namespace="br.com.pgnsoft.web" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTMLEditor for .NET (ASPX)</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:htmlEditor ID="HtmlEditor1" runat="server" TranslateFile="~/fr.txt" />
        <br />
        <div>
            <asp:Button runat="server" ID="btnSend" Text="Send" OnClick="btnSend_Click" />
            <h1>Result:</h1>
            <asp:Literal runat ="server" ID="ltrResult"></asp:Literal> 
        </div>
    </div>
    </form>
</body>
</html>
