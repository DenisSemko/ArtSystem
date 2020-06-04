namespace CourseWork1._0
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.iconButtonOwnColl = new FontAwesome.Sharp.IconButton();
			this.iconButtonShop = new FontAwesome.Sharp.IconButton();
			this.iconButtonAuction = new FontAwesome.Sharp.IconButton();
			this.iconButtonCollection = new FontAwesome.Sharp.IconButton();
			this.iconButtonMuseum = new FontAwesome.Sharp.IconButton();
			this.iconButtonPictures = new FontAwesome.Sharp.IconButton();
			this.iconButtonArtists = new FontAwesome.Sharp.IconButton();
			this.panelUp = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.iconButtonMin = new FontAwesome.Sharp.IconButton();
			this.iconButtonMax = new FontAwesome.Sharp.IconButton();
			this.iconButtonExit = new FontAwesome.Sharp.IconButton();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelMenu.SuspendLayout();
			this.panelUp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMenu.Controls.Add(this.iconButtonOwnColl);
			this.panelMenu.Controls.Add(this.iconButtonShop);
			this.panelMenu.Controls.Add(this.iconButtonAuction);
			this.panelMenu.Controls.Add(this.iconButtonCollection);
			this.panelMenu.Controls.Add(this.iconButtonMuseum);
			this.panelMenu.Controls.Add(this.iconButtonPictures);
			this.panelMenu.Controls.Add(this.iconButtonArtists);
			this.panelMenu.Controls.Add(this.panelUp);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(220, 609);
			this.panelMenu.TabIndex = 0;
			// 
			// iconButtonOwnColl
			// 
			this.iconButtonOwnColl.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonOwnColl.FlatAppearance.BorderSize = 0;
			this.iconButtonOwnColl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonOwnColl.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonOwnColl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonOwnColl.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonOwnColl.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
			this.iconButtonOwnColl.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonOwnColl.IconSize = 32;
			this.iconButtonOwnColl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonOwnColl.Location = new System.Drawing.Point(0, 500);
			this.iconButtonOwnColl.Name = "iconButtonOwnColl";
			this.iconButtonOwnColl.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonOwnColl.Rotation = 0D;
			this.iconButtonOwnColl.Size = new System.Drawing.Size(220, 60);
			this.iconButtonOwnColl.TabIndex = 13;
			this.iconButtonOwnColl.Text = "Власна колекція";
			this.iconButtonOwnColl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonOwnColl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonOwnColl.UseVisualStyleBackColor = true;
			this.iconButtonOwnColl.Click += new System.EventHandler(this.iconButtonOwnColl_Click);
			// 
			// iconButtonShop
			// 
			this.iconButtonShop.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonShop.FlatAppearance.BorderSize = 0;
			this.iconButtonShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonShop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonShop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonShop.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonShop.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
			this.iconButtonShop.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonShop.IconSize = 32;
			this.iconButtonShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonShop.Location = new System.Drawing.Point(0, 440);
			this.iconButtonShop.Name = "iconButtonShop";
			this.iconButtonShop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonShop.Rotation = 0D;
			this.iconButtonShop.Size = new System.Drawing.Size(220, 60);
			this.iconButtonShop.TabIndex = 12;
			this.iconButtonShop.Text = "Комісійний магазин";
			this.iconButtonShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonShop.UseVisualStyleBackColor = true;
			this.iconButtonShop.Click += new System.EventHandler(this.iconButtonShop_Click);
			// 
			// iconButtonAuction
			// 
			this.iconButtonAuction.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonAuction.FlatAppearance.BorderSize = 0;
			this.iconButtonAuction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonAuction.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonAuction.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonAuction.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonAuction.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
			this.iconButtonAuction.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonAuction.IconSize = 32;
			this.iconButtonAuction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonAuction.Location = new System.Drawing.Point(0, 380);
			this.iconButtonAuction.Name = "iconButtonAuction";
			this.iconButtonAuction.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonAuction.Rotation = 0D;
			this.iconButtonAuction.Size = new System.Drawing.Size(220, 60);
			this.iconButtonAuction.TabIndex = 11;
			this.iconButtonAuction.Text = "Аукціон";
			this.iconButtonAuction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonAuction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonAuction.UseVisualStyleBackColor = true;
			this.iconButtonAuction.Click += new System.EventHandler(this.iconButtonAuction_Click);
			// 
			// iconButtonCollection
			// 
			this.iconButtonCollection.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonCollection.FlatAppearance.BorderSize = 0;
			this.iconButtonCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonCollection.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonCollection.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonCollection.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonCollection.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
			this.iconButtonCollection.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonCollection.IconSize = 32;
			this.iconButtonCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonCollection.Location = new System.Drawing.Point(0, 320);
			this.iconButtonCollection.Name = "iconButtonCollection";
			this.iconButtonCollection.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonCollection.Rotation = 0D;
			this.iconButtonCollection.Size = new System.Drawing.Size(220, 60);
			this.iconButtonCollection.TabIndex = 10;
			this.iconButtonCollection.Text = "Колекціонер";
			this.iconButtonCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonCollection.UseVisualStyleBackColor = true;
			this.iconButtonCollection.Click += new System.EventHandler(this.iconButtonCollection_Click);
			// 
			// iconButtonMuseum
			// 
			this.iconButtonMuseum.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonMuseum.FlatAppearance.BorderSize = 0;
			this.iconButtonMuseum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonMuseum.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonMuseum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonMuseum.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonMuseum.IconChar = FontAwesome.Sharp.IconChar.Landmark;
			this.iconButtonMuseum.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonMuseum.IconSize = 32;
			this.iconButtonMuseum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonMuseum.Location = new System.Drawing.Point(0, 260);
			this.iconButtonMuseum.Name = "iconButtonMuseum";
			this.iconButtonMuseum.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonMuseum.Rotation = 0D;
			this.iconButtonMuseum.Size = new System.Drawing.Size(220, 60);
			this.iconButtonMuseum.TabIndex = 9;
			this.iconButtonMuseum.Text = "Музей";
			this.iconButtonMuseum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonMuseum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonMuseum.UseVisualStyleBackColor = true;
			this.iconButtonMuseum.Click += new System.EventHandler(this.iconButtonMuseum_Click);
			// 
			// iconButtonPictures
			// 
			this.iconButtonPictures.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonPictures.FlatAppearance.BorderSize = 0;
			this.iconButtonPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonPictures.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonPictures.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonPictures.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonPictures.IconChar = FontAwesome.Sharp.IconChar.Images;
			this.iconButtonPictures.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonPictures.IconSize = 32;
			this.iconButtonPictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonPictures.Location = new System.Drawing.Point(0, 200);
			this.iconButtonPictures.Name = "iconButtonPictures";
			this.iconButtonPictures.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonPictures.Rotation = 0D;
			this.iconButtonPictures.Size = new System.Drawing.Size(220, 60);
			this.iconButtonPictures.TabIndex = 8;
			this.iconButtonPictures.Text = "Картини";
			this.iconButtonPictures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonPictures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonPictures.UseVisualStyleBackColor = true;
			this.iconButtonPictures.Click += new System.EventHandler(this.iconButtonPictures_Click);
			// 
			// iconButtonArtists
			// 
			this.iconButtonArtists.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonArtists.FlatAppearance.BorderSize = 0;
			this.iconButtonArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonArtists.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonArtists.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.iconButtonArtists.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonArtists.IconChar = FontAwesome.Sharp.IconChar.User;
			this.iconButtonArtists.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonArtists.IconSize = 32;
			this.iconButtonArtists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonArtists.Location = new System.Drawing.Point(0, 140);
			this.iconButtonArtists.Name = "iconButtonArtists";
			this.iconButtonArtists.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonArtists.Rotation = 0D;
			this.iconButtonArtists.Size = new System.Drawing.Size(220, 60);
			this.iconButtonArtists.TabIndex = 7;
			this.iconButtonArtists.Text = "Художники";
			this.iconButtonArtists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonArtists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonArtists.UseVisualStyleBackColor = true;
			this.iconButtonArtists.Click += new System.EventHandler(this.iconButtonArtists_Click);
			// 
			// panelUp
			// 
			this.panelUp.Controls.Add(this.btnHome);
			this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUp.Location = new System.Drawing.Point(0, 0);
			this.panelUp.Name = "panelUp";
			this.panelUp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.panelUp.Size = new System.Drawing.Size(220, 140);
			this.panelUp.TabIndex = 1;
			// 
			// btnHome
			// 
			this.btnHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHome.ErrorImage")));
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.Location = new System.Drawing.Point(30, 25);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(150, 81);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panelTitleBar.Controls.Add(this.iconButtonMin);
			this.panelTitleBar.Controls.Add(this.iconButtonMax);
			this.panelTitleBar.Controls.Add(this.iconButtonExit);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1065, 75);
			this.panelTitleBar.TabIndex = 1;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// iconButtonMin
			// 
			this.iconButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconButtonMin.FlatAppearance.BorderSize = 0;
			this.iconButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
			this.iconButtonMin.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonMin.IconSize = 16;
			this.iconButtonMin.Location = new System.Drawing.Point(916, 25);
			this.iconButtonMin.Name = "iconButtonMin";
			this.iconButtonMin.Rotation = 0D;
			this.iconButtonMin.Size = new System.Drawing.Size(40, 23);
			this.iconButtonMin.TabIndex = 6;
			this.iconButtonMin.UseVisualStyleBackColor = true;
			this.iconButtonMin.Click += new System.EventHandler(this.iconButtonMin_Click);
			// 
			// iconButtonMax
			// 
			this.iconButtonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconButtonMax.FlatAppearance.BorderSize = 0;
			this.iconButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.iconButtonMax.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonMax.IconSize = 16;
			this.iconButtonMax.Location = new System.Drawing.Point(962, 23);
			this.iconButtonMax.Name = "iconButtonMax";
			this.iconButtonMax.Rotation = 0D;
			this.iconButtonMax.Size = new System.Drawing.Size(44, 28);
			this.iconButtonMax.TabIndex = 5;
			this.iconButtonMax.UseVisualStyleBackColor = true;
			this.iconButtonMax.Click += new System.EventHandler(this.iconButtonMax_Click);
			// 
			// iconButtonExit
			// 
			this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconButtonExit.FlatAppearance.BorderSize = 0;
			this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.iconButtonExit.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonExit.IconSize = 23;
			this.iconButtonExit.Location = new System.Drawing.Point(1012, 17);
			this.iconButtonExit.Name = "iconButtonExit";
			this.iconButtonExit.Rotation = 0D;
			this.iconButtonExit.Size = new System.Drawing.Size(39, 41);
			this.iconButtonExit.TabIndex = 4;
			this.iconButtonExit.UseVisualStyleBackColor = true;
			this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblTitleChildForm.Location = new System.Drawing.Point(56, 40);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(59, 21);
			this.lblTitleChildForm.TabIndex = 3;
			this.lblTitleChildForm.Text = "Home";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
			this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 25);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
			this.iconCurrentChildForm.TabIndex = 2;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(220, 75);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1065, 9);
			this.panelShadow.TabIndex = 2;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.panelDesktop.Controls.Add(this.label1);
			this.panelDesktop.Controls.Add(this.pictureBox1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(220, 84);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1065, 525);
			this.panelDesktop.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.label1.Location = new System.Drawing.Point(315, 453);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(544, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "There is nothing more truly artistic than to love people. ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(155, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(851, 400);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 609);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelUp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton iconButtonOwnColl;
		private FontAwesome.Sharp.IconButton iconButtonShop;
		private FontAwesome.Sharp.IconButton iconButtonAuction;
		private FontAwesome.Sharp.IconButton iconButtonCollection;
		private FontAwesome.Sharp.IconButton iconButtonMuseum;
		private FontAwesome.Sharp.IconButton iconButtonPictures;
		private FontAwesome.Sharp.IconButton iconButtonArtists;
		private System.Windows.Forms.Panel panelUp;
		private System.Windows.Forms.PictureBox btnHome;
		private System.Windows.Forms.Panel panelTitleBar;
		private FontAwesome.Sharp.IconButton iconButtonMin;
		private FontAwesome.Sharp.IconButton iconButtonMax;
		private FontAwesome.Sharp.IconButton iconButtonExit;
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
		private System.Windows.Forms.Panel panelShadow;
		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

