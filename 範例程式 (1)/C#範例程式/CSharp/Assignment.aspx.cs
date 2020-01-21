using System;

public partial class Assignment : System.Web.UI.Page
{
    protected void Page_Init()
    {
        Response.Write("<h2>指派運算子/複合指派運算子的運用</h2>");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //使用=等號指派運算子
        int x = 3;      //'使用=運算子，指派3給變數x
        int y = 5;
        int z = 7;
        decimal a = 9;
        decimal b = 11;
        string string1 = "Hello";
        string string2 = " My Friends!";

        
        string str = "x={0}，y={1}，z={2}，a={3}，b={4}，string1={5}，string2={6}<br/><br/>";
        Response.Write(String.Format(str, x, y, z, a, b, string1, string2));

        x += 5;   //使用+=運算子
        Response.Write(String.Format("x + =5結果是：{0}</br>", x));
        y -= 1;   //使用-=運算子
        Response.Write(String.Format("y -= 1結果是：{0}</br>", y));
        z ^= 2;   //使用^=運算子
        Response.Write(String.Format("z ^= 2結果是：{0}</br>", z));
        a /= 2;    //使用/=運算子
        Response.Write(String.Format("a /= 2結果是：{0}</br>", a));
        string1 += string2;  //使用+=運算子
        Response.Write(String.Format("string1 += string2結果是：{0}</br>", string1));
    }
}
