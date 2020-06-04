namespace CourseWork1._0
{
	partial class ArtistForm
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
			this.dataGridViewArtist = new System.Windows.Forms.DataGridView();
			this.menuStripAritsts = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.drawStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.styleOfDrawingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.artistBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).BeginInit();
			this.menuStripAritsts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewArtist
			// 
			this.dataGridViewArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewArtist.AutoGenerateColumns = false;
			this.dataGridViewArtist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewArtist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewArtist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.dataGridViewArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewArtist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridViewArtist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewArtist.ColumnHeadersHeight = 30;
			this.dataGridViewArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.styleOfDrawingDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
			this.dataGridViewArtist.DataSource = this.artistBindingSource;
			this.dataGridViewArtist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dataGridViewArtist.Location = new System.Drawing.Point(197, 165);
			this.dataGridViewArtist.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewArtist.Name = "dataGridViewArtist";
			this.dataGridViewArtist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewArtist.RowHeadersWidth = 75;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
			this.dataGridViewArtist.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewArtist.RowTemplate.Height = 24;
			this.dataGridViewArtist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewArtist.Size = new System.Drawing.Size(665, 239);
			this.dataGridViewArtist.TabIndex = 0;
			// menuStripAritsts
			// 
			this.menuStripAritsts.AutoSize = false;
			this.menuStripAritsts.BackColor = System.Drawing.Color.Thistle;
			this.menuStripAritsts.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStripAritsts.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripAritsts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItemSearch});
			this.menuStripAritsts.Location = new System.Drawing.Point(373, 87);
			this.menuStripAritsts.Name = "menuStripAritsts";
			this.menuStripAritsts.Size = new System.Drawing.Size(302, 43);
			this.menuStripAritsts.TabIndex = 1;
			this.menuStripAritsts.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem6,
            this.toolStripMenuItem10,
            this.toolStripMenuItem5});
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 39);
			this.toolStripMenuItem1.Text = "Дії з даними";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(281, 26);
			this.toolStripMenuItem4.Text = "Додати інформацію";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(281, 26);
			this.toolStripMenuItem3.Text = "Редагувати інформацію";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(281, 26);
			this.toolStripMenuItem6.Text = "Видалити інформацію";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(281, 26);
			this.toolStripMenuItem10.Text = "Завантажити інформацію";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(281, 26);
			this.toolStripMenuItem5.Text = "Зберегти зміни";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.drawStyleToolStripMenuItem,
            this.brthToolStripMenuItem});
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 39);
			this.toolStripMenuItem2.Text = "Сортування";
			// 
			// nameToolStripMenuItem
			// 
			this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
			this.nameToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.nameToolStripMenuItem.Text = "Ім\'я";
			this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
			// 
			// countryToolStripMenuItem
			// 
			this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
			this.countryToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.countryToolStripMenuItem.Text = "Країна";
			this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
			// 
			// drawStyleToolStripMenuItem
			// 
			this.drawStyleToolStripMenuItem.Name = "drawStyleToolStripMenuItem";
			this.drawStyleToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.drawStyleToolStripMenuItem.Text = "Стиль малювання";
			this.drawStyleToolStripMenuItem.Click += new System.EventHandler(this.drawStyleToolStripMenuItem_Click);
			// 
			// brthToolStripMenuItem
			// 
			this.brthToolStripMenuItem.Name = "brthToolStripMenuItem";
			this.brthToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
			this.brthToolStripMenuItem.Text = "Дата народження";
			this.brthToolStripMenuItem.Click += new System.EventHandler(this.brthToolStripMenuItem_Click);
			// 
			// toolStripMenuItemSearch
			// 
			this.toolStripMenuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
			this.toolStripMenuItemSearch.Name = "toolStripMenuItemSearch";
			this.toolStripMenuItemSearch.Size = new System.Drawing.Size(67, 39);
			this.toolStripMenuItemSearch.Text = "Пошук";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(135, 27);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(238, 26);
			this.toolStripMenuItem7.Text = "За ім\'ям";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(153, 26);
			this.toolStripMenuItem11.Text = "Відмінити";
			this.toolStripMenuItem11.Visible = false;
			this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12});
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(238, 26);
			this.toolStripMenuItem8.Text = "За країною";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(153, 26);
			this.toolStripMenuItem12.Text = "Відмінити";
			this.toolStripMenuItem12.Visible = false;
			this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13});
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(238, 26);
			this.toolStripMenuItem9.Text = "За стилем малювання";
			this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(153, 26);
			this.toolStripMenuItem13.Text = "Відмінити";
			this.toolStripMenuItem13.Visible = false;
			this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
			// 
			// artistNameDataGridViewTextBoxColumn
			// 
			this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "artistName";
			this.artistNameDataGridViewTextBoxColumn.HeaderText = "artistName";
			this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
			this.artistNameDataGridViewTextBoxColumn.Width = 105;
			// 
			// countryDataGridViewTextBoxColumn
			// 
			this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
			this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
			this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
			this.countryDataGridViewTextBoxColumn.Width = 86;
			// 
			// styleOfDrawingDataGridViewTextBoxColumn
			// 
			this.styleOfDrawingDataGridViewTextBoxColumn.DataPropertyName = "styleOfDrawing";
			this.styleOfDrawingDataGridViewTextBoxColumn.HeaderText = "styleOfDrawing";
			this.styleOfDrawingDataGridViewTextBoxColumn.Name = "styleOfDrawingDataGridViewTextBoxColumn";
			this.styleOfDrawingDataGridViewTextBoxColumn.Width = 132;
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.Width = 109;
			// 
			// artistBindingSource
			// 
			this.artistBindingSource.DataSource = typeof(CourseWork1._0.Artist);
			// 
			// ArtistForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1041, 518);
			this.Controls.Add(this.dataGridViewArtist);
			this.Controls.Add(this.menuStripAritsts);
			this.MainMenuStrip = this.menuStripAritsts;
			this.Name = "ArtistForm";
			this.Text = "ArtistForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArtistForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtist)).EndInit();
			this.menuStripAritsts.ResumeLayout(false);
			this.menuStripAritsts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.artistBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridViewArtist;
		private System.Windows.Forms.MenuStrip menuStripAritsts;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSearch;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem drawStyleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem brthToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn styleOfDrawingDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource artistBindingSource;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
	}
}