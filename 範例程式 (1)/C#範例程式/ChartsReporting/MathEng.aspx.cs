using System;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;

public partial class MathEng : System.Web.UI.Page
{
    protected void Page_Preinit()
    {
        Response.Clear();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Step 1:設定外觀樣式
        /*設定3D效果**/
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 30;
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Rotation = -145;
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Perspective = 0;
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.PointDepth = 150;
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.WallWidth = 0;
         
        //設定Column預設的樣式
        Chart1.Series["英文"]["DrawingStyle"] = "Emboss";
        Chart1.Series["數學"]["DrawingStyle"] = "Cylinder";
        Chart1.Width = Unit.Pixel(800); //設定圖表寬度

        //設定圖表標題及次標題
        Chart1.Titles.Add("英文及數學成績");
        Chart1.Titles.Add("期末考");

        //Step 2:宣告坐標軸資料 
        //以陣列宣告(x,y)- (name,score)
        string[] Names = { "Kevin", "John", "Joyce", "Steve", "Mary", "Rose", "Debby", "Bob", "Tom", "Larry", "Michael" };
        double[] ScoresEng = { 100, 92, 75, 59, 64, 52, 79.5, 55, 52, 72, 88.5 };
        double[] ScoresMath = { 88, 72, 95, 60, 83, 72, 80, 69, 72, 82, 91};


        //以LINQ查詢最高及最低分
        var scoreEng = from s in ScoresEng
                    select s;

        double maxEng = scoreEng.Max();
        double minEng = scoreEng.Min();

        //Step 3:座標點資料逐一加入Series數列
        for (int i = 0; i < ScoresEng.Length; i++)
        {
            Chart1.Series["英文"].Points.AddXY(Names[i], ScoresEng[i]);
            Chart1.Series["數學"].Points.AddXY(Names[i], ScoresMath[i]);
        }
    }
}