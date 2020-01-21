<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MathEng.aspx.cs" Inherits="MathEng" Buffer="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Chart ID="Chart1" runat="server" BackColor="243, 223, 193" BackGradientStyle="TopBottom" Width="612px" Height="500px">
            <Series>
                <asp:Series Name="英文" Legend="Legend1" ChartArea="ChartArea1" ToolTip="#VAL"  Color="#C800CCFF">
                </asp:Series>
                <asp:Series Name="數學" Legend="Legend1" ChartArea="ChartArea1" Label="#VAL"   Color="#9900CC">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"  BackColor="#A5BFE4" BackImageTransparentColor="Transparent">
                    <AxisX>
                        <LabelStyle Interval="1" />
                    </AxisX>
                    <Area3DStyle IsRightAngleAxes="False" />
                </asp:ChartArea>
            </ChartAreas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
            <BorderSkin SkinStyle="Emboss" />
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
