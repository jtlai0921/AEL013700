using System;

public partial class Decrement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        double y;

        Response.Write("<H2>--遞減運算子的運用</H2>");
        //後置遞減運算y--
        y = 1.5;
        Response.Write(string.Format("原始的y值為：{0}<br/>", y));
        Response.Write(string.Format("後置遞減運算y值為：{0}<br/>", y--));

        //前置遞減運算--y
        y = 1.5;
        Response.Write(string.Format("前置遞減運算y值為：{0}<br/>", --y));

        //遞減運算結合for迴圈
        Response.Write("<h2>遞減運算子結合for迴圈</h2>");
        Response.Write("z--：");
        int z = 100;
        while (z >= 90)
        {
            Response.Write(z + " , ");
            --z;
        }
    }
}
