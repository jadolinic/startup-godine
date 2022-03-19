using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string s = Request.QueryString.ToString();

        if (Request.QueryString.ToString()=="pocetna")
            lnk_pocetna.Style.Add("color", "orange");

        if (Request.QueryString.ToString()=="info")
            lnk_info.Style.Add("color", "orange");

        if (Request.QueryString.ToString() == "kontakt")
            lnk_kontakt.Style.Add("color", "orange");

        if (Request.QueryString.ToString() == "treneri")
            lnk_treneri.Style.Add("color", "orange");

        if (Request.QueryString.ToString() == "multimedija")
            lnk_multimedija.Style.Add("color", "orange");

        if (Request.QueryString.ToString() == "obavijesti")
            lnk_obavijesti.Style.Add("color", "orange");

        if ((string)Session["admin"] == "da")
        {
            btn_odjava.Visible = true;
        }

    }

    protected void btn_odjava_Click(object sender, EventArgs e)
    {
        Session["admin"] = "ne";
        btn_odjava.Visible = false;
        Server.Transfer(Request.Path);
    }
}