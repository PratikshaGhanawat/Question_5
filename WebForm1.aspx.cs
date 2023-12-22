using System;
using System.Data;
using System.Data.SqlClient;

namespace Question_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=abc;Integrated Security=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        lblMessage.InnerText = "User added successfully!";
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        lblMessage.InnerText = "Error: " + ex.Message;
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtUserName.Text = "";
            txtEmail.Text = "";
        }
    }
}
