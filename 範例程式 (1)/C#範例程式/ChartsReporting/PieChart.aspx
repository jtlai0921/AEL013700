<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PieChart.aspx.cs" Inherits="PieChart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>&nbsp;</h2>
    <div>
        <asp:Chart ID="Chart1" runat="server" Width="400px">
            <Series>
                <asp:Series ChartType="Pie" Name="Series1" Label="#VAL{C}" Legend="Legend1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
            <Titles>
                <asp:Title Name="Title1" Text="小美的每月開支百分比">
                </asp:Title>
            </Titles>
        </asp:Chart>
    
        <asp:Chart ID="Chart2" runat="server" Width="400px">
            <Series>
                <asp:Series Name="Series1" ChartType="Pie" Legend="Legend1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
            <Titles>
                <asp:Title Name="Title1" Text="小美的每月開支金額">
                </asp:Title>
            </Titles>
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
