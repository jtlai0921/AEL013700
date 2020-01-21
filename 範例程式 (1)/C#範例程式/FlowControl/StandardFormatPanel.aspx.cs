using System;
using System.Globalization;
using System.Web.UI.WebControls;

public partial class StandardFormatPanel : System.Web.UI.Page
{
    DateTime date1;

    protected void Page_Load(object sender, EventArgs e)
    {
        date1 = new DateTime(2012,10,12);
        Response.Write("原始日期格式：<Font Color='Blue'>" + date1 + "</Font><BR/><BR/>");

        //使用標準日期及時間格式參數
        Response.Write("<Font Color='Blue'><<使用標準日期及時間格式參數>></Font><BR/>");
        //Panel1
        Panel1.Controls.Add(stringFormat("d"));
        Panel1.Controls.Add(stringFormat("D"));
        Panel1.Controls.Add(stringFormat("f"));
        Panel1.Controls.Add(stringFormat("F"));
        Panel1.Controls.Add(stringFormat("g"));
        Panel1.Controls.Add(stringFormat("G"));
        Panel1.Controls.Add(stringFormat("m"));
        Panel1.Controls.Add(stringFormat("M"));
        Panel1.Controls.Add(stringFormat("o"));
        Panel1.Controls.Add(stringFormat("O"));

        //Panel2
        Panel2.Controls.Add(stringFormat("r"));
        Panel2.Controls.Add(stringFormat("R"));
        Panel2.Controls.Add(stringFormat("s"));
        Panel2.Controls.Add(stringFormat("t"));
        Panel2.Controls.Add(stringFormat("T"));
        Panel2.Controls.Add(stringFormat("U"));
        Panel2.Controls.Add(stringFormat("U")); 
        Panel2.Controls.Add(stringFormat("y"));
        Panel2.Controls.Add(stringFormat("Y"));
    }

    //自訂字串格式化方法，無指定CultureInfo文化特性，但預設台灣使用zh-TW
    protected Label stringFormat(string specifier)
    {
        string param = "<li>標準格式化參數{0}-->{1}</li>";
        Label label = new Label();
        label.Text = string.Format(param, specifier, date1.ToString(specifier));
        return label;
    }


}
