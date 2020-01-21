using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

public partial class LoginAuthenticate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //�ϥΦۭq���������Ҩƥ�
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
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
        //string connString = "data source=.;initial catalog=aspnet4db;user id=sa;password=test";
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
