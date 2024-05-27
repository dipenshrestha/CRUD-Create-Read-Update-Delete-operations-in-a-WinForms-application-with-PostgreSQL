namespace WinFormsApp1
{
	partial class crudOperation
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			panel1 = new Panel();
			label2 = new Label();
			panel2 = new Panel();
			button1 = new Button();
			button3 = new Button();
			button2 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			button4 = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Mistral", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.HotTrack;
			label1.Location = new Point(249, 30);
			label1.Name = "label1";
			label1.Size = new Size(248, 48);
			label1.TabIndex = 0;
			label1.Text = "CRUD Operation";
			label1.Click += label1_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Aquamarine;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(-2, -3);
			panel1.Name = "panel1";
			panel1.Size = new Size(1057, 99);
			panel1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Rockwell", 19F);
			label2.Location = new Point(872, 36);
			label2.Name = "label2";
			label2.Size = new Size(135, 36);
			label2.TabIndex = 1;
			label2.Text = "00:00:00";
			label2.Click += label2_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Aquamarine;
			panel2.Controls.Add(button4);
			panel2.Controls.Add(button1);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button2);
			panel2.Location = new Point(-2, 95);
			panel2.Name = "panel2";
			panel2.Size = new Size(250, 430);
			panel2.TabIndex = 3;
			// 
			// button1
			// 
			button1.BackColor = Color.Crimson;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Mongolian Baiti", 13F);
			button1.ForeColor = SystemColors.ButtonHighlight;
			button1.Location = new Point(25, 290);
			button1.Name = "button1";
			button1.Size = new Size(200, 49);
			button1.TabIndex = 4;
			button1.Text = "Delete";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Navy;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Mongolian Baiti", 13F);
			button3.ForeColor = SystemColors.ButtonHighlight;
			button3.Location = new Point(25, 135);
			button3.Name = "button3";
			button3.Size = new Size(200, 49);
			button3.TabIndex = 3;
			button3.Text = "View";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.DarkGreen;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Mongolian Baiti", 13F);
			button2.ForeColor = SystemColors.ButtonHighlight;
			button2.Location = new Point(25, 57);
			button2.Name = "button2";
			button2.Size = new Size(200, 49);
			button2.TabIndex = 2;
			button2.Text = "Insert";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// button4
			// 
			button4.BackColor = Color.OliveDrab;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Mongolian Baiti", 13F);
			button4.ForeColor = SystemColors.ButtonHighlight;
			button4.Location = new Point(25, 215);
			button4.Name = "button4";
			button4.Size = new Size(200, 49);
			button4.TabIndex = 5;
			button4.Text = "Update";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// crudOperation
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.CornflowerBlue;
			ClientSize = new Size(1050, 517);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "crudOperation";
			Text = "formInheritance";
			Load += formInheritance_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private Panel panel2;
		private Button button3;
		private Button button2;
		private System.Windows.Forms.Timer timer1;
		private Label label2;
		private Button button1;
		private Button button4;
	}
}