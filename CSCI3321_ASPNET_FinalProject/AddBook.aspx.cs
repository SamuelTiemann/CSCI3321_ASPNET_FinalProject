using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Books VALUES ('" + txtBookTitle.Text + "', " + ddlAuthors.SelectedValue + ", '" + txtPrice.Text + "', '" + txtPublishDate.Text + "', '" + ddlPublishers.SelectedValue + "', '" + ddlGenre.SelectedValue + "', '0')";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            txtBookTitle.Text = "";
            txtPrice.Text = "";
            txtPublishDate.Text = "";
            //Response.Redirect("MyBooks.aspx");
        }
    }
}