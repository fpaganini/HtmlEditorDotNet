<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InHTML.Default" %>

<%@ Register Src="~/htmleditor.ascx" TagPrefix="uc1" TagName="htmleditor" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTMLEditor for DOTNET</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.min.css" />
    <link href="resources/pgn_html_editor.css" rel="stylesheet" />
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
        <uc1:htmleditor runat="server" id="htmleditor" />
    </form>

    

    


</body>
</html>
