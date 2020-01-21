<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Images.aspx.cs" Inherits="Images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- 這是HTML的Image --%>
            <img src="https://8natnw.bay.livefilestore.com/y1m4fkXCOpiPseJScWGyn_1JDxakwD18ucgHhjvu5K16dvneJ4ELwK66452q7EFyDZay1zwjL_TFdghmiAzKdr-gCbVp97Mnv-aw-JfVUqoLGUCQ5GwPFKrFw/01.jpg" />
            <%-- 這是ASP.NET的Image控制項 --%>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://8natnw.bay.livefilestore.com/y1m-gMl_KqdRgLSA_Y7VGsYrhVwQaQeRJkqPpvIVKmq1cW0unG8YdDyrhYHEssm7v_B6T692QPBwYK60Bf-tKdKOPqj8XIcCt4YYjBpc6X-r8bSCkl6kk9D0A/02.jpg" />
            <%-- 這也是ASP.NET的Image控制項，但用C#程式設定圖片及大小 --%>
            <asp:Image ID="Image2" runat="server" />
        </div>
    </form>
</body>
</html>
