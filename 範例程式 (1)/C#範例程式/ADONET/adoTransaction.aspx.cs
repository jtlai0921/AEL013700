using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class sqldsTransaction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected void btnInsert_Click(object sender, EventArgs e)
	{
		InsertRecord();	//�s�W���u���
	}

	//�s�W��Ʈw
	protected void InsertRecord()
	{
		string connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
		SqlConnection conn = new SqlConnection(connString);
		conn.Open();
		SqlTransaction tran = conn.BeginTransaction();	//�إߥ��Transaction

		string strSQL = "INSERT INTO Employees(FirstName, LastName, City, Address) values (@paramFirstName,@paramLastName,@paramCity,@paramAddress)";
		SqlCommand cmd = new SqlCommand(strSQL, conn,tran);		//�إ�SqlCommand

		try
		{
			cmd.Parameters.Add("@paramFirstName", SqlDbType.NVarChar, 20).Value = txtFirstName.Text;
			cmd.Parameters.Add("@paramLastName", SqlDbType.NVarChar, 10).Value = txtLastName.Text;
			cmd.Parameters.Add("@paramCity", SqlDbType.NVarChar, 15).Value = txtCity.Text;
			cmd.Parameters.Add("@paramAddress", SqlDbType.NVarChar, 60).Value = txtAddress.Text;
			cmd.ExecuteNonQuery();
			tran.Commit();		//�T�{���
            txtMsg.Text = "�s�W��Ʀ��\,����T�{!";
		}
		catch(Exception ex)
		{
			tran.Rollback();   //����^�_
            txtMsg.Text = "�s�W��ƥ���,���Rollback!,���ѭ�]���G" + ex.ToString();
		}
		finally
		{
			conn.Close();
			conn.Dispose();
			tran.Dispose();
			cmd.Dispose();
		}
	}
}
