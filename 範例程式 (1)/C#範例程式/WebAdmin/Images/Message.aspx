<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Message.aspx.cs" Inherits="Backup_Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Images資料夾，僅限授權者存取</h2>
        <div>
            如果您看得見這段文字，表示你已通過授權
         
            <br />
            <br />
            使用者帳號：<asp:LoginName ID="LoginName1" runat="server" ForeColor="Blue" />
        </div>
    </form>
</body>
</html>
