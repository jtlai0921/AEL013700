using System;

public partial class Explicit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //字串型別的日期
        string dateString = "October 12 , 2012";

        //x與y為兩種不同的數值型別
        float x = 10000.8f;
        double y = 9999.3d;

        //將字串轉換成DateTime型別
        Response.Write("<h2>將String轉換成DateTime型別</h2>");
        DateTime today = Convert.ToDateTime(dateString);
        Response.Write("今天是：" + today.ToLongDateString() + "<br/>");
        Response.Write("變數：" + String.Format("x={0} , y={1}", x, y));

        //進行x與y的數學計算
        Response.Write("<h2>未明確轉換，x及y仍維持原來float與double型別（有誤差）</h2>");
        Response.Write("x - y = " + (x - y) + "<br/>");
        Response.Write("x * y = " + (x * y) + "<br/>");

        Response.Write("<h2>明確轉換，將x及y以(decimal)轉換成dcimal型別（精確）</h2>");
        Response.Write("x - y = " + ((decimal)x - (decimal)y) + "<br/>");
        Response.Write("x * y = " + ((decimal)x * (decimal)y) + "<br/>");

        Response.Write("<h2>明確轉換，將x及y以Convert.ToDecimal()轉換成decimal型別（精確）</h2>");
        Response.Write("x - y = " + (Convert.ToDecimal(x) - Convert.ToDecimal(y)) + "<br/>");
        Response.Write("x * y = " + (Convert.ToDecimal(x) * Convert.ToDecimal(y)) + "<br/>");
    }
}
