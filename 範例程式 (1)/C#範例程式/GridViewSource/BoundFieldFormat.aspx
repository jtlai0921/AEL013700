<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BoundFieldFormat.aspx.cs" Inherits="BoundFieldFormat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>BoundField欄位的DataFormatString字串格式化的應用</h2>

        <table class="auto-style1" style="vertical-align: top">
            <tr>
                <td valign="top">

        <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" 
            Font-Size="10pt" ForeColor="#333333" Caption="&lt;h2&gt;格式後&lt;/h2&gt;">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="ProductID" DataFormatString="{0:000#}" 
                    HeaderText="ProductID" HtmlEncode="False" InsertVisible="False" ReadOnly="True" 
                    SortExpression="ProductID">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                    SortExpression="ProductName">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="CategoryID" DataFormatString="{0:00#}" 
                    HeaderText="CategoryID" HtmlEncode="False" SortExpression="CategoryID">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C2}" 
                    HeaderText="UnitPrice" HtmlEncode="False" SortExpression="UnitPrice">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="UnitsInStock" DataFormatString="{0:00##}" 
                    HeaderText="UnitsInStock" HtmlEncode="False" SortExpression="UnitsInStock">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
                </td>
                <td valign="top">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="&lt;h2&gt;格式前&lt;/h2&gt;" CellPadding="4" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" ForeColor="#333333" Font-Size="10pt">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
                </td>
            </tr>
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString1 %>" 
            SelectCommand="SELECT Top 10 [ProductID], [ProductName], [CategoryID], [UnitPrice],[UnitsInStock] FROM [Products]">
        </asp:SqlDataSource>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
