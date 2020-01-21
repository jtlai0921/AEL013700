<%@ WebHandler Language="C#" Class="ImageHandler" %>

using System;
using System.Web;
using System.IO;
using System.Configuration;

public class ImageHandler : IHttpHandler 
{
    public void ProcessRequest(HttpContext context)
    {
        //取得員工代號
        string EmployeeID=context.Request.QueryString["EmployeeID"];
        //透過ReadImage類別的GetImage()方法取得SQL Server中圖片資料
        Byte[] PhotoImage = new ReadImage().GetImage(EmployeeID);
        if (PhotoImage != null)
        {
            //回傳二進位圖片資料
            context.Response.ContentType = "image/Jpeg";
            context.Response.OutputStream.Write(PhotoImage, 0, PhotoImage.Length);
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