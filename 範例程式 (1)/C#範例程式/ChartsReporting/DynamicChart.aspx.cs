using System;
using System.Drawing;
using System.Linq;
using System.Web.UI.WebControls;
public partial class DynamicChart : System.Web.UI.Page
{

    protected void Page_Preinit()
    {
        Response.Clear();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //設定圖表標題及次標題
        Chart1.Titles.Add("英文會話成績");
        Chart1.Titles.Add("第一次測試");
        //設定3D效果
        //Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

        Chart1.Width = Unit.Pixel(800); //設定圖表寬度

        //宣告double型別的陣列資料
        double[] Scores = { 100,92,75,59,64,52,79.5,55,52,72,88.5};
        string[] Names = { "Kevin","John","Joyce","Steve","Mary","Rose","Debby","Bob","Tom","Larry","Michael"};

        //以LINQ查詢最大及最小值
        var score = from s in Scores
                    select s;

        double max = score.Max();
        double min = score.Min();
        
        //逐一加入座標點資料
        for (int i = 0; i < Scores.Length; i++)
        {
            Chart1.Series["Series1"].Points.AddXY(Names[i],Scores[i]);

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
         

        //或用DataBind
        //Chart1.Series["Series1"].Points.DataBindY(Scores);



        //設定第點的資料及屬性
        //Chart1.Series["Series1"].Points[1].Color = Color.Red;
        //Chart1.Series["Series1"].Points[Scores.Length-1].Color = Color.Orange;

        //以程式動態加入最後一個＂點＂，且對＂點＂設定眾多資料及屬性
        /*
        System.Web.UI.DataVisualization.Charting.DataPoint p = new System.Web.UI.DataVisualization.Charting.DataPoint();
        p.SetValueY(95);
        p.ToolTip = "最後一個點";
        p["DrawingStyle"] = "Cylinder";
        p.BorderColor = Color.Black;
        p.BorderDashStyle = ChartDashStyle.Solid;
        p.AxisLabel = "Johnson-Dynamic";
        Chart1.Series["Series1"].Points.Add(p);
        Chart1.Series["Series1"].ChartArea = "ChartArea1";
        Chart1.Series["Series1"]["PointWidth"] = "0.5";
         * */


        //設定繪圖樣式
        /*
        Chart1.Series["Series1"]["DrawingStyle"] = "Cylinder";
        Chart1.Series["Series1"].Points[1]["DrawingStyle"] = "Emboss";
        Chart1.Series["Series1"]["DrawingStyle"] = "Wedge";
         * */
    }
}