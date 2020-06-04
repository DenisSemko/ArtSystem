using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CourseWork1._0
{
	public partial class PicturesForm : Form
	{
		internal Art art;
		public string chooseArtist;
		public AddPictureForm adpf = new AddPictureForm();
		public PicturesForm()
		{
			art = new Art();
			InitializeComponent();
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddPictureForm adpf = new AddPictureForm();
			if (adpf.ShowDialog() == DialogResult.OK)
			{
				art.AddPicture(adpf.picture);
				pictureBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewPicture.Rows.Count - 1;
				dataGridViewPicture.Rows[lastIdx].Selected = true;
				dataGridViewPicture.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}

		private void PicturesForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewPicture.Rows.Clear();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewPicture.SelectedRows[0].DataBoundItem as Picture;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.pictures.Remove(deleteItem);
				pictureBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var sortedListAuthorName = from p in art.pictures
				orderby p.authorName
				select p;
			pictureBindingSource.DataSource = sortedListAuthorName;
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			var sortedListPictureName = from p in art.pictures
				orderby p.pictureName
				select p;
			pictureBindingSource.DataSource = sortedListPictureName;
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem15_Click(object sender, EventArgs e)
		{
			var sortedListPictureGenre = from p in art.pictures
				orderby p.pictureGenre
				select p;
			pictureBindingSource.DataSource = sortedListPictureGenre;
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem16_Click(object sender, EventArgs e)
		{
			var sortedListDrawingMaterial = from p in art.pictures
				orderby p.drawingMaterial
				select p;
			pictureBindingSource.DataSource = sortedListDrawingMaterial;
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem17_Click(object sender, EventArgs e)
		{
			var sortedListPictureSize = from p in art.pictures
				orderby p.pictureSize
				select p;
			pictureBindingSource.DataSource = sortedListPictureSize;
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
			var sortedListDisplayMethod = from p in art.pictures
				orderby p.displayMethod
				select p;
			pictureBindingSource.DataSource = sortedListDisplayMethod;
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.authorName = toolStripTextBox1.Text;
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem22.Visible = true;

		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.pictureName = toolStripTextBox1.Text;
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem23.Visible = true;
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.pictureGenre = toolStripTextBox1.Text;
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem24.Visible = true;
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.pictureYear = int.Parse(toolStripTextBox1.Text);
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem25.Visible = true;
		}

		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.drawingMaterial = toolStripTextBox1.Text;
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem26.Visible = true;
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.pictureSize = toolStripTextBox1.Text;
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem27.Visible = true;
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Picture pctrs = new Picture();
			List<Picture> newPictures = new List<Picture>();
			try
			{
				pctrs.displayMethod = toolStripTextBox1.Text;
				foreach (Picture p in art.pictures)
				{
					if (pctrs.authorName == p.authorName)
					{
						int k = art.pictures.IndexOf(p);
						newPictures.Add(art.pictures[k]);
						pictureBindingSource.DataSource = newPictures;
					}
				}
			}
			catch
			{
				newPictures = art.pictures;
			}
			pictureBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem28.Visible = true;
		}

		private void toolStripMenuItem19_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewPicture.SelectedRows[0].DataBoundItem as Picture;
			AddPictureForm adpf = new AddPictureForm(editTool);
			if (adpf.ShowDialog() == DialogResult.OK)
			{
				pictureBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}

		private void toolStripMenuItem20_Click(object sender, EventArgs e)
		{
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem21_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void toolStripMenuItem22_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem23_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem24_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem25_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem26_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem27_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem28_Click(object sender, EventArgs e)
		{
			pictureBindingSource.DataSource = art.pictures;
			art.Load();
			pictureBindingSource.ResetBindings(false);
		}

		private void dataGridViewPicture_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			chooseArtist = dataGridViewPicture.SelectedCells[0].Value.ToString();
			adpf.textBox7.Text = chooseArtist;
			textBox1.Text = chooseArtist;
			textBox1.Visible = true;
			button1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (adpf.ShowDialog() == DialogResult.OK)
			{
				art.AddPicture(adpf.picture);
				pictureBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewPicture.Rows.Count - 1;
				dataGridViewPicture.Rows[lastIdx].Selected = true;
				dataGridViewPicture.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
	}
}
