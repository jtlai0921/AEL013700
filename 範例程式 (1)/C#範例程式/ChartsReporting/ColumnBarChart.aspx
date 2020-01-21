<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ColumnBarChart.aspx.cs" Inherits="ColumnBarChart" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>建立基本的Column Chart與Bar Chart</h2>
    <div>
        <asp:Chart ID="Chart1" runat="server" Height="372px" Width="626px" BorderlineDashStyle="Solid" BorderlineColor="Black">
            <series>
                <asp:Series Legend="Legend1" Name="營業額">
                    <Points>
                        <asp:DataPoint YValues="6" />
                        <asp:DataPoint YValues="3" />
                        <asp:DataPoint YValues="7" />
                        <asp:DataPoint YValues="8" />
                        <asp:DataPoint YValues="9" />
                        <asp:DataPoint YValues="5" />
                    </Points>
                </asp:Series>
                <asp:Series ChartArea="ChartArea2" ChartType="Bar" Legend="Legend2" Name="利潤" Color="Orange">
                    <Points>
                        <asp:DataPoint YValues="5" />
                        <asp:DataPoint YValues="2" />
                        <asp:DataPoint YValues="6" />
                        <asp:DataPoint YValues="7" />
                        <asp:DataPoint YValues="8" />
                        <asp:DataPoint YValues="4" />
                    </Points>
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisY Title="單位(百萬)" Interval="2">
                    </AxisY>
                    <AxisX Title="月份" Interval="1" >
                    </AxisX>
                    <Area3DStyle Enable3D="True" />
                </asp:ChartArea>
                <asp:ChartArea Name="ChartArea2">
                    <AxisY Title="單位(十萬)">
                    </AxisY>
                    <AxisX Title="月份">
                    </AxisX>
                </asp:ChartArea>
            </chartareas>
            <Legends>
                <asp:Legend DockedToChartArea="ChartArea1" IsDockedInsideChartArea="False" Name="Legend1" Title="直立Column Chart" BorderColor="Black">
                </asp:Legend>
                <asp:Legend DockedToChartArea="ChartArea2" Name="Legend2" Title="橫向Bar Chart" BorderColor="Black">
                </asp:Legend>
            </Legends>
            <Titles>
                <asp:Title Name="Title" Text="2012年度業務會議">
                </asp:Title>
                <asp:Title Name="SubTitle" Text="1~6月份營業額">
                </asp:Title>
            </Titles>
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
