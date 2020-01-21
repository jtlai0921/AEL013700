using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConvertCode : System.Web.UI.Page
{
    protected void Page_init()
    {
        Response.Write("<h2>萬用的型別轉換指令～Convert</h2>");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //數值轉字串

        /*明確轉換無法成功
        int i=100;
        string myString=(string)i;
        Response.Write(myString);
         * */

        int i = 100;
        string myString = Convert.ToString(i);
        Response.Write("myString = " + myString );
        Response.Write("。myString的型別是：" + myString.GetType() + "<br/><br/>");
        

        //字串轉數值

        /*明確轉換無法成功
        string myString="100";
        int i=(int)myString;
        Response.Write(i);
         * */

        myString = "100";
        i = Convert.ToInt32(myString);
        Response.Write("i = " + i);
        Response.Write("。i的型別是：" + i.GetType() );
    }
}