using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SampleFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*網頁載入時之事件程式
         * 顯示目前時間
         * */
        string time = getTime();
        Response.Write("現在時間是:" + time + "<br/>");
    }

    // 顯示TextBox輸入文字資料
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Response.Write("您輸入的文字是：" + txtInput.Text);
    }

    /// <summary>
    /// 取得伺服器時間方法
    /// </summary>
    /// <returns>回傳時間字串</returns>
    protected string getTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
}
