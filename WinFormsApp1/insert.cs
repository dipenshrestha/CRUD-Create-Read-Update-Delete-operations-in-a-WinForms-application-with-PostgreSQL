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
using System.Windows.Forms.Design;

namespace WinFormsApp1
{
	public partial class insert : crudOperation
	{

		public insert()
		{
			InitializeComponent();
		}

		private void register_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Taking input values
			var person_id = textBox2.Text;
			var person_name = textBox1.Text;
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
						comm.CommandText = "INSERT INTO person (person_id, person_name, person_age, person_province, person_district, person_skills) VALUES (@person_id, @person_name, @person_age, @person_province, @person_district, @person_skills)";

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
							MessageBox.Show("Data inserted successfully!");
							this.Close();
						}
						else
						{
							MessageBox.Show("Failed to insert data.");
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message);
			}

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{

		}
	}
}
