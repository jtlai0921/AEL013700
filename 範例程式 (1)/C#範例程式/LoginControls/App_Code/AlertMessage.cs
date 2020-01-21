using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// AlertMessage 的摘要描述
/// </summary>
public class AlertMessage
{
	public AlertMessage()
	{
		//
		// TODO: 在此加入建構函式的程式碼
		//
	}

	//顯示JavaScript的Alert訊息
	public void showMsg(Page thisPage,string AlertMessage)
	{
		Literal txtMsg = new Literal();
		txtMsg.Text = "<script>alert('" + AlertMessage + "')</script>" + "<BR/>";
		thisPage.Controls.Add(txtMsg);
	}
}
