using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace vjezba2
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MojConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(s);
            SqlCommand command = new SqlCommand("SELECT * FROM Products", conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            gridProducts.DataSource = reader;
            gridProducts.DataBind();

            DropDownList1.Items.Clear();
            SqlCommand command2 = new SqlCommand("SELECT * FROM Categories", conn);
            SqlDataReader reader2 = command2.ExecuteReader();

            //povezujemo DDL i rezultat
            while (reader2.Read() == true)
            {
                DropDownList1.Items.Add(new ListItem(reader2["Name"].ToString(), reader2["Id"].ToString()));
            }
            reader.Close();
            conn.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MojConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand("INSERT INTO Products VALUES (@name, @description, @catid ) ", conn);
            comm.Parameters.AddWithValue("name", tb_pime.Text);
            comm.Parameters.AddWithValue("description", tb_opis.Text);
            comm.Parameters.AddWithValue("catid", DropDownList1.Text);
            try
            {
                conn.Open();
                int brojRedova = comm.ExecuteNonQuery();
                //ExecuteNonQuery vrati broj redaka na koje je "djelovao". U ovom slučaju očekujemo 1 (1 insert)
                if (brojRedova == 1)
                {
                    Session["Name"] = tb_pime.Text;
                    Page_Load(sender, e);
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