using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class LoginAuthenticateCode : System.Web.UI.Page
{
    //�إ�Login���������
    System.Web.UI.WebControls.Login userLogin = new System.Web.UI.WebControls.Login();

    protected void Page_Load(object sender, EventArgs e)
    {
        setLoginControl();	//�I�s�إ�LoginControl
    }

    //�إ�Login���
    private void setLoginControl()
    {
        //�]�wLoin��Title
        userLogin.TitleText = "3C�|��";
        userLogin.TitleTextStyle.BackColor = Color.DarkRed;
        userLogin.TitleTextStyle.ForeColor = Color.White;
        userLogin.InstructionText = "�ϥΪ̵n�J";
        userLogin.ToolTip = "�п�J�z���|���b���K�X";
        userLogin.Width = Unit.Pixel(200);

        //�]�w���Ҧ��\��ҭn�ɦV������
        userLogin.DestinationPageUrl = "LoginMessage.aspx";

        //�]�wLogin����~�[
        userLogin.BackColor = Color.LightYellow;
        userLogin.BorderStyle = BorderStyle.Solid;
        userLogin.BorderWidth = Unit.Pixel(1);
        userLogin.Font.Size = 8;

        //�]�w�ϥΪ̦W�٤αK�X��r
        userLogin.UserNameLabelText = "�|���b��:";
        userLogin.PasswordLabelText = "�|���K�X:";
        userLogin.TextBoxStyle.BackColor = Color.LightBlue;	//�]�wTextBox�I��
        userLogin.TextBoxStyle.Width = Unit.Pixel(80);	//�]�wTextBox�e��

        //�]�w�n�J���s
        userLogin.LoginButtonText = "�n�J";
        userLogin.LoginButtonStyle.BackColor = Color.LightPink;
        userLogin.LoginButtonStyle.Font.Size = 8;

        //�]�w�O���ݩ�
        userLogin.RememberMeText = "�аO�Чڪ�����";

        //�إߦۭq�����Ҩƥ�
        userLogin.Authenticate += new AuthenticateEventHandler(userLogin_Authenticate);
        //�NLogin����[�JWeb Form
        Page.FindControl("form1").Controls.Add(userLogin);
    }

    //�ۭq����
    void userLogin_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //�Nlogin������n�J�b���@���ഫ���j�g
        userLogin.UserName = userLogin.UserName.ToUpper();

        //�o�q�i�ۭq���Ҫ��{�ǡA�Y�z�w���b������Ʈw�A�i�H�b�o�̥�ADO.NET���覡
        //�s���ۤv����Ʈw������
        //���oWeb.config���]�w����Ʈw�s�u�r��
        string connString = WebConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();

        //�Ϊ̤]�i�H�����N�s�u�r��g�b�{������
        //string connString = "data source=.;initial catalog=WebDB;user id=sa;password=test";
        SqlCommand cmd = new SqlCommand("Select top 1 ID from UserAccount Where ID=@paramID and Password=@paramPwd", conn);
        cmd.Parameters.Add("@paramID", SqlDbType.NVarChar, 12).Value = userLogin.UserName;
        cmd.Parameters.Add("@paramPwd", SqlDbType.NVarChar, 12).Value = userLogin.Password;

        //�Y�b���αK�X�ŦX�h�^�Ǥ@��Object���A�]ID���^
        //�G�����NObject�૬���r��
        string txtID = (string)cmd.ExecuteScalar();

        cmd.Dispose();
        conn.Close();
        conn.Dispose();

        //�P�_txtID�O�_���ŭȡA�D�ŭȫh��false�A�ŭȬ�true
        if (!string.IsNullOrEmpty(txtID))
        {
            e.Authenticated = true;	//���ҳq�L
        }
        else
        {
            e.Authenticated = false;//���ҥ���
        }
    }
}
