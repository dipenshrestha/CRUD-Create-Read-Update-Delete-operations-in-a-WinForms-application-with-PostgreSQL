namespace WinFormsApp1
{
	partial class Delete
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
			button4 = new Button();
			button5 = new Button();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Palatino Linotype", 13F);
			label3.Location = new Point(331, 261);
			label3.Name = "label3";
			label3.Size = new Size(153, 29);
			label3.TabIndex = 4;
			label3.Text = "Search By ID :";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(490, 263);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(383, 27);
			textBox1.TabIndex = 5;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// button4
			// 
			button4.Location = new Point(0, 0);
			button4.Name = "button4";
			button4.Size = new Size(94, 29);
			button4.TabIndex = 6;
			button4.Text = "button4";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.BackColor = Color.Crimson;
			button5.FlatAppearance.BorderColor = Color.Crimson;
			button5.FlatStyle = FlatStyle.Flat;
			button5.ForeColor = SystemColors.ButtonFace;
			button5.Location = new Point(870, 262);
			button5.Name = "button5";
			button5.Size = new Size(94, 29);
			button5.TabIndex = 7;
			button5.Text = "Remove";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// Delete
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(1050, 517);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Name = "Delete";
			Text = "Delete";
			Controls.SetChildIndex(label3, 0);
			Controls.SetChildIndex(textBox1, 0);
			Controls.SetChildIndex(button4, 0);
			Controls.SetChildIndex(button5, 0);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
		private TextBox textBox1;
		private Button button4;
		private Button button5;
	}
}