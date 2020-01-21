<%@ WebHandler Language="C#" Class="ImageHandler" %>

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public class ImageHandler : IHttpHandler 
{
    //取得資料庫連線設定
    static ConnectionStringSettings connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString1"];

    public void ProcessRequest(HttpContext context)
    {
        Byte[] PhotoImage = null;
        try
        {
            //取得員工代號
            string EmployeeID = context.Request.QueryString["EmployeeID"];
            //建立Sql命令
            string strSQL = "Select Photo from Employees where EmployeeID=@paramEmployeeID";
            //建立SqlDataSource
            SqlDataSource sqldsPhoto = new SqlDataSource(connString.ConnectionString, strSQL);
            //以EmployeeID查詢圖片資料
            sqldsPhoto.SelectParameters.Add("paramEmployeeID", TypeCode.Int32, EmployeeID);
            //透過SqlDataSource進行查詢
            DataView dv = (DataView)sqldsPhoto.Select(DataSourceSelectArguments.Empty);
            //回傳DataView第一個Row的Photo欄位資料
            PhotoImage = (Byte[])dv[0]["Photo"];
        }
        finally
        {
            if (PhotoImage != null || PhotoImage.Length!=0)
            {
                //回傳二進位圖片資料
                context.Response.ContentType = "image/Jpeg";
                context.Response.OutputStream.Write(PhotoImage, 0, PhotoImage.Length);
            }
        }
    }
 
    public bool IsReusable 
    {
        get 
        {
            return false;
        }
    }
}