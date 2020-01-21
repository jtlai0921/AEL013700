using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Linq;

public partial class LoginViewRoleGroups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected string getFirstRole()
    {
        var roles = from R in Roles.GetRolesForUser()
                    select R;

        return roles.First();
    }

    public string getLastRole()
    {
        var roles = from R in Roles.GetRolesForUser()
                    select R;

        return roles.Last();
    }
}
