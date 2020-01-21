using System;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;

public partial class AddDataPoints : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Step 1:設定外觀樣式
        Chart1.Width = Unit.Pixel(800); //設定圖表寬度

        //設定3D效果
        //Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

        //設定Column預設的樣式
        Chart1.Series["Series1"]["DrawingStyle"] = "Emboss";    
       
        //設定圖表標題及副標題
        Chart1.Titles.Add("英文會話成績");
        Chart1.Titles.Add("第一次測試");

        //Step 2:宣告坐標軸資料 
        //以陣列宣告(x,y)- (name,score)
        string[] Names = { "Kevin", "John", "Joyce", "Mary", "Rose", "Debby", "Bob", "Michael" };
        double[] Scores = { 100, 92, 75, 64, 52, 79.5, 55, 88.5 };

        //以LINQ查詢最高及最低分
        var score = from s in Scores
                    select s;

        double max = score.Max();
        double min = score.Min();

        double Grade = 0;
        //Step 3:座標點資料逐一加入Series數列
        for (int i = 0; i < Scores.Length; i++)
        {
            //全體加加，考試成績多5%
            Grade = Scores[i] * 1.05;
            if (Grade > 100) { Grade = 100; }
            Chart1.Series["Series1"].Points.AddXY(Names[i], Grade);
            Chart1.Series["Series1"].Points[i].ToolTip = "原始分數為：" + Scores[i];

            //對最高分成績設定特別樣式
            if (Scores[i] == max)
            {
                Chart1.Series["Series1"].Points[i]["DrawingStyle"] = "Cylinder";
                Chart1.Series["Series1"].Points[i].Color = Color.Orange;
            }

            //對最低分成績設定特別樣式
            if (Scores[i] == min)
            {
                Chart1.Series["Series1"].Points[i]["DrawingStyle"] = "Wedge";
                Chart1.Series["Series1"].Points[i].Color = Color.Red;
            }
        }
    }
}