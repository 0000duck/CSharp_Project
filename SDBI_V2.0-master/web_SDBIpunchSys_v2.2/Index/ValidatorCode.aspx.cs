using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ValidatorCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BLL.Viladator v = new BLL.Viladator();
        Session["ViladatoeCode"] = v.CreateCode(4).Trim(); ;
        byte[] vImg = v.CreateValidatorCode(Session["ViladatoeCode"].ToString());
        Response.ClearContent();
        Response.ContentType = "image/Gif";
        Response.BinaryWrite(vImg);
    }
    
}