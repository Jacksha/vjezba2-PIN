using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace vjezba2
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Generiramo neki slučajni broj za salt
            Random r = new Random(DateTime.Now.Millisecond);
            string sol = r.Next().ToString();
            //Hashiramo lozinku
            string hashLozinka = Utility.Hash(tb_lozinka.Text);
            //Hashiranoj lozinci dodajemo salt i ponovno hashiramo
            string hashSlanaLozinka = Utility.Hash(hashLozinka + sol);
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MojConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand("INSERT INTO Users VALUES (@username, @password, @salt, @fullname ) ", conn);
            comm.Parameters.AddWithValue("username", tb_kime.Text);
            comm.Parameters.AddWithValue("password", hashSlanaLozinka);
            comm.Parameters.AddWithValue("salt", sol);
            comm.Parameters.AddWithValue("fullname", tb_punoime.Text);

            //try-catch-finally - > obrada grešaka
            try
            {
                conn.Open();
                int brojRedova = comm.ExecuteNonQuery();
                //ExecuteNonQuery vrati broj redaka na koje je "djelovao". U ovom slučaju očekujemo 1 (1 insert)
                if (brojRedova == 1)
                {
                    Session["ime"] = tb_punoime.Text;
                    Response.Redirect("Login.aspx"); //Reserved users
                }
            }
            catch (Exception ex)
            {
                //neko logiranje greške
                Console.Write(ex);
            }
            finally //ovaj dio koda će se uvijek izvršiti
            {
                //osiguravamo se da se konekcija zatvori
                conn.Close();
            }
        }
    }
}