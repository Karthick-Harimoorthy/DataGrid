using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace DataGrid
{
    public partial class DataGridView : System.Web.UI.Page
    {


        private void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.DataGridViewTable();
            }
        }
        public void DataGridViewTable()
        {
            String constr = @"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";
            string query = "select * FROM userdetails";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(query, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.DataGridViewTable();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string firstname = (string)this.GridView1.DataKeys[e.RowIndex]["firstname"];
            string constr = @"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM userdetails WHERE firstname=@firstname"))
                {
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.DataGridViewTable();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.DataGridViewTable();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            string FirstName = (string)this.GridView1.DataKeys[e.RowIndex]["firstname"];
            string lastname = ((TextBox)row.Cells[2].Controls[0]).Text;
            string emailid = ((TextBox)row.Cells[3].Controls[0]).Text;
            string qualification = ((TextBox)row.Cells[4].Controls[0]).Text;
            string phno = ((TextBox)row.Cells[5].Controls[0]).Text;
            string country = ((TextBox)row.Cells[6].Controls[0]).Text;
            string state = ((TextBox)row.Cells[7].Controls[0]).Text;
            string city = ((TextBox)row.Cells[8].Controls[0]).Text;
            string constr = @"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("UPDATE userdetails SET lastname = '" + lastname + "', emailid = '"+emailid+"',qualification = '"+qualification+"',phno = '"+phno+"',country = '"+country+"',state = '"+state+"',city = '"+city+ "' WHERE firstname = '" + FirstName + "'"))
                {
                    cmd.Parameters.AddWithValue("@firstname", FirstName);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@emailid", emailid);
                    cmd.Parameters.AddWithValue("@qualification", qualification);
                    cmd.Parameters.AddWithValue("@phno", phno);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            GridView1.EditIndex = -1;
            this.DataGridViewTable();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.DataGridViewTable();
        }
        protected void Insert(object sender, EventArgs e)
        {
            string firstname = FirstNmae.Text;
            string lastname = LastName.Text;
            string emailid = EmailId.Text;
            string qualification = Qualification.Text;
            string phno = PhNo.Text;
            string country = Country.Text;
            string state = State.Text;
            string city = City.Text;
         
            string query = "INSERT INTO userdetails VALUES(@firstname, @lastname,@emailid,@qualification,@phno,@country,@state,@city)";
            string constr = @"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@emailid", emailid);
                    cmd.Parameters.AddWithValue("@qualification", qualification);
                    cmd.Parameters.AddWithValue("@phno", phno);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            this.DataGridViewTable();
        }

    }
}