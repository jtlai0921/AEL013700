using System;
using System.Web.Configuration;

public partial class ReadAppSettings : System.Web.UI.Page
{
    protected void Page_Init()
    {
        Response.Write("<h2>�H�{��Ū�����ε{���]�w��</h2>");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
		string txtCompany = WebConfigurationManager.AppSettings["Company"];
		Response.Write("���q�W�١G" + txtCompany + "<br/>");

        string txtServiceTel = WebConfigurationManager.AppSettings["�ȪA�M�u"];
        Response.Write("�ȪA�M�u�G" + txtServiceTel + "<br/>");
    }
}
