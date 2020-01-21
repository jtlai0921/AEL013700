using System;

public partial class Implicit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //int型別
        int height = 180;
        int weight = 75;

        //將int型別變數指派給long型別變數(隱含轉換)
        long h = height;
        long w = weight;

        //將int型別變數指派給float型別變數(隱含轉換)
        float h1 = height;
        float w1 = w;

        Response.Write("<H2>int、long及float型別的隱含轉換</H2>");
        Response.Write(string.Format("身高：{0}，體重：{1}（int->long型別）<br/>", h, w));
        Response.Write(string.Format("身高：{0}，體重：{1}（int->float型別）<br/>", h1, w1));
    }
}
