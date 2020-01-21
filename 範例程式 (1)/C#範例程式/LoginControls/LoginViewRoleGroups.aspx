<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginViewRoleGroups.aspx.cs"
    Inherits="LoginViewRoleGroups" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <h2>RoleGroups群組樣板的運用</h2>
    <asp:LoginView ID="LoginView1" runat="server">
        <LoggedInTemplate>
            &nbsp;<asp:Label ID="Label1" runat="server" Text="歡迎您"></asp:Label>
            <asp:LoginStatus ID="LoginStatus2" runat="server" LoginImageUrl="~/Images/LoginImg.png"
                LogoutImageUrl="~/Images/LogoutImg.png" />
        </LoggedInTemplate>
        <AnonymousTemplate>
            &nbsp;<asp:Label ID="Label2" runat="server" Text="請您登入"></asp:Label>
            <asp:LoginStatus ID="LoginStatus1" runat="server" LoginImageUrl="~/Images/LoginImg.png"
                LogoutImageUrl="~/Images/LogoutImg.png" />
        </AnonymousTemplate>
        <RoleGroups>
            <asp:RoleGroup Roles="Sales">
                <ContentTemplate>
                    群組：<% = getLastRole() %> <br /> 
                    <asp:Image ID="imgSales" runat="server" ImageUrl="~/Images/Sales.jpg" /><br />
                    <asp:Label ID="Label3" runat="server" Text="月底銷售全力衝刺!" Width="200px"></asp:Label>
                    <asp:LoginStatus ID="LoginStatus3" runat="server" LoginImageUrl="~/Images/LoginImg.png"
                        LogoutImageUrl="~/Images/LogoutImg.png" />
                </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="MIS">
                <ContentTemplate>
                　　群組：<% = getLastRole() %> <br /> 
                    <asp:Image ID="imgMis" runat="server" ImageUrl="~/Images/Mis.jpg" /><br />
                    <asp:Label ID="Label4" runat="server" Text="BI系統導入大家多努力!" Width="210px"></asp:Label>
                    <asp:LoginStatus ID="LoginStatus4" runat="server" LoginImageUrl="~/Images/LoginImg.png"
                        LogoutImageUrl="~/Images/LogoutImg.png" />
                </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="RD">
                <ContentTemplate>
                    群組：<% = getLastRole() %> <br /> 
                    <asp:Image ID="imgRD" runat="server" ImageUrl="~/Images/RD.jpg" /><br />
                    <asp:Label ID="Label5" runat="server" Text="新產品加速研發!" Width="200px"></asp:Label>
                    <asp:LoginStatus ID="LoginStatus5" runat="server" LoginImageUrl="~/Images/LoginImg.png"
                        LogoutImageUrl="~/Images/LogoutImg.png" />
                </ContentTemplate>
            </asp:RoleGroup>
        </RoleGroups>
    </asp:LoginView>
    </form>
</body>
</html>
