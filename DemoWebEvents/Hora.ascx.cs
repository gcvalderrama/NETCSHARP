using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hora : System.Web.UI.UserControl
{

    public event EventHandler<DateTime> GetHoraEvent; 

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        this.txtHora.Text = DateTime.Now.ToLongTimeString();

        if (GetHoraEvent != null)
            this.GetHoraEvent(this, DateTime.Now);

    }
}