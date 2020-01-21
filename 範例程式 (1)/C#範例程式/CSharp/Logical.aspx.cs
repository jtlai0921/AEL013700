using System;

public partial class Logical : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool x = true;
        bool y = true;
        bool z = false;

        Response.Write("<H2>邏輯運算子的運用</H2>");
        Response.Write("x=true, y=true , z=false</BR></BR>");

        //x & y
        if (x & y)
        {
            Response.Write(string.Format("x & y運算的結果為True<br/>"));
        }
        else
        {
            Response.Write(string.Format("x & y運算的結果為False<br/>"));
        }

        //y & z (更聰明精簡的語法)
        Response.Write(string.Format("y & z運算的結果為{0}<br/>", y & z));

        //x | y | z
        if (x | y | z)
        {
            Response.Write(string.Format("x | y | z運算的結果為True<br/>"));
        }
        else
        {
            Response.Write(string.Format("x | y | z運算的結果為False<br/>"));
        }
    }
}
