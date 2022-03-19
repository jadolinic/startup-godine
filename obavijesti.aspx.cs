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
public partial class obavijesti : System.Web.UI.Page
{
    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\korisnici.accdb";


    protected void Page_Load(object sender, EventArgs e)
    {

        OleDbConnection conn = new OleDbConnection(connectionString);
        conn.Open();
        OleDbCommand cm = new OleDbCommand("Select obavijesti from korisnici_acc where korisnicko_ime=@kor", conn);
        cm.Parameters.AddWithValue("kor", "jadolinic");
        OleDbDataReader dr = cm.ExecuteReader();
        dr.Read();
        Session["obavijesti"] = dr["obavijesti"].ToString();
        dr.Close();
        conn.Close();

        txt_obavijesti.Text = Session["obavijesti"].ToString();
 

        if (!IsPostBack)
        {

            if ((string)Session["admin"] == "da")
            {
                txt_obavijesti.Visible = false;
                txt_edit.Visible = true;
                btn_edit.Visible = true;

                OleDbConnection conn2 = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cm2 = new OleDbCommand("Select obavijesti from korisnici_acc where korisnicko_ime=@kor", conn);
                cm2.Parameters.AddWithValue("kor", "jadolinic");
                OleDbDataReader dr2 = cm.ExecuteReader();
                dr2.Read();
                Session["obavijesti"] = dr2["obavijesti"].ToString();
                dr2.Close();
                conn.Close();

                txt_edit.Text = Session["obavijesti"].ToString();
 


            }

            if ((string)Session["admin"] != "da")
            {
                txt_obavijesti.Visible = true;
                txt_edit.Visible = false;
                btn_edit.Visible = false;
            }
        }
        
    }
    protected void btn_edit_Click(object sender, EventArgs e)
    {
        OleDbConnection conn = new OleDbConnection(connectionString);
        conn.Open();
        OleDbCommand cm = new OleDbCommand("update korisnici_acc set obavijesti=@text where korisnicko_ime=@kor", conn);
        cm.Parameters.AddWithValue("text", txt_edit.Text);
        cm.Parameters.AddWithValue("kor", "jadolinic");
        cm.ExecuteNonQuery();
        conn.Close();
    }
}