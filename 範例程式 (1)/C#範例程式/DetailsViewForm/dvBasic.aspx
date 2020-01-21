﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dvBasic.aspx.cs" Inherits="dvBasic" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>以DetailsView控制項顯示員工基本資料</h3>
        <asp:DetailsView ID="dvEmp" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" BackColor="White" BorderColor="#E7E7FF" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="EmployeeID" 
            DataSourceID="SqlEmps" Font-Size="10pt" 
            HeaderText="&lt;div align='Center'&gt;員工基本資料&lt;/div&gt;" Height="50px" 
            Width="260px" onitemdeleting="dvEmps_ItemDeleting">
            <PagerSettings FirstPageImageUrl="~/Images/First.gif" 
                LastPageImageUrl="~/Images/Last.gif" Mode="NextPreviousFirstLast" 
                NextPageImageUrl="~/Images/Next.gif" 
                PreviousPageImageUrl="~/Images/Previous.gif" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Center" />
            <Fields>
                <asp:ImageField DataImageUrlField="PhotoPath" HeaderText="Photo">
                </asp:ImageField>
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID">
                </asp:BoundField>
                <asp:BoundField DataField="LastName" HeaderText="LastName" 
                    SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                    SortExpression="FirstName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" 
                    SortExpression="Country" />
            </Fields>
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <AlternatingRowStyle BackColor="#F7F7F7" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlEmps" runat="server" 
            ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
            DeleteCommand="DELETE FROM [Employees] WHERE [EmployeeID] = @EmployeeID" 
            InsertCommand="INSERT INTO [Employees] ([LastName], [FirstName], [City], [Country], [PhotoPath]) VALUES (@LastName, @FirstName, @City, @Country, @PhotoPath)" 
            SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [City], [Country], [PhotoPath] FROM [Employees]" 
            UpdateCommand="UPDATE [Employees] SET [LastName] = @LastName, [FirstName] = @FirstName, [City] = @City, [Country] = @Country, [PhotoPath] = @PhotoPath WHERE [EmployeeID] = @EmployeeID">
            <DeleteParameters>
                <asp:Parameter Name="EmployeeID" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="PhotoPath" Type="String" />
                <asp:Parameter Name="EmployeeID" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="Country" Type="String" />
                <asp:Parameter Name="PhotoPath" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
    </div>
    </form>

 
</body>
</html>
