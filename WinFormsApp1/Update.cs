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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
	public partial class Update : crudOperation
	{
		private insert insertForm;
		public Update()
		{
			InitializeComponent();
			panel3.Visible = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			var searched_id = textBox1.Text; // Assuming you want to update using the ID entered in textBox2

			if (string.IsNullOrWhiteSpace(searched_id))
			{
				MessageBox.Show("The ID field cannot be empty");
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
						using (NpgsqlDataReader reader = comm.ExecuteReader())
						{
							while (reader.Read())
							{
								string person_id = reader.GetString(0); // Assuming person_id is a string
								string person_name = reader.GetString(1); // Assuming person_name is a string
								string person_age = reader.GetString(2); // Assuming person_age is integer
								string person_province = reader.GetString(3); // Assuming person_province is a string
								string person_district = reader.GetString(4); // Assuming person_district is a string
								string person_skills = reader.GetString(5); // Assuming person_skills is a string
								panel3.Visible = true;
								textBox3.Enabled = false;
								// putting the values in the insert table for update
								textBox3.Text = person_id;
								textBox2.Text = person_name;
								numericUpDown1.Value = Int32.Parse(person_age);
								comboBox1.Text = person_province;
								comboBox2.Text = person_district;
								//person_skills is a comma-separated list of skills
								string[] skills = person_skills.Split(' ');
								foreach (string skill in skills)
								{
									if (checkedListBox1.Items.Contains(skill))
									{
										checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(skill), true);
									}
								}

							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox2.Items.Clear();
			if (comboBox1.SelectedItem != null)
			{

				switch (comboBox1.SelectedItem.ToString())
				{
					case "Province No. 1":
						comboBox2.Items.AddRange(new string[]
						{   "Bhojpur",
							"Dhankuta",
							"Ilam",
							"Jhapa",
							"Khotang",
							"Morang",
							"Okhaldhunga",
							"Panchthar",
							"Sankhuwasabha",
							"Solukhumbu",
							"Sunsari",
							"Taplejung",
							"Terhathum",
							"Udayapur"
						});
						break;
					case "Madhesh Province":
						comboBox2.Items.AddRange(new string[] {"Bara",
						"Dhanusha",
						"Mahottari",
						"Parsa",
						"Rautahat",
						"Saptari",
						"Sarlahi",
						"Siraha"});
						break;
					case "Bagmati Province":
						comboBox2.Items.AddRange(new string[] {"Bhaktapur",
						"Chitwan",
						"Dhading",
						"Dolakha",
						"Kathmandu",
						"Kavrepalanchok",
						"Lalitpur",
						"Makwanpur",
						"Nuwakot",
						"Ramechhap",
						"Rasuwa",
						"Sindhuli",
						"Sindhupalchok"});
						break;
					case "Gandaki Province":
						comboBox2.Items.AddRange(new string[] {"Baglung",
						"Gorkha",
						"Kaski",
						"Lamjung",
						"Manang",
						"Mustang",
						"Myagdi",
						"Nawalpur",
						"Parbat",
						"Syangja",
						"Tanahun"});
						break;
					case "Lumbini Province":
						comboBox2.Items.AddRange(new string[] {"Arghakhanchi",
						"Banke",
						"Bardiya",
						"Dang",
						"Gulmi",
						"Kapilvastu",
						"Nawalparasi (West of Bardaghat Susta)",
						"Palpa",
						"Pyuthan",
						"Rolpa",
						"Rupandehi"});
						break;
					case "Karnali Province":
						comboBox2.Items.AddRange(new string[] {"Dailekh",
						"Dolpa",
						"Humla",
						"Jajarkot",
						"Jumla",
						"Kalikot",
						"Mugu",
						"Rukum (East)",
						"Salyan",
						"Surkhet"});
						break;
					case "Sudurpashchim Province":
						comboBox2.Items.AddRange(new string[] {"Achham",
						"Baitadi",
						"Bajhang",
						"Bajura",
						"Dadeldhura",
						"Darchula",
						"Doti",
						"Kailali",
						"Kanchanpur"});
						break;

				}
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			// Taking input values
			var person_id = textBox3.Text;
			var person_name = textBox2.Text;
			var person_age = numericUpDown1.Value;
			var person_province = comboBox1.Text;
			var person_district = comboBox2.Text;


			// Retrieve the checked items
			string checkedItems = "";
			foreach (var item in checkedListBox1.CheckedItems)
			{
				checkedItems += item.ToString() + ",";
			}

			if (string.IsNullOrWhiteSpace(person_name) || person_age == 0 || person_id == null || string.IsNullOrWhiteSpace(person_province) || string.IsNullOrWhiteSpace(person_district) || string.IsNullOrWhiteSpace(checkedItems))
			{
				MessageBox.Show("The fields cannot be empty");
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
						comm.CommandText = "UPDATE person SET person_name = @person_name, person_age = @person_age, person_province = @person_province, person_district = @person_district, person_skills = @person_skills WHERE person_id = @person_id";

						// Add parameters
						comm.Parameters.AddWithValue("@person_id", person_id);
						comm.Parameters.AddWithValue("@person_name", person_name);
						comm.Parameters.AddWithValue("@person_age", (int)person_age);  // Assuming person_age is an integer
						comm.Parameters.AddWithValue("@person_province", person_province);
						comm.Parameters.AddWithValue("@person_district", person_district);
						comm.Parameters.AddWithValue("@person_skills", checkedItems);

						int result = comm.ExecuteNonQuery();

						if (result > 0)
						{
							MessageBox.Show("Data Updated Successfully!");
							this.Close();
						}
						else
						{
							MessageBox.Show("Failed to Update the data.");
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
