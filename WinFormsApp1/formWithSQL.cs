using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class formWithSQL : Form
	{
		public formWithSQL()
		{
			InitializeComponent();
			NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=sekaiwiz;Database=labFive");
			conn.Open();
			NpgsqlCommand comm = new NpgsqlCommand();
			comm.Connection = conn;
			comm.CommandType = CommandType.Text;
			comm.CommandText = "select * from \"student\"";
			NpgsqlDataReader dr = comm.ExecuteReader();
			if (dr.HasRows)
			{
				DataTable dt = new DataTable();
				dt.Load(dr);
				dataGridView1.DataSource = dt;
				/*MessageBox.Show("Connection successful");*/
			}
			comm.Dispose();
			conn.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
