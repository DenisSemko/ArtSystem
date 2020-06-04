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
	public partial class MuseumsForm : Form
	{
		internal Art art;
		public string chooseMuseum;
		public string chooseMuseumCountry;
		public string chooseMuseumAddress;
		public AddMuseumForm adf = new AddMuseumForm();
		public MuseumsForm()
		{
			art = new Art();
			InitializeComponent();
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddMuseumForm admf = new AddMuseumForm();
			if (admf.ShowDialog() == DialogResult.OK)
			{
				art.AddMuseum(admf.museum);
				museumBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewMuseum.Rows.Count - 1;
				dataGridViewMuseum.Rows[lastIdx].Selected = true;
				dataGridViewMuseum.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}

		private void MuseumsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewMuseum.Rows.Clear();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewMuseum.SelectedRows[0].DataBoundItem as Museum;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.museums.Remove(deleteItem);
				museumBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var sortedListMuseumName = from m in art.museums
				orderby m.museumName
				select m;
			museumBindingSource.DataSource = sortedListMuseumName;
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var sortedListCountryPlace = from m in art.museums
				orderby m.countryLocation
				select m;
			museumBindingSource.DataSource = sortedListCountryPlace;
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			var sortedListMuseumAddress = from m in art.museums
				orderby m.museumAddress
				select m;
			museumBindingSource.DataSource = sortedListMuseumAddress;
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			var sortedListPictureName = from m in art.museums
				orderby m.pictureName
				select m;
			museumBindingSource.DataSource = sortedListPictureName;
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();

		}

		private void toolStripMenuItem15_Click(object sender, EventArgs e)
		{
			var sortedListPictureYear = from m in art.museums
				orderby m.pictureYear
				select m;
			museumBindingSource.DataSource = sortedListPictureYear;
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem16_Click(object sender, EventArgs e)
		{
			var sortedListPictureType = from m in art.museums
				orderby m.pictureType
				select m;
			museumBindingSource.DataSource = sortedListPictureType;
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			Museum msms = new Museum();
			List<Museum> newMuseums = new List<Museum>();
			try
			{
				msms.museumName = toolStripTextBox1.Text;
				foreach (Museum m in art.museums)
				{
					if (msms.museumName == m.museumName)
					{
						int k = art.museums.IndexOf(m);
						newMuseums.Add(art.museums[k]);
						museumBindingSource.DataSource = newMuseums;
					}
				}
			}
			catch
			{
				newMuseums = art.museums;
			}
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem21.Visible = true;
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			Museum msms = new Museum();
			List<Museum> newMuseums = new List<Museum>();
			try
			{
				msms.countryLocation = toolStripTextBox1.Text;
				foreach (Museum m in art.museums)
				{
					if (msms.countryLocation == m.countryLocation)
					{
						int k = art.museums.IndexOf(m);
						newMuseums.Add(art.museums[k]);
						museumBindingSource.DataSource = newMuseums;
					}
				}
			}
			catch
			{
				newMuseums = art.museums;
			}
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem22.Visible = true;
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			Museum msms = new Museum();
			List<Museum> newMuseums = new List<Museum>();
			try
			{
				msms.museumAddress = toolStripTextBox1.Text;
				foreach (Museum m in art.museums)
				{
					if (msms.museumAddress == m.museumAddress)
					{
						int k = art.museums.IndexOf(m);
						newMuseums.Add(art.museums[k]);
						museumBindingSource.DataSource = newMuseums;
					}
				}
			}
			catch
			{
				newMuseums = art.museums;
			}
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem23.Visible = true;
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			Museum msms = new Museum();
			List<Museum> newMuseums = new List<Museum>();
			try
			{
				msms.pictureName = toolStripTextBox1.Text;
				foreach (Museum m in art.museums)
				{
					if (msms.pictureName == m.pictureName)
					{
						int k = art.museums.IndexOf(m);
						newMuseums.Add(art.museums[k]);
						museumBindingSource.DataSource = newMuseums;
					}
				}
			}
			catch
			{
				newMuseums = art.museums;
			}
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem24.Visible = true;
		}

		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			Museum msms = new Museum();
			List<Museum> newMuseums = new List<Museum>();
			try
			{
				msms.pictureYear = int.Parse(toolStripTextBox1.Text);
				foreach (Museum m in art.museums)
				{
					if (msms.pictureYear == m.pictureYear)
					{
						int k = art.museums.IndexOf(m);
						newMuseums.Add(art.museums[k]);
						museumBindingSource.DataSource = newMuseums;
					}
				}
			}
			catch
			{
				newMuseums = art.museums;
			}
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem25.Visible = true;
		}

		private void toolStripMenuItem17_Click(object sender, EventArgs e)
		{
			Museum msms = new Museum();
			List<Museum> newMuseums = new List<Museum>();
			try
			{
				msms.pictureType = toolStripTextBox1.Text;
				foreach (Museum m in art.museums)
				{
					if (msms.pictureType == m.pictureType)
					{
						int k = art.museums.IndexOf(m);
						newMuseums.Add(art.museums[k]);
						museumBindingSource.DataSource = newMuseums;
					}
				}
			}
			catch
			{
				newMuseums = art.museums;
			}
			museumBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem26.Visible = true;
		}

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewMuseum.SelectedRows[0].DataBoundItem as Museum;
			AddMuseumForm admf = new AddMuseumForm(editTool);
			if (admf.ShowDialog() == DialogResult.OK)
			{
				museumBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}

		private void toolStripMenuItem21_Click(object sender, EventArgs e)
		{
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem22_Click(object sender, EventArgs e)
		{
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem23_Click(object sender, EventArgs e)
		{
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem24_Click(object sender, EventArgs e)
		{
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem25_Click(object sender, EventArgs e)
		{
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem26_Click(object sender, EventArgs e)
		{
			museumBindingSource.DataSource = art.museums;
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem19_Click(object sender, EventArgs e)
		{
			art.Load();
			museumBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem20_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void dataGridViewMuseum_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			chooseMuseum = dataGridViewMuseum.SelectedCells[0].Value.ToString();
			chooseMuseumCountry = dataGridViewMuseum.SelectedCells[1].Value.ToString();
			chooseMuseumAddress = dataGridViewMuseum.SelectedCells[2].Value.ToString();
			adf.textBox1.Text = chooseMuseum;
			adf.textBox2.Text = chooseMuseumCountry;
			adf.textBox3.Text = chooseMuseumAddress;
			textBox1.Text = chooseMuseum;
			textBox1.Visible = true;
			button1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (adf.ShowDialog() == DialogResult.OK)
			{
				art.AddMuseum(adf.museum);
				museumBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewMuseum.Rows.Count - 1;
				dataGridViewMuseum.Rows[lastIdx].Selected = true;
				dataGridViewMuseum.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
	}
}
