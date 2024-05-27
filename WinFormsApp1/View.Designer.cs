namespace WinFormsApp1
{
	partial class View
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
			dataGridView1 = new DataGridView();
			label3 = new Label();
			textBox1 = new TextBox();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(268, 308);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(770, 101);
			dataGridView1.TabIndex = 4;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Palatino Linotype", 13F);
			label3.ForeColor = SystemColors.ActiveCaptionText;
			label3.Location = new Point(335, 227);
			label3.Name = "label3";
			label3.Size = new Size(136, 29);
			label3.TabIndex = 5;
			label3.Text = "View By ID :";
			label3.Click += label3_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(477, 230);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(367, 27);
			textBox1.TabIndex = 6;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button4
			// 
			button4.BackColor = Color.Green;
			button4.FlatAppearance.BorderColor = Color.Green;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("MS Reference Sans Serif", 9F);
			button4.ForeColor = SystemColors.ButtonHighlight;
			button4.Location = new Point(844, 228);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 7;
			button4.Text = "Find";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// View
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(1050, 517);
			Controls.Add(button4);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(dataGridView1);
			Name = "View";
			Text = "View";
			Load += View_Load;
			Controls.SetChildIndex(dataGridView1, 0);
			Controls.SetChildIndex(label3, 0);
			Controls.SetChildIndex(textBox1, 0);
			Controls.SetChildIndex(button4, 0);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label label3;
		private TextBox textBox1;
		private Button button4;
	}
}