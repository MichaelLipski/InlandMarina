using InlandMarina.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InlandMarinaGUI
{
    public partial class Slips : System.Web.UI.Page
    {
        private DataTable dataTable;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // when the page loads the first time
            {
                // get list of slips and bind the grid view
                List<Slip> slips = MarinaManager.GetAvailableSlips();
                gvSlips.DataSource = slips;
                gvSlips.DataBind();
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("MarinaEntities");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from docks where id=" + txtSearchMaster.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            gvSlips.DataSource = dataTable;
            gvSlips.DataBind();
        }

    }
}