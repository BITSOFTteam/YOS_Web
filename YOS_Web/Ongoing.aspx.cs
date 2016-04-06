using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YOS_Web
{
	public partial class Ongoing : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			txb.Text = "로드";
		}

		protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
		{

		}

		protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			txb.Text = "삭제 중";
		}
	}
}