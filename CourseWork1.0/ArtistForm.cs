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
	public partial class ArtistForm : Form
	{
		internal Art art;
		public ArtistForm()
		{
			art = new Art();
			InitializeComponent();
			artistBindingSource.DataSource = art.artists;
			art.Load();
			artistBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddArtistForm addf = new AddArtistForm();
			if (addf.ShowDialog() == DialogResult.OK)
			{
				art.AddArtist(addf.artist);
				artistBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewArtist.Rows.Count - 1;
				dataGridViewArtist.Rows[lastIdx].Selected = true;
				dataGridViewArtist.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}

		private void ArtistForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewArtist.Rows.Clear();
		}

		private void nameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sortedListName = from l in art.artists
				orderby l.artistName
				select l;
			artistBindingSource.DataSource = sortedListName;
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();

		}

		private void countryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sortedListCountry = from l in art.artists
				orderby l.Country
				select l;
			artistBindingSource.DataSource = sortedListCountry;
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void drawStyleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sortedListDraw = from l in art.artists
				orderby l.styleOfDrawing
				select l;
			artistBindingSource.DataSource = sortedListDraw;
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void brthToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var sortedListBrth = from l in art.artists
				orderby l.dateOfBirth
				select l;
			artistBindingSource.DataSource = sortedListBrth;
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			Artist arts = new Artist();
			List<Artist> newArtists = new List<Artist>();
			try
			{
				arts.artistName = toolStripTextBox1.Text;
				foreach (Artist ar in art.artists)
				{
					if (arts.artistName == ar.artistName)
					{
						int k = art.artists.IndexOf(ar);
						newArtists.Add(art.artists[k]);
						artistBindingSource.DataSource = newArtists;
					}
				}
			}
			catch
			{
				newArtists = art.artists;
			}
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem11.Visible = true;
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			Artist arts = new Artist();
			List<Artist> newArtists = new List<Artist>();
			try
			{
				arts.Country = toolStripTextBox1.Text;
				foreach (Artist ar in art.artists)
				{
					if (arts.Country == ar.Country)
					{
						int k = art.artists.IndexOf(ar);
						newArtists.Add(art.artists[k]);
						artistBindingSource.DataSource = newArtists;
					}
				}
			}
			catch
			{
				newArtists = art.artists;
			}
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem12.Visible = true;
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			Artist arts = new Artist();
			List<Artist> newArtists = new List<Artist>();
			try
			{
				arts.styleOfDrawing = toolStripTextBox1.Text;
				foreach (Artist ar in art.artists)
				{
					if (arts.styleOfDrawing == ar.styleOfDrawing)
					{
						int k = art.artists.IndexOf(ar);
						newArtists.Add(art.artists[k]);
						artistBindingSource.DataSource = newArtists;
					}
				}
			}
			catch
			{
				newArtists = art.artists;
			}
			artistBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem13.Visible = true;
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewArtist.SelectedRows[0].DataBoundItem as Artist;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.artists.Remove(deleteItem);
				artistBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			artistBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewArtist.SelectedRows[0].DataBoundItem as Artist;
			AddArtistForm arf = new AddArtistForm(editTool);
			if (arf.ShowDialog() == DialogResult.OK)
			{
				artistBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			art.Load();
			artistBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			artistBindingSource.DataSource = art.artists;
			art.Load();
			artistBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			artistBindingSource.DataSource = art.artists;
			art.Load();
			artistBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			artistBindingSource.DataSource = art.artists;
			art.Load();
			artistBindingSource.ResetBindings(false);
		}
	}
}
