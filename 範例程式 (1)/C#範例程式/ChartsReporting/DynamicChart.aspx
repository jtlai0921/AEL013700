<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DynamicChart.aspx.cs" Inherits="DynamicChart" Buffer="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link media="all" href="../../../samples.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Chart ID="Chart1" runat="server" BackColor="243, 223, 193" BackGradientStyle="TopBottom">
            <Series>
                <asp:Series Label="#VAL" Name="Series1" ToolTip="#VAL">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX>
                        <LabelStyle Interval="1" />
                    </AxisX>
                </asp:ChartArea>
            </ChartAreas>
            <BorderSkin SkinStyle="Emboss" />
        </asp:Chart>
    </form>
</body>
</html>
