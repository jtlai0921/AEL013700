<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LabelControl.aspx.cs" Inherits="LabelControl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>未命名頁面</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <asp:Label ID="txtInfo" runat="server" BackColor="#FFFF99" Font-Names="標楷體" ForeColor="Blue"
            Text="這是Label控制項" ToolTip="Hello...Label控制項" Width="200px"></asp:Label>
        <br /><br />
        <asp:Label ID="txtPrg" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
