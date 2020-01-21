using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class SqlAdapter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //以SqlDataAdapter注入資料到DataSet
    protected void btnFill_Click(object sender, EventArgs e)
    {
        //取得Web.config中的資料庫連線字串設定
        string connString = WebConfigurationManager.ConnectionStrings["myDBConnection"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();

        //建立SqlDataAdapter
        SqlDataAdapter da = new SqlDataAdapter("Select * From myProducts",conn);
        DataSet ds = new DataSet();     //建立DataSet資料集
        //將資料注入到DataSet之中，並命名DataTable為Products
        da.Fill(ds, "Products");    

        conn.Close();   //資料在Fill到DataSet之後，即可關閉資料庫連線
        conn.Dispose();

        gvProducts.DataSource = ds;
        gvProducts.DataBind();

        //查詢同一個DataSet,單價在20元以上的產品,並由第二個GridView顯示
        DataRow[] rows=ds.Tables["Products"].Select("Price>=20");
        gvProd.DataSource = rows.CopyToDataTable(); 
        gvProd.DataBind();
    }
}
