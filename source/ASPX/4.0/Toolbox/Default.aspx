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
        
        <div>
            <div>
                <h1>Select the buttons you need:</h1>
                <asp:CheckBox runat="server" ID="chkBold" AutoPostBack="true"  Text="Bold" />
                <asp:CheckBox runat="server" ID="chkItalic"  AutoPostBack="true" text="Italic"/>
                <asp:CheckBox runat="server" ID="chkUnderline"  AutoPostBack="true" Text="Underline"/>
                <asp:CheckBox runat="server" ID="chkStrykethrough"  AutoPostBack="true" Text="Strykethrough"/>
                <asp:CheckBox runat="server" ID="chkSubscript"  AutoPostBack="true" Text="Subscript"/>
                <asp:CheckBox runat="server" ID="chkSuperscript"  AutoPostBack="true" Text="Superscript"/>
                <asp:CheckBox runat="server" ID="chkUndo"  AutoPostBack="true" text="Undo"/>
                <asp:CheckBox runat="server" ID="chkRedo"  AutoPostBack="true" Text="Redo"/>
                <asp:CheckBox runat="server" ID="chkClear"  AutoPostBack="true" Text="Clear"/>
                <asp:CheckBox runat="server" ID="chkSelectAll"  AutoPostBack="true" Text="SelectAll"/>
            </div>
            <br />
            <cc1:htmlEditor ID="HtmlEditor1" runat="server"    />
            <br />
            <asp:Button runat="server" ID="btnSend" Text="Send" OnClick="btnSend_Click" />
            <h1>Result:</h1>
            <asp:Literal runat ="server" ID="ltrResult"></asp:Literal> 
        </div>
    </div>
    </form>
</body>
</html>
