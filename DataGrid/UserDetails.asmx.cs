using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace DataGrid
{
    /// <summary>
    /// Summary description for UserDetails
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserDetails : System.Web.Services.WebService
    {
        public object FirstName { get; set; }
        public object LastName { get; set; }
        public object Emailid { get; set; }
        public object Qualification { get; set; }
        public object PhNo { get; set; }
        public object Country { get; set; }
        public object State { get; set; }
        public object City { get; set; }

        [WebMethod]
        public void DataGridView()
        {

            //using (MySqlConnection con = new MySqlConnection(@"server=localhost;database=test_data2;Uid=sandc_db;Pwd=Sandc@123;"))
            //{
            //    MySqlCommand cmd = new MySqlCommand("select * FROM userdetails", con);

            //    var UsrsDtils = new List<UserDetails>();
            //    {
            //        con.Open();
            //        MySqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            var uds = new UserDetails
            //            {
            //                FirstName = dr["firstname"].ToString(),
            //                LastName = dr["lastname"].ToString(),
            //                Emailid = dr["emailid"].ToString(),
            //                Qualification = dr["qualification"].ToString(),
            //                PhNo = dr["phno"].ToString(),
            //                Country = dr["country"].ToString(),
            //                State = dr["state"].ToString(),
            //                City = dr["city"].ToString()
            //            };
            //            UsrsDtils.Add(uds);
            //        }
            //    }
            //    JavaScriptSerializer js = new JavaScriptSerializer();
            //    Context.Response.Write(js.Serialize(UsrsDtils));
            //}

        }
    }
}
