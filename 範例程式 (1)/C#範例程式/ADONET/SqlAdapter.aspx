<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlAdapter.aspx.cs" Inherits="SqlAdapter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 408px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/SqlDataAdapter.jpg" />
        <br /><br />
    
        <asp:Button ID="btnFill" runat="server" onclick="btnFill_Click" 
            Text="將資料Fill到DataSet" />
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" valign="top">
        <asp:GridView ID="gvProducts" runat="server" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" Font-Size="10pt" 
            ForeColor="Black" Caption="第一個GridView">
            <FooterStyle BackColor="Tan" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
    
                </td>
                <td valign="top">
        <asp:GridView ID="gvProd" runat="server" BackColor="White" 
            BorderColor="#E7E7FF" BorderWidth="1px" CellPadding="3" Font-Size="10pt" BorderStyle="None" Caption="第二個GridView">
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" 
                HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" ForeColor="#F7F7F7" Font-Bold="True" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    
                </td>
            </tr>
        </table>
        <br />
    </div>
    </form>
</body>
</html>
