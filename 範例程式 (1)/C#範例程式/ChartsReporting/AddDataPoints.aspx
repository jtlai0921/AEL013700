<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddDataPoints.aspx.cs" Inherits="AddDataPoints" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="Chart1" runat="server" BackColor="243, 223, 193" BackGradientStyle="TopBottom" Width="600px">
            <Series>
                <asp:Series Label="#VAL" Name="Series1" ToolTip="#VAL" Font="Microsoft Sans Serif, 18pt" LabelForeColor="Purple">
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
    </div>
    </form>
</body>
</html>
