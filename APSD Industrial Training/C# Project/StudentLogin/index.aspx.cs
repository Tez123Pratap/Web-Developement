using System;
using System.Data.SqlClient;

namespace StudentLogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=TEZPRATAP; initial catalog=SCHOOL; integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO STUDENTS(NAME,ROLL,MOBILE,EMAIL)VALUES('" + txtName.Text + "','" + txtRoll.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            txtName.Text = "";
            txtRoll.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }
    }
}