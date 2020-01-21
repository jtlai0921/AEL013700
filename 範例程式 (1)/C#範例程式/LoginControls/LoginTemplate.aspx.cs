using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginTemplate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		//�bLogin����������ҵ{�ǡA�ˬd�O�_�q�L���ҡA�Y�q�L�h��ܨϥΪ̩m�W
        if (User.Identity.IsAuthenticated)
        {
            //��ܵn�J�ϥΪ̦W��
            ((Label)UserLogin.FindControl("txtUserName")).Text = "�w��A�G" + User.Identity.Name;
        }
        else
        {
            ((Label)UserLogin.FindControl("txtUserName")).Text = "";
        }
    }

    //�n�J���ҫe
	protected void UserLogin_LoggingIn(object sender, LoginCancelEventArgs e)
	{
        RequiredFieldValidator RV1 = (RequiredFieldValidator)UserLogin.FindControl("RV1");
        RV1.Enabled = true;
        RV1.Validate();
        RequiredFieldValidator RV2 = (RequiredFieldValidator)UserLogin.FindControl("RV2");
        RV2.Enabled = true;
        RV2.Validate();
	}

	//���Ҧ��\�n�J��
	protected void UserLogin_LoggedIn(object sender, EventArgs e)
	{
		((RequiredFieldValidator)UserLogin.FindControl("RV1")).Enabled = false;
		((RequiredFieldValidator)UserLogin.FindControl("RV2")).Enabled = false;
	}

	//�n�X
	protected void btnSignout_Click(object sender, ImageClickEventArgs e)
	{
		FormsAuthentication.SignOut();	//�n�X�A�R��Cookie
		Response.Redirect("LoginTemplate.aspx");    
	}

	//���JavaScript�T��
	protected void UserLogin_LoginError(object sender, EventArgs e)
	{
        if (Page.IsValid == true)
        {
            WebMessageBox.MessageBox.Show("�b���K�X���ҿ��~!");
        }
	}
}
