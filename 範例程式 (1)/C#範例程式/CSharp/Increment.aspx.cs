using System;

public partial class Increment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        double x;

        Response.Write("<H2>++遞增運算子的運用</H2>");
        //後置遞增運算x++
        x = 1.5;
        Response.Write(string.Format("原始的x值為：{0}<br/>", x));
        Response.Write(string.Format("後置遞增運算x值為：{0}<br/>", x++));

        //前置遞增運算++x
        x = 1.5;
        Response.Write(string.Format("前置遞增運算x值為：{0}<br/>", ++x));


        //遞增運算結合for迴圈
        Response.Write("<h2>遞增運算子結合for迴圈</h2>");
        Response.Write("z++：");
        int z = 1;
        while (z <= 10)
        {
            Response.Write(z + " , ");
            z++;
        }
    }
}
