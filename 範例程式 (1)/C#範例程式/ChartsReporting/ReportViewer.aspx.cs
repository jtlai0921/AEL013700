using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class ReportViewer : System.Web.UI.Page
{
    string mimeType = null;
    string encoding = null;
    string extension = null;
    string[] streamids;
    Microsoft.Reporting.WebForms.Warning[] warm;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //以程式輸出產生PDF檔
    protected void btnExportPDF_Click(object sender, EventArgs e)
    {
        //產生固定檔名（適合一個人使用）
        //string filePath = HttpContext.Current.Request.MapPath("~/temp/") + "EmployeesInfo.pdf";
        //建立PDF檔名唯一GUID編號（適合大量使用者）
        Guid pdfGuid = Guid.NewGuid();
        string fileName = pdfGuid + ".pdf";
        //pdf檔產生路徑
        string filePath = HttpContext.Current.Request.MapPath("~/temp/") + fileName;

        //輸出PDF格式檔
        byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warm);
        FileStream fs = new FileStream(filePath, FileMode.Create);
        fs.Write(bytes, 0, bytes.Length);
        fs.Close();
        //導向PDF的URL路徑，顯示PDF檔
        Response.Redirect("~/temp/" + fileName);
    }
}