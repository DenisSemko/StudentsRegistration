namespace LMVZ
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.studentsDBDataSet = new LMVZ.StudentsDBDataSet();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsTableAdapter = new LMVZ.StudentsDBDataSetTableAdapters.StudentsTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.uploadToolStripMenuItem = new System.Windows.Forms.Button();
			this.panelUpload = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button3 = new System.Windows.Forms.Button();
			this.addToolStripMenuItem = new System.Windows.Forms.Button();
			this.exitToolStripMenuItem = new System.Windows.Forms.Button();
			this.deleteToolStripMenuItem = new System.Windows.Forms.Button();
			this.editingToolStripMenuItem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchTextBox
			// 
			this.searchTextBox.AcceptsTab = true;
			this.searchTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchTextBox.ForeColor = System.Drawing.Color.Black;
			this.searchTextBox.Location = new System.Drawing.Point(19, 7);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(267, 25);
			this.searchTextBox.TabIndex = 10;
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
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(243, 305);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1211, 481);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
			this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem14});
			this.menuStrip1.Location = new System.Drawing.Point(0, 22);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
			this.menuStrip1.Size = new System.Drawing.Size(287, 38);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
			this.toolStripMenuItem10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem10.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(117, 26);
			this.toolStripMenuItem10.Text = "Фільтрація";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(246, 26);
			this.toolStripMenuItem11.Text = "За спеціальністю";
			this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(246, 26);
			this.toolStripMenuItem12.Text = "За станом";
			this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(246, 26);
			this.toolStripMenuItem13.Text = "За статею";
			this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20});
			this.toolStripMenuItem14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripMenuItem14.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(132, 26);
			this.toolStripMenuItem14.Text = "Сортування";
			// 
			// toolStripMenuItem15
			// 
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			this.toolStripMenuItem15.Size = new System.Drawing.Size(263, 26);
			this.toolStripMenuItem15.Text = "toolStripMenuItem1";
			this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem16
			// 
			this.toolStripMenuItem16.Name = "toolStripMenuItem16";
			this.toolStripMenuItem16.Size = new System.Drawing.Size(263, 26);
			this.toolStripMenuItem16.Text = "toolStripMenuItem2";
			this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem17
			// 
			this.toolStripMenuItem17.Name = "toolStripMenuItem17";
			this.toolStripMenuItem17.Size = new System.Drawing.Size(263, 26);
			this.toolStripMenuItem17.Text = "toolStripMenuItem6";
			this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// toolStripMenuItem18
			// 
			this.toolStripMenuItem18.Name = "toolStripMenuItem18";
			this.toolStripMenuItem18.Size = new System.Drawing.Size(263, 26);
			this.toolStripMenuItem18.Text = "toolStripMenuItem7";
			this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
			// 
			// toolStripMenuItem19
			// 
			this.toolStripMenuItem19.Name = "toolStripMenuItem19";
			this.toolStripMenuItem19.Size = new System.Drawing.Size(263, 26);
			this.toolStripMenuItem19.Text = "toolStripMenuItem8";
			this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
			// 
			// toolStripMenuItem20
			// 
			this.toolStripMenuItem20.Name = "toolStripMenuItem20";
			this.toolStripMenuItem20.Size = new System.Drawing.Size(263, 26);
			this.toolStripMenuItem20.Text = "toolStripMenuItem9";
			this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.studentsDBDataSet;
			this.bindingSource1.Position = 0;
			// 
			// studentsDBDataSet
			// 
			this.studentsDBDataSet.DataSetName = "StudentsDBDataSet";
			this.studentsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "Students";
			this.studentsBindingSource.DataSource = this.bindingSource1;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.uploadToolStripMenuItem);
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 786);
			this.panel1.TabIndex = 13;
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(9, 179);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(227, 78);
			this.button4.TabIndex = 1;
			this.button4.Text = "    Допомога";
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// uploadToolStripMenuItem
			// 
			this.uploadToolStripMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.uploadToolStripMenuItem.FlatAppearance.BorderSize = 0;
			this.uploadToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.uploadToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uploadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.uploadToolStripMenuItem.Image = global::LMVZ.Properties.Resources.dropbox_24px;
			this.uploadToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.uploadToolStripMenuItem.Location = new System.Drawing.Point(13, 82);
			this.uploadToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
			this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
			this.uploadToolStripMenuItem.Size = new System.Drawing.Size(227, 78);
			this.uploadToolStripMenuItem.TabIndex = 0;
			this.uploadToolStripMenuItem.Text = "  Завантажити з   файлу";
			this.uploadToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.uploadToolStripMenuItem.UseVisualStyleBackColor = true;
			this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
			this.uploadToolStripMenuItem.MouseLeave += new System.EventHandler(this.uploadToolStripMenuItem_MouseLeave);
			this.uploadToolStripMenuItem.MouseHover += new System.EventHandler(this.uploadToolStripMenuItem_MouseHover);
			// 
			// panelUpload
			// 
			this.panelUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panelUpload.Location = new System.Drawing.Point(3, 82);
			this.panelUpload.Margin = new System.Windows.Forms.Padding(4);
			this.panelUpload.Name = "panelUpload";
			this.panelUpload.Size = new System.Drawing.Size(13, 78);
			this.panelUpload.TabIndex = 14;
			this.panelUpload.Visible = false;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel5.Location = new System.Drawing.Point(243, 0);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1757, 17);
			this.panel5.TabIndex = 19;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel6.Controls.Add(this.label4);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Controls.Add(this.pictureBox1);
			this.panel6.Location = new System.Drawing.Point(285, 15);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(217, 230);
			this.panel6.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(17, 193);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 22);
			this.label4.TabIndex = 22;
			this.label4.Text = "відділу кадрів";
			this.label4.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(17, 169);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 22);
			this.label3.TabIndex = 22;
			this.label3.Text = "E-Система для";
			this.label3.Click += new System.EventHandler(this.label2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(17, 134);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Облік Студентів";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LMVZ.Properties.Resources.student_male_100px;
			this.pictureBox1.Location = new System.Drawing.Point(39, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(133, 110);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel7.Controls.Add(this.searchTextBox);
			this.panel7.Controls.Add(this.button2);
			this.panel7.Controls.Add(this.button1);
			this.panel7.Location = new System.Drawing.Point(844, 230);
			this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(400, 42);
			this.panel7.TabIndex = 21;
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Image = global::LMVZ.Properties.Resources.delete_24px1;
			this.button2.Location = new System.Drawing.Point(355, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 42);
			this.button2.TabIndex = 11;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::LMVZ.Properties.Resources.search_24px;
			this.button1.Location = new System.Drawing.Point(288, 0);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 42);
			this.button1.TabIndex = 11;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.menuStrip1);
			this.panel3.Location = new System.Drawing.Point(564, 212);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(287, 60);
			this.panel3.TabIndex = 22;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
			this.toolStripMenuItem1.Text = "toolStripMenuItem1";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
			this.toolStripMenuItem2.Text = "toolStripMenuItem2";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(217, 26);
			this.toolStripMenuItem6.Text = "toolStripMenuItem6";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(217, 26);
			this.toolStripMenuItem7.Text = "toolStripMenuItem7";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(217, 26);
			this.toolStripMenuItem8.Text = "toolStripMenuItem8";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(217, 26);
			this.toolStripMenuItem9.Text = "toolStripMenuItem9";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
			// 
			// sortToolStripMenuItem
			// 
			this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
			this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
			this.sortToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.sortToolStripMenuItem.Text = "Сортування";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 26);
			this.toolStripMenuItem3.Text = "За спеціальністю";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(203, 26);
			this.toolStripMenuItem4.Text = "За станом";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(203, 26);
			this.toolStripMenuItem5.Text = "За статею";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// filterToolStripMenuItem
			// 
			this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
			this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
			this.filterToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.filterToolStripMenuItem.Text = "Фільтрація";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = global::LMVZ.Properties.Resources.male_user_24px;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(1260, 230);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(247, 42);
			this.button3.TabIndex = 23;
			this.button3.Text = "   Акаунт студента";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addToolStripMenuItem.FlatAppearance.BorderSize = 0;
			this.addToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addToolStripMenuItem.Image = global::LMVZ.Properties.Resources.add_96px;
			this.addToolStripMenuItem.Location = new System.Drawing.Point(1392, 633);
			this.addToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(115, 108);
			this.addToolStripMenuItem.TabIndex = 18;
			this.addToolStripMenuItem.UseVisualStyleBackColor = true;
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitToolStripMenuItem.FlatAppearance.BorderSize = 0;
			this.exitToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitToolStripMenuItem.Image = global::LMVZ.Properties.Resources.shutdown_24px;
			this.exitToolStripMenuItem.Location = new System.Drawing.Point(1474, 25);
			this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 55);
			this.exitToolStripMenuItem.TabIndex = 18;
			this.exitToolStripMenuItem.UseVisualStyleBackColor = true;
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.FlatAppearance.BorderSize = 0;
			this.deleteToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteToolStripMenuItem.Image = global::LMVZ.Properties.Resources.remove_36px;
			this.deleteToolStripMenuItem.Location = new System.Drawing.Point(1474, 395);
			this.deleteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(64, 59);
			this.deleteToolStripMenuItem.TabIndex = 11;
			this.deleteToolStripMenuItem.UseVisualStyleBackColor = true;
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// editingToolStripMenuItem
			// 
			this.editingToolStripMenuItem.FlatAppearance.BorderSize = 0;
			this.editingToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editingToolStripMenuItem.Image = global::LMVZ.Properties.Resources.edit_36px;
			this.editingToolStripMenuItem.Location = new System.Drawing.Point(1474, 305);
			this.editingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.editingToolStripMenuItem.Name = "editingToolStripMenuItem";
			this.editingToolStripMenuItem.Size = new System.Drawing.Size(64, 59);
			this.editingToolStripMenuItem.TabIndex = 11;
			this.editingToolStripMenuItem.UseVisualStyleBackColor = true;
			this.editingToolStripMenuItem.Click += new System.EventHandler(this.editingToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1942, 786);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.addToolStripMenuItem);
			this.Controls.Add(this.exitToolStripMenuItem);
			this.Controls.Add(this.panelUpload);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.deleteToolStripMenuItem);
			this.Controls.Add(this.editingToolStripMenuItem);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox searchTextBox;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private StudentsDBDataSet studentsDBDataSet;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private StudentsDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uploadToolStripMenuItem;
        private System.Windows.Forms.Panel panelUpload;
        private System.Windows.Forms.Button exitToolStripMenuItem;
        private System.Windows.Forms.Button addToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editingToolStripMenuItem;
        private System.Windows.Forms.Button deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
	}
}

