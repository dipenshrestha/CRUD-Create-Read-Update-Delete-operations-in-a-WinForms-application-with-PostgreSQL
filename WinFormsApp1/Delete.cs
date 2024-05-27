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
	public partial class Delete : crudOperation
	{
		public Delete()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
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
						comm.CommandText = "DELETE FROM person WHERE person_id = @searched_id";

						// Add parameter
						comm.Parameters.AddWithValue("@searched_id", searched_id);

						int rowsAffected = comm.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							MessageBox.Show("Deleted Successfully");
							this.Close();
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
	}
}
