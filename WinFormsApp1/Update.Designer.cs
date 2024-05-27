namespace WinFormsApp1
{
	partial class Update
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label3 = new Label();
			textBox1 = new TextBox();
			button5 = new Button();
			panel3 = new Panel();
			checkedListBox1 = new CheckedListBox();
			button6 = new Button();
			comboBox2 = new ComboBox();
			comboBox1 = new ComboBox();
			textBox3 = new TextBox();
			label10 = new Label();
			numericUpDown1 = new NumericUpDown();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			textBox2 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Modern No. 20", 13F);
			label3.Location = new Point(353, 274);
			label3.Name = "label3";
			label3.Size = new Size(142, 24);
			label3.TabIndex = 4;
			label3.Text = "Search By ID :";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(515, 273);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(330, 27);
			textBox1.TabIndex = 5;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button5
			// 
			button5.BackColor = Color.Olive;
			button5.FlatAppearance.BorderColor = Color.Olive;
			button5.FlatStyle = FlatStyle.Flat;
			button5.ForeColor = SystemColors.ButtonHighlight;
			button5.Location = new Point(845, 271);
			button5.Name = "button5";
			button5.Size = new Size(94, 29);
			button5.TabIndex = 6;
			button5.Text = "Edit";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(checkedListBox1);
			panel3.Controls.Add(button6);
			panel3.Controls.Add(comboBox2);
			panel3.Controls.Add(comboBox1);
			panel3.Controls.Add(textBox3);
			panel3.Controls.Add(label10);
			panel3.Controls.Add(numericUpDown1);
			panel3.Controls.Add(label9);
			panel3.Controls.Add(label8);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(textBox2);
			panel3.Controls.Add(label5);
			panel3.Controls.Add(label4);
			panel3.Location = new Point(247, 95);
			panel3.Name = "panel3";
			panel3.Size = new Size(805, 427);
			panel3.TabIndex = 7;
			panel3.Paint += panel3_Paint;
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] { "C#", "Python", "Java" });
			checkedListBox1.Location = new Point(212, 276);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(453, 70);
			checkedListBox1.TabIndex = 14;
			checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
			// 
			// button6
			// 
			button6.BackColor = Color.Olive;
			button6.FlatAppearance.BorderColor = Color.Olive;
			button6.FlatStyle = FlatStyle.Flat;
			button6.Font = new Font("Segoe UI", 11F);
			button6.ForeColor = SystemColors.ButtonHighlight;
			button6.Location = new Point(352, 367);
			button6.Name = "button6";
			button6.Size = new Size(138, 40);
			button6.TabIndex = 13;
			button6.Text = "Update";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "Achham", "Arghakhanchi", "Baglung", "Baitadi", "Bajhang", "Bajura", "Banke", "Bara", "Bardiya", "Bhaktapur", "Bhojpur", "Chitwan", "Dadeldhura", "Dailekh", "Dang", "Darchula", "Dhading", "Dhankuta", "Dhanusha", "Dolakha", "Dolpa", "Doti", "Gulmi", "Gorkha", "Humla", "Ilam", "Jajarkot", "Jhapa", "Jumla", "Kailali", "Kalikot", "Kanchanpur", "Kapilvastu", "Kaski", "Kavrepalanchok", "Kathmandu", "Khotang", "Lalitpur", "Lamjung", "Mahottari", "Makwanpur", "Manang", "Morang", "Mugu", "Mustang", "Myagdi", "Nawalparasi (West of Bardaghat Susta)", "Nawalpur", "Nuwakot", "Okhaldhunga", "Palpa", "Panchthar", "Parbat", "Parsa", "Pyuthan", "Ramechhap", "Rasuwa", "Rautahat", "Rolpa", "Rukum (East)", "Rupandehi", "Salyan", "Sankhuwasabha", "Saptari", "Sarlahi", "Sindhuli", "Sindhupalchok", "Siraha", "Solukhumbu", "Sunsari", "Surkhet", "Syangja", "Tanahun", "Taplejung", "Terhathum", "Udayapur", "Rukum (West)" });
			comboBox2.Location = new Point(212, 229);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(453, 28);
			comboBox2.TabIndex = 11;
			comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Province No. 1", "Madhesh Province", "Bagmati Province", "Gandaki Province", "Lumbini Province", "Karnali Province", "Sudurpashchim Province" });
			comboBox1.Location = new Point(212, 178);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(453, 28);
			comboBox1.TabIndex = 10;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(466, 127);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(199, 27);
			textBox3.TabIndex = 9;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Mongolian Baiti", 11F);
			label10.Location = new Point(409, 131);
			label10.Name = "label10";
			label10.Size = new Size(39, 20);
			label10.TabIndex = 8;
			label10.Text = "ID :";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(212, 128);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(150, 27);
			numericUpDown1.TabIndex = 7;
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Mongolian Baiti", 11F);
			label9.Location = new Point(106, 280);
			label9.Name = "label9";
			label9.Size = new Size(62, 20);
			label9.TabIndex = 6;
			label9.Text = "Skills :";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Mongolian Baiti", 11F);
			label8.Location = new Point(106, 231);
			label8.Name = "label8";
			label8.Size = new Size(74, 20);
			label8.TabIndex = 5;
			label8.Text = "District :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Mongolian Baiti", 11F);
			label7.Location = new Point(106, 182);
			label7.Name = "label7";
			label7.Size = new Size(87, 20);
			label7.TabIndex = 4;
			label7.Text = "Province :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Mongolian Baiti", 11F);
			label6.Location = new Point(107, 132);
			label6.Name = "label6";
			label6.Size = new Size(51, 20);
			label6.TabIndex = 3;
			label6.Text = "Age :";
			label6.Click += label6_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(212, 79);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(453, 27);
			textBox2.TabIndex = 2;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Mongolian Baiti", 11F);
			label5.Location = new Point(106, 86);
			label5.Name = "label5";
			label5.Size = new Size(64, 20);
			label5.TabIndex = 1;
			label5.Text = "Name :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Mongolian Baiti", 15F);
			label4.ForeColor = SystemColors.ButtonHighlight;
			label4.Location = new Point(295, 26);
			label4.Name = "label4";
			label4.Size = new Size(237, 26);
			label4.TabIndex = 0;
			label4.Text = "Update Register Entry";
			label4.Click += label4_Click;
			// 
			// Update
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(1050, 517);
			Controls.Add(panel3);
			Controls.Add(button5);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Name = "Update";
			Text = "Update";
			Controls.SetChildIndex(label3, 0);
			Controls.SetChildIndex(textBox1, 0);
			Controls.SetChildIndex(button5, 0);
			Controls.SetChildIndex(panel3, 0);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private TextBox textBox1;
		private Button button5;
		private Panel panel3;
		private Label label4;
		private Label label5;
		private TextBox textBox2;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private TextBox textBox3;
		private Label label10;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
		private Button button6;
		private CheckedListBox checkedListBox1;
	}
}