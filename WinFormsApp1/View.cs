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
	public partial class View : crudOperation
	{
		public View()
		{
			InitializeComponent();
			dataGridView1.Visible = false;
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			var searched_id = textBox1.Text;

			if (string.IsNullOrWhiteSpace(searched_id))
			{
				MessageBox.Show("The field cannot be empty");
				return;
			}

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=sekaiwiz;Database=labFive"))
				{
					conn.Open();
					using (NpgsqlCommand comm = new NpgsqlCommand())
					{
						comm.Connection = conn;
						comm.CommandType = CommandType.Text;
						comm.CommandText = "SELECT person_id, person_name, person_age, person_province, person_district, person_skills FROM person WHERE person_id = @searched_id";

						// Add parameter
						comm.Parameters.AddWithValue("@searched_id", searched_id);

						NpgsqlDataReader dr = comm.ExecuteReader();
						if (dr.HasRows)
						{
							dataGridView1.Visible = true;
							DataTable dt = new DataTable();
							dt.Load(dr);
							dataGridView1.DataSource = dt;
							/*MessageBox.Show("Connection successful");*/
						}
						else
						{
							MessageBox.Show("No records found.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void View_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
