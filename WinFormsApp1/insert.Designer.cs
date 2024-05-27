namespace WinFormsApp1
{
	partial class insert
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			textBox1 = new TextBox();
			numericUpDown1 = new NumericUpDown();
			button4 = new Button();
			comboBox1 = new ComboBox();
			comboBox2 = new ComboBox();
			checkedListBox1 = new CheckedListBox();
			label9 = new Label();
			textBox2 = new TextBox();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Mongolian Baiti", 15F);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(574, 125);
			label2.Name = "label2";
			label2.Size = new Size(158, 26);
			label2.TabIndex = 4;
			label2.Text = "Register Entry";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Mongolian Baiti", 11F);
			label3.Location = new Point(327, 180);
			label3.Name = "label3";
			label3.Size = new Size(64, 20);
			label3.TabIndex = 5;
			label3.Text = "Name :";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Mongolian Baiti", 11F);
			label4.Location = new Point(327, 230);
			label4.Name = "label4";
			label4.Size = new Size(51, 20);
			label4.TabIndex = 6;
			label4.Text = "Age :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Mongolian Baiti", 11F);
			label5.Location = new Point(327, 278);
			label5.Name = "label5";
			label5.Size = new Size(87, 20);
			label5.TabIndex = 7;
			label5.Text = "Province :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Mongolian Baiti", 11F);
			label6.Location = new Point(327, 325);
			label6.Name = "label6";
			label6.Size = new Size(74, 20);
			label6.TabIndex = 8;
			label6.Text = "District :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Mongolian Baiti", 11F);
			label7.Location = new Point(327, 373);
			label7.Name = "label7";
			label7.Size = new Size(62, 20);
			label7.TabIndex = 9;
			label7.Text = "Skills :";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(473, 180);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(453, 27);
			textBox1.TabIndex = 10;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(473, 227);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(150, 27);
			numericUpDown1.TabIndex = 11;
			numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
			// 
			// button4
			// 
			button4.Location = new Point(600, 464);
			button4.Name = "button4";
			button4.Size = new Size(179, 41);
			button4.TabIndex = 12;
			button4.Text = "Register";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Province No. 1", "Madhesh Province", "Bagmati Province", "Gandaki Province", "Lumbini Province", "Karnali Province", "Sudurpashchim Province" });
			comboBox1.Location = new Point(473, 272);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(453, 28);
			comboBox1.TabIndex = 13;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "Achham", "Arghakhanchi", "Baglung", "Baitadi", "Bajhang", "Bajura", "Banke", "Bara", "Bardiya", "Bhaktapur", "Bhojpur", "Chitwan", "Dadeldhura", "Dailekh", "Dang", "Darchula", "Dhading", "Dhankuta", "Dhanusha", "Dolakha", "Dolpa", "Doti", "Gulmi", "Gorkha", "Humla", "Ilam", "Jajarkot", "Jhapa", "Jumla", "Kailali", "Kalikot", "Kanchanpur", "Kapilvastu", "Kaski", "Kavrepalanchok", "Kathmandu", "Khotang", "Lalitpur", "Lamjung", "Mahottari", "Makwanpur", "Manang", "Morang", "Mugu", "Mustang", "Myagdi", "Nawalparasi (West of Bardaghat Susta)", "Nawalpur", "Nuwakot", "Okhaldhunga", "Palpa", "Panchthar", "Parbat", "Parsa", "Pyuthan", "Ramechhap", "Rasuwa", "Rautahat", "Rolpa", "Rukum (East)", "Rupandehi", "Salyan", "Sankhuwasabha", "Saptari", "Sarlahi", "Sindhuli", "Sindhupalchok", "Siraha", "Solukhumbu", "Sunsari", "Surkhet", "Syangja", "Tanahun", "Taplejung", "Terhathum", "Udayapur", "Rukum (West)" });
			comboBox2.Location = new Point(472, 320);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(454, 28);
			comboBox2.TabIndex = 14;
			comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] { "C#", "Python", "Java" });
			checkedListBox1.Location = new Point(474, 368);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(452, 70);
			checkedListBox1.TabIndex = 16;
			checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Mongolian Baiti", 11F);
			label9.Location = new Point(693, 230);
			label9.Name = "label9";
			label9.Size = new Size(39, 20);
			label9.TabIndex = 18;
			label9.Text = "ID :";
			label9.Click += label9_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(738, 225);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(188, 27);
			textBox2.TabIndex = 19;
			textBox2.TextChanged += textBox2_TextChanged_1;
			// 
			// insert
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(1050, 517);
			Controls.Add(textBox2);
			Controls.Add(label9);
			Controls.Add(checkedListBox1);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(button4);
			Controls.Add(numericUpDown1);
			Controls.Add(textBox1);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Name = "insert";
			Text = "register";
			Load += register_Load;
			Controls.SetChildIndex(label2, 0);
			Controls.SetChildIndex(label3, 0);
			Controls.SetChildIndex(label4, 0);
			Controls.SetChildIndex(label5, 0);
			Controls.SetChildIndex(label6, 0);
			Controls.SetChildIndex(label7, 0);
			Controls.SetChildIndex(textBox1, 0);
			Controls.SetChildIndex(numericUpDown1, 0);
			Controls.SetChildIndex(button4, 0);
			Controls.SetChildIndex(comboBox1, 0);
			Controls.SetChildIndex(comboBox2, 0);
			Controls.SetChildIndex(checkedListBox1, 0);
			Controls.SetChildIndex(label9, 0);
			Controls.SetChildIndex(textBox2, 0);
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private Button button4;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private CheckedListBox checkedListBox1;
		private Label label9;
		private TextBox textBox2;
	}
}