using System;

public partial class Variables : System.Web.UI.Page
{
    string firstName = "Wang";  //全域變數

    protected void Page_Load(object sender, EventArgs e)
    {
        /* 不合法的例子，變數未初始化就使用 
        string lastName;
        int age;
        bool gender;
        decimal money;
        decimal rate;

        Response.Write("名字：" + lastName + "<br/>");
        Response.Write("年齡：" + age + "<br/>");
        Response.Write("性別：" + (gender == true ? "男" : "女") + "<br/>");
        Response.Write("銀行存款：" + money + "<br/>");
        Response.Write("利率：" + rate + "<br/>");
        Response.Write("一年存款利息：" + money * rate + "<br/>");
        * */

        //合法的方式，指定區域變數之初始值
        string lastName = "聖殿祭司";
        int age = 99;
        bool gender = true;    //男性為True，女性為False
        decimal money = 1000000;    //存款金額
        decimal rate = 0.035M;      //存款利率

        Response.Write("<H2>變數宣告、設定與使用</H2>");
        Response.Write("名字：" + lastName + "<br/>");
        Response.Write("年齡：" + age + "<br/>");
        Response.Write("性別：" + (gender == true ? "男" : "女") + "<br/>");
        Response.Write("銀行存款：" + money + "<br/>");
        Response.Write("利率：" + rate * 100 + "%<br/>");
        Response.Write("一年存款利息：" + money * rate + "<br/>");
    }
}
