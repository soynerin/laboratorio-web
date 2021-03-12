<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PromotoresA.aspx.cs" Inherits="TestingFormExpiredTime.PromotoresA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing Form Expired Time</title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h1>PROMOTORES A</h1>
            <asp:HyperLink runat="server" ID="ShareLink" OnDataBinding ="ShareLink_DataBinding" Text="COMPARTIR LINK"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
