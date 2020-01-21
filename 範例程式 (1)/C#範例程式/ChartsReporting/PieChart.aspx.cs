using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

public partial class PieChart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
        Chart2.Series["Series1"].ChartType = SeriesChartType.Pie;
        Chart2.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

        //假設小美月收入50,000元
        string[] xValues = { "食", "衣", "住", "行", "育", "樂", "儲蓄", "其他雜項" };
        double[] yValues = { 10000, 3000, 8000, 5300, 5700, 8000, 5600, 4400 };
        Chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
        Chart2.Series["Series1"].Points.DataBindXY(xValues, yValues);

        //顯示百分比-{}括號內P1為取小數點2位數
        Chart1.Series["Series1"].Label = "#PERCENT{P2}";
        //顯示實際花費金額-{}括號內C1為取小數點1位數
        Chart2.Series["Series1"].Label = "#VAL{C1}";

        //設定Legend圖例名稱
        for (int i = 0; i < xValues.Length; i++)
        {
            Chart1.Series["Series1"].Points[i].LegendText = xValues[i];
            Chart2.Series["Series1"].Points[i].LegendText = xValues[i];
        }
    }
}