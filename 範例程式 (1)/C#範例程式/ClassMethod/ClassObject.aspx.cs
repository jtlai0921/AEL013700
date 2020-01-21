using System;
using System.Reflection;

public partial class ClassObject : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Person Tom = new Person();  //類別實體化成物件
        //設定Tom欄位值基本資料
        Tom.lastName = "Tom";
        Tom.firstName = "Hans";
        Tom.height = 175;
        Tom.weight = 65;
        Tom.age = 40;
        Tom.gender = true;

        //將Tom的資料顯示出來
        Response.Write("<H2>Tom的基本資料</H2>");
        Response.Write(String.Format("LastName：{0}<BR/>", Tom.lastName));
        Response.Write(String.Format("FirstName：{0}<BR/>", Tom.firstName));
        Response.Write(String.Format("年齡：{0}歲<BR/>", Tom.age));
        Response.Write(String.Format("身高：{0}cm<BR/>", Tom.height));
        Response.Write(String.Format("體重：{0}Kg<BR/>", Tom.weight));
        Response.Write(String.Format("性別：{0}<BR/>", (Tom.gender == true ? "男" : "女")));

        Lady Mary = new Lady();
        //設定Mary欄位值基本資料
        Mary.lastName = "Mary";
        Mary.firstName = "Wang";
        Mary.height = 165;
        Mary.weight = 48;
        Mary.age = 25;
        Mary.gender = false;
        Mary.Hobby = "唱歌";

        //將Mary的資料顯示出來
        Response.Write("<H2>Mary的基本資料</H2>");
        Response.Write(String.Format("LastName：{0}<BR/>", Mary.lastName));
        Response.Write(String.Format("FirstName：{0}<BR/>", Mary.firstName));
        Response.Write(String.Format("年齡：{0}歲<BR/>", Mary.age));
        Response.Write(String.Format("身高：{0}cm<BR/>", Mary.height));
        Response.Write(String.Format("體重：{0}Kg<BR/>", Mary.weight));
        Response.Write(String.Format("性別：{0}<BR/>", (Mary.gender == true ? "男" : "女")));
        Response.Write(String.Format("興趣：{0}<BR/>", (Mary.gender == true ? "男" : "女")));
    }

    class Lady : Person
    {
        public string Hobby;
    }
}
