<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChartDB.aspx.cs" Inherits="ChartDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="1024px">
            <Series>
                <asp:Series Name="Series1" XValueMember="LastName" YValueMembers="SalesYTD" ToolTip="#VALX: #VAL 今年銷售量">
                </asp:Series>
                <asp:Series Name="Series2"   XValueMember="LastName" YValueMembers="SalesLastYear" ToolTip="#VALX: #VAL 去年銷售量" ChartArea="ChartArea1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="員工">
                        <LabelStyle Interval="1" />
                    </AxisX>
                </asp:ChartArea>
            </ChartAreas>
            <Titles>
                <asp:Title Name="Title1" Text="銷售業績比較表">
                </asp:Title>
            </Titles>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2012ConnectionString %>" 
            SelectCommand="select LastName, SalesYTD, SalesLastYear 
                          from HumanResources.Employee as e
                          inner join Person.Person as p on e.BusinessEntityID = p.BusinessEntityID
                          inner join Sales.SalesPerson as s on e.BusinessEntityID = s.BusinessEntityID">
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
