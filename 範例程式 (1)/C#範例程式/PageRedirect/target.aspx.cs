using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class target : System.Web.UI.Page
{
    protected void Page_Init()
    {
        Response.Write("<h2>讀取查詢字串參數</h2>");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //讀取來源網頁傳送之資料參數
        string Name = Request.QueryString["Name"];
        string Tel = Request.QueryString["Tel"];
        string City = Request.QueryString["City"];
        //顯示資料
        Response.Write(string.Format("您的基本資料如下：<br/>姓名：{0}<br/>電話：{1}<br/>居住縣市：{2}", Name, Tel, City));
    }
}
