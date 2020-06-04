using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork1._0
{
	public partial class MainForm : Form
	{

		private IconButton currentBtn;
		private Panel leftBorderBtn;
		private Form currentChildForm;
		private AddArtistForm adf;

		public MainForm()
		{
			InitializeComponent();
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}

		// різноманітність кольорів для значків
		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(172, 126, 241);
			public static Color color2 = Color.FromArgb(249, 118, 176);
			public static Color color3 = Color.FromArgb(253, 138, 114);
			public static Color color4 = Color.FromArgb(95, 77, 221);
			public static Color color5 = Color.FromArgb(249, 88, 155);
			public static Color color6 = Color.FromArgb(24, 161, 251);
			public static Color color7 = Color.FromArgb(253, 138, 114);
		}

		// кнопка активації показу форми
		private void ActivateButton(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				DisableButton();

				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.FromArgb(37, 36, 81);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();

				iconCurrentChildForm.IconChar = currentBtn.IconChar;
				iconCurrentChildForm.IconColor = color;

			}
		}

		// кнопка деактивації показу форми
		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(31, 30, 68);
				currentBtn.ForeColor = Color.Gainsboro;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.Gainsboro;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

			}
		}
		private void OpenChildForm(Form childForm)
		{
			if (currentChildForm != null)
			{
				//open only form
				currentChildForm.Close();
			}

			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitleChildForm.Text = childForm.Text;
		}

		private void iconButtonArtists_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			ArtistForm afff = new ArtistForm();
			adf = new AddArtistForm();
			OpenChildForm(afff);
		}

		private void iconButtonPictures_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color2);
			PicturesForm pf = new PicturesForm();
			OpenChildForm(pf);
		}

		private void iconButtonMuseum_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			MuseumsForm mf = new MuseumsForm();
			OpenChildForm(mf);
		}

		private void iconButtonCollection_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color4);
			CollectionersForm cf = new CollectionersForm();
			OpenChildForm(cf);
		}

		private void iconButtonAuction_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color5);
			AuctionForm auf = new AuctionForm();
			OpenChildForm(auf);
		}

		private void iconButtonShop_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color6);
			CommissionShopForm csf = new CommissionShopForm();
			OpenChildForm(csf);
		}

		private void iconButtonOwnColl_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color7);
			OwnCollectionForm ocf = new OwnCollectionForm();
			OpenChildForm(ocf);
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			currentChildForm.Close();
			Reset();
		}
		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
			iconCurrentChildForm.IconChar = IconChar.Home;
			iconCurrentChildForm.IconColor = Color.MediumPurple;
			lblTitleChildForm.Text = "Home";
		}

		//Для пересування форми
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void iconButtonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void iconButtonMax_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;

			}
			else
			{
				WindowState = FormWindowState.Normal;
			}
		}

		private void iconButtonMin_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		
		}

	}
}
