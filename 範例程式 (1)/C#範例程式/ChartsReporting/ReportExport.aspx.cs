using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class ReportExport : System.Web.UI.Page
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
        //輸出檔案
        byte[] bytes = ReportViewer1.LocalReport.Render(dwnFileType.SelectedItem.Text, null, out mimeType, out encoding, out extension, out streamids, out warm);

        Response.Clear();
        Response.Buffer = true;
        Response.ContentType = mimeType;
        Response.AddHeader("content-disposition", "attachment ; filename=EmployeesInfo." + extension);
        Response.BinaryWrite(bytes);
        Response.Flush();
        Response.End();
    }
}