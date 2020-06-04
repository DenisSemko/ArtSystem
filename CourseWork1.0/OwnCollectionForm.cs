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
	public partial class OwnCollectionForm : Form
	{
		internal Art art;
		public string chooseCollectionName;
		public AddOwnCollectionForm adoc = new AddOwnCollectionForm();
		public OwnCollectionForm()
		{
			art = new Art();
			InitializeComponent();
			ownCollectionBindingSource.DataSource = art.ownCollections;
			art.Load();
			ownCollectionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddOwnCollectionForm adocf = new AddOwnCollectionForm();
			if (adocf.ShowDialog() == DialogResult.OK)
			{
				art.AddOwnCollection(adocf.ownCollection);
				ownCollectionBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewOwnColl.Rows.Count - 1;
				dataGridViewOwnColl.Rows[lastIdx].Selected = true;
				dataGridViewOwnColl.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
		private void toolStripMenuItem16_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewOwnColl.SelectedRows[0].DataBoundItem as OwnCollection;
			AddOwnCollectionForm adocf = new AddOwnCollectionForm(editTool);
			if (adocf.ShowDialog() == DialogResult.OK)
			{
				ownCollectionBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}

		private void OwnCollectionForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewOwnColl.Rows.Clear();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewOwnColl.SelectedRows[0].DataBoundItem as OwnCollection;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.ownCollections.Remove(deleteItem);
				ownCollectionBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			ownCollectionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var sortedListOwnCollectionName = from owc in art.ownCollections
				orderby owc.myCollectionName
				select owc;
			ownCollectionBindingSource.DataSource = sortedListOwnCollectionName;
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var sortedListPictureName = from owc in art.ownCollections
				orderby owc.pictureName
				select owc;
			ownCollectionBindingSource.DataSource = sortedListPictureName;
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			var sortedListPictureYear = from owc in art.ownCollections
				orderby owc.pictureYear
				select owc;
			ownCollectionBindingSource.DataSource = sortedListPictureYear;
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();

		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			var sortedListPictureType = from owc in art.ownCollections
				orderby owc.pictureType
				select owc;
			ownCollectionBindingSource.DataSource = sortedListPictureType;
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			var sortedListPlaceBuy = from owc in art.ownCollections
				orderby owc.placeBuy
				select owc;
			ownCollectionBindingSource.DataSource = sortedListPlaceBuy;
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			OwnCollection oc = new OwnCollection();
			List<OwnCollection> newOwnCollections = new List<OwnCollection>();
			try
			{
				oc.myCollectionName = toolStripTextBox1.Text;
				foreach (OwnCollection owc in art.ownCollections)
				{
					if (oc.myCollectionName == owc.myCollectionName)
					{
						int k = art.ownCollections.IndexOf(owc);
						newOwnCollections.Add(art.ownCollections[k]);
						ownCollectionBindingSource.DataSource = newOwnCollections;
					}
				}
			}
			catch
			{
				newOwnCollections = art.ownCollections;
			}
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem19.Visible = true;
		}

		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			OwnCollection oc = new OwnCollection();
			List<OwnCollection> newOwnCollections = new List<OwnCollection>();
			try
			{
				oc.pictureName = toolStripTextBox1.Text;
				foreach (OwnCollection owc in art.ownCollections)
				{
					if (oc.pictureName == owc.pictureName)
					{
						int k = art.ownCollections.IndexOf(owc);
						newOwnCollections.Add(art.ownCollections[k]);
						ownCollectionBindingSource.DataSource = newOwnCollections;
					}
				}
			}
			catch
			{
				newOwnCollections = art.ownCollections;
			}
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem20.Visible = true;
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			OwnCollection oc = new OwnCollection();
			List<OwnCollection> newOwnCollections = new List<OwnCollection>();
			try
			{
				oc.pictureYear = int.Parse(toolStripTextBox1.Text);
				foreach (OwnCollection owc in art.ownCollections)
				{
					if (oc.pictureYear == owc.pictureYear)
					{
						int k = art.ownCollections.IndexOf(owc);
						newOwnCollections.Add(art.ownCollections[k]);
						ownCollectionBindingSource.DataSource = newOwnCollections;
					}
				}
			}
			catch
			{
				newOwnCollections = art.ownCollections;
			}
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem21.Visible = true;
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			OwnCollection oc = new OwnCollection();
			List<OwnCollection> newOwnCollections = new List<OwnCollection>();
			try
			{
				oc.pictureType = toolStripTextBox1.Text;
				foreach (OwnCollection owc in art.ownCollections)
				{
					if (oc.pictureType == owc.pictureType)
					{
						int k = art.ownCollections.IndexOf(owc);
						newOwnCollections.Add(art.ownCollections[k]);
						ownCollectionBindingSource.DataSource = newOwnCollections;
					}
				}
			}
			catch
			{
				newOwnCollections = art.ownCollections;
			}
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem22.Visible = true;
		}

		private void toolStripMenuItem15_Click(object sender, EventArgs e)
		{
			OwnCollection oc = new OwnCollection();
			List<OwnCollection> newOwnCollections = new List<OwnCollection>();
			try
			{
				oc.placeBuy = toolStripTextBox1.Text;
				foreach (OwnCollection owc in art.ownCollections)
				{
					if (oc.placeBuy == owc.placeBuy)
					{
						int k = art.ownCollections.IndexOf(owc);
						newOwnCollections.Add(art.ownCollections[k]);
						ownCollectionBindingSource.DataSource = newOwnCollections;
					}
				}
			}
			catch
			{
				newOwnCollections = art.ownCollections;
			}
			ownCollectionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem23.Visible = true;
		}

		private void toolStripMenuItem17_Click(object sender, EventArgs e)
		{
			art.Load();
			ownCollectionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void dataGridViewOwnColl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			chooseCollectionName = dataGridViewOwnColl.SelectedCells[0].Value.ToString();
			adoc.textBox1.Text = chooseCollectionName;
			textBox1.Text = chooseCollectionName;
			textBox1.Visible = true;
			button1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (adoc.ShowDialog() == DialogResult.OK)
			{
				art.AddOwnCollection(adoc.ownCollection);
				ownCollectionBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewOwnColl.Rows.Count - 1;
				dataGridViewOwnColl.Rows[lastIdx].Selected = true;
				dataGridViewOwnColl.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
	}
}
