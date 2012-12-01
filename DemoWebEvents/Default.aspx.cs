using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Hora1.GetHoraEvent += Hora1_GetHoraEvent;
    }

    void Hora1_GetHoraEvent(object sender, DateTime e)
    {
        this.Response.Write(e.ToLongTimeString());
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.Response.Write(DateTime.Now.ToLongTimeString());
    }
}