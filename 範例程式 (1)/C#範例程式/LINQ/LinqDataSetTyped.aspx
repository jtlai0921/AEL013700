﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqDataSetTyped.aspx.cs" Inherits="LinqDataSetTyped" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>以LINQ查詢強型別DataSet</h2>
        <asp:Button ID="btnRead" runat="server" Text="讀取員工基本資料"
            OnClick="btnRead_Click" /><br /><br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" Font-Size="10pt"
            ForeColor="#333333">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </form>
</body>
</html>
