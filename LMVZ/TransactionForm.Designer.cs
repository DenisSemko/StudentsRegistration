namespace LMVZ
{
	partial class TransactionForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.studentsDBDataSet = new LMVZ.StudentsDBDataSet();
			this.studentsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.transactionsTableAdapter = new LMVZ.StudentsDBDataSetTableAdapters.TransactionsTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.exitToolStripMenuItem = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(168, 496);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(927, 256);
			this.dataGridView1.TabIndex = 0;
			// 
			// studentsDBDataSet
			// 
			this.studentsDBDataSet.DataSetName = "StudentsDBDataSet";
			this.studentsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentsDBDataSetBindingSource
			// 
			this.studentsDBDataSetBindingSource.DataSource = this.studentsDBDataSet;
			this.studentsDBDataSetBindingSource.Position = 0;
			// 
			// transactionsBindingSource
			// 
			this.transactionsBindingSource.DataMember = "Transactions";
			this.transactionsBindingSource.DataSource = this.studentsDBDataSetBindingSource;
			// 
			// transactionsTableAdapter
			// 
			this.transactionsTableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel1.Location = new System.Drawing.Point(-4, -1);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1172, 22);
			this.panel1.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(311, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 17);
			this.label1.TabIndex = 27;
			this.label1.Text = "Прізвище";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "Ім\'я";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(311, 143);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 17);
			this.label3.TabIndex = 27;
			this.label3.Text = "По-батькові";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(311, 181);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 27;
			this.label4.Text = "Стать";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(505, 181);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 17);
			this.label5.TabIndex = 28;
			this.label5.Text = "Дата зарахування";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(505, 143);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 29;
			this.label6.Text = "Телефон";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(505, 102);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 17);
			this.label7.TabIndex = 30;
			this.label7.Text = "Email";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(505, 63);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 17);
			this.label8.TabIndex = 31;
			this.label8.Text = "Дата народження";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(709, 64);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 17);
			this.label9.TabIndex = 31;
			this.label9.Text = "Спеціальність";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(709, 103);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 17);
			this.label10.TabIndex = 30;
			this.label10.Text = "Стан";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitToolStripMenuItem.FlatAppearance.BorderSize = 0;
			this.exitToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitToolStripMenuItem.Image = global::LMVZ.Properties.Resources.shutdown_24px;
			this.exitToolStripMenuItem.Location = new System.Drawing.Point(1092, 25);
			this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(59, 55);
			this.exitToolStripMenuItem.TabIndex = 25;
			this.exitToolStripMenuItem.UseVisualStyleBackColor = true;
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(217)))), ((int)(((byte)(156)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = global::LMVZ.Properties.Resources.us_dollar_circled_24px;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(848, 433);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(247, 42);
			this.button1.TabIndex = 24;
			this.button1.Text = "       Сплатити";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = global::LMVZ.Properties.Resources.warning_shield_24px;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(16, 410);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(247, 42);
			this.button2.TabIndex = 24;
			this.button2.Text = "  Відрахувати";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = global::LMVZ.Properties.Resources.army_star_24px;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(16, 361);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(247, 42);
			this.button3.TabIndex = 24;
			this.button3.Text = "  Військовий квиток";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 50);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 239);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Image = global::LMVZ.Properties.Resources.edit_24px_white;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(16, 311);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(247, 42);
			this.button4.TabIndex = 24;
			this.button4.Text = "  Редагувати дані";
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// TransactionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1163, 785);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.exitToolStripMenuItem);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "TransactionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TransactionForm";
			this.Load += new System.EventHandler(this.TransactionForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource studentsDBDataSetBindingSource;
		private StudentsDBDataSet studentsDBDataSet;
		private System.Windows.Forms.BindingSource transactionsBindingSource;
		private StudentsDBDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}