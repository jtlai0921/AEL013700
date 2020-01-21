using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class ChartArray : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //設定圖表標題及次標題
        Chart1.Titles.Add("第一學期，期末考成績");
        //設定3D效果
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        Chart1.Width = Unit.Pixel(800); //設定圖表寬度

        //宣告陣列資料
        string[] Names = { "Kevin", "David", "Joe", "Mary", "Debby", "Rose" };
        double[] Scores = { 100, 92, 75, 88, 90, 66 };

        //繫結X與Y軸的資料-將陣列資料繫結到Series1的DataPoint資料點
        Chart1.Series["Series1"].Points.DataBindXY(Names, Scores);
        //顯示分數
        Chart1.Series["Series1"].Label = "#VAL";    //顯示實際分數
        Chart1.Series["Series1"].LabelForeColor = Color.Red;
    }
}