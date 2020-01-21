<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>未命名頁面</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>輸入您的姓名</h2>
        <asp:Label ID="Label1" runat="server" Text="姓名 :"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BorderColor="#CCCCCC" BorderStyle="Ridge" >這是TextBox控制項</asp:TextBox> &nbsp;
        <asp:Button ID="btnOK" runat="server" Text="確定" Width="100px" />
    </div>
    </form>
</body>
</html>
