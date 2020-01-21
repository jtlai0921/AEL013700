﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportExport.aspx.cs" Inherits="ReportExport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>以程式將報表匯出成PDF、Word、Excel及Image檔</h2>
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" BorderWidth="1px" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="700px">
            <LocalReport ReportPath="Report4.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsEmployees" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="NorthwindDataSetTableAdapters.EmployeesTableAdapter"></asp:ObjectDataSource>
        <br /><br />
        文件輸出類型：
        <asp:DropDownList ID="dwnFileType" runat="server">
            <asp:ListItem Value="0">PDF</asp:ListItem>
            <asp:ListItem Value="1">Word</asp:ListItem>
            <asp:ListItem Value="2">Excel</asp:ListItem>
            <asp:ListItem Value="3">Image</asp:ListItem>
        </asp:DropDownList>
        　
        <asp:Button ID="btnExportPDF" runat="server" OnClick="btnExportPDF_Click" Text="輸出檔案" />
    </div>
    </form>
</body>
</html>
