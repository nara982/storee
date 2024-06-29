using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace f23_store
{
    public partial class viewcart : System.Web.UI.Page
    {

        string s, t, desc = "";
        string[] a = new string[5];
        int count = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\f23 store\f23 store\App_Data\f23db.mdf;Integrated Security=True");

        protected void cart_click(object sender, EventArgs e)
        {
            if (rep.Visible == true)
                rep.Visible = false;
            else
                rep.Visible = true;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO users values('" + nametxt.Text + "','" + countrydp.SelectedValue + "'," + count + ",'" + desc + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("name"), new DataColumn("price"), new DataColumn("desc"), new DataColumn("image"), new DataColumn("id") });
            if (Request.Cookies["yy"] != null)
            {
                s = Request.Cookies["yy"].Value.ToString();
                string[] arr = s.Split('|');
                for (int i = 0; i < arr.Length; i++)
                {
                    t = arr[i].ToString();
                    string[] arr1 = t.Split(',');
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        a[j] = arr1[j].ToString();

                    }
                    desc += a[2];
                    dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), i.ToString());
                    count += int.Parse(arr1[1]);
                }
                pricelbl.Text = "Total price is:" + count;
                countlbl.Text = "count is :" + arr.Length;
            }
            rep.DataSource = dt;

            rep.DataBind();
            rep.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            namelbl.Visible = true;
            countrylbl.Visible = true;
            nametxt.Visible = true;
            countrydp.Visible = true;
            Button2.Visible = true;

        }
    }
}