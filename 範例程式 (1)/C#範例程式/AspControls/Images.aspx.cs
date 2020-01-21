using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Images : System.Web.UI.Page
{
    protected void Page_Init()
    {
        Response.Write("<h2>以Image控制項顯示圖片</h2>");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Image2.ImageUrl = "https://8natnw.bay.livefilestore.com/y1m9CX7_TCiiF7Gh1tVyDeDTRwcCzAREl83ssH_jRz_H7xzg0wcUakjLdGAS4t_GbawV7sfQ7hEFxbJbTkF1c60LTnRsThXjGEAVxTqL6P7P5Dj2iabdoLXtw/03.jpg";
        Image2.Width = Unit.Pixel(100);
        Image2.Width = Unit.Pixel(100);
    }
}