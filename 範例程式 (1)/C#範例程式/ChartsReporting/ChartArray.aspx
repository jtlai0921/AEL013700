<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChartArray.aspx.cs" Inherits="ChartArray" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>以直條圖顯示考試成績－陣列的資料繫結</h2>
    <div>
        <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series Name="Series1" Font="Microsoft Sans Serif, 20pt"  >
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    
    </div>
    </form>
</body>
</html>
