using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using System.Data.OleDb;

public partial class admin : System.Web.UI.Page
{
    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\korisnici.accdb";


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        if ((string)Session["admin"] == "da")
        {
            txtKorIme.Visible = false;
            txtLoz.Visible = false;
            lblKorIme.Visible = false;
            lblLoz.Visible = false;
            Button1.Visible = false;
        }

        else
        {
            
            lblKorIme.Visible = true;
            lblLoz.Visible = true;
            Button1.Visible = true;
            txtKorIme.Visible = true;
            txtLoz.Visible = true;
        }
}
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int flag = 0;
        OleDbConnection conn = new OleDbConnection(connectionString);
        conn.Open();
        OleDbCommand cm = new OleDbCommand("select * from korisnici_acc", conn);
        OleDbDataReader dr = cm.ExecuteReader();
        while (dr.Read())
        {
            if (dr["korisnicko_ime"].ToString() == txtKorIme.Text & dr["lozinka"].ToString() == MojHash.hash_alg(txtLoz.Text, dr["salt"].ToString()))
            {
                flag = 1;
                Session["admin"] = "da";
                Session["korisnik"] = "ne";
                dr.Close();
                conn.Close();
                Response.Redirect("obavijesti.aspx");
            }
        }
        if (flag == 0)
        {
            conn.Close();
            dr.Close();
            lblError.Visible = true;
        }
    }
}