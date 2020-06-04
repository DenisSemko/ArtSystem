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
	public partial class CollectionersForm : Form
	{
		internal Art art;
		public string chooseCollectioner;
		public string chooseCollectionerCountry;
		public AddCollectionerForm adc = new AddCollectionerForm();
		public CollectionersForm()
		{
			art = new Art();
			InitializeComponent();
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddCollectionerForm adcf = new AddCollectionerForm();
			if (adcf.ShowDialog() == DialogResult.OK)
			{
				art.AddCollectioner(adcf.collectioner);
				collectionerBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewCollectioner.Rows.Count - 1;
				dataGridViewCollectioner.Rows[lastIdx].Selected = true;
				dataGridViewCollectioner.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
		private void toolStripMenuItem24_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewCollectioner.SelectedRows[0].DataBoundItem as Collectioner;
			AddCollectionerForm adcf = new AddCollectionerForm(editTool);
			if (adcf.ShowDialog() == DialogResult.OK)
			{
				collectionerBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewCollectioner.SelectedRows[0].DataBoundItem as Collectioner;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.collectioners.Remove(deleteItem);
				collectionerBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			collectionerBindingSource.ResetBindings(false);
		}
		private void CollectionersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewCollectioner.Rows.Clear();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var sortedListCollectionerName = from c in art.collectioners
				orderby c.collectionerName
				select c;
			collectionerBindingSource.DataSource = sortedListCollectionerName;
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var sortedListCollectionerCountry = from c in art.collectioners
				orderby c.countryBirth
				select c;
			collectionerBindingSource.DataSource = sortedListCollectionerCountry;
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			var sortedListCollectionerStyle = from c in art.collectioners
				orderby c.favStyleDrawing
				select c;
			collectionerBindingSource.DataSource = sortedListCollectionerStyle;
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();

		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			var sortedListPictureName = from c in art.collectioners
				orderby c.pictureName
				select c;
			collectionerBindingSource.DataSource = sortedListPictureName;
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			var sortedListPictureYear = from c in art.collectioners
				orderby c.pictureYear
				select c;
			collectionerBindingSource.DataSource = sortedListPictureYear;
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			var sortedListPictureType = from c in art.collectioners
				orderby c.pictureType
				select c;
			collectionerBindingSource.DataSource = sortedListPictureType;
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();

		}

		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			Collectioner coll = new Collectioner();
			List<Collectioner> newCollectioners = new List<Collectioner>();
			try
			{
				coll.collectionerName = toolStripTextBox1.Text;
				foreach (Collectioner c in art.collectioners)
				{
					if (coll.collectionerName == c.collectionerName)
					{
						int k = art.collectioners.IndexOf(c);
						newCollectioners.Add(art.collectioners[k]);
						collectionerBindingSource.DataSource = newCollectioners;
					}
				}
			}
			catch
			{
				newCollectioners = art.collectioners;
			}
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem18.Visible = true;
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			Collectioner coll = new Collectioner();
			List<Collectioner> newCollectioners = new List<Collectioner>();
			try
			{
				coll.countryBirth = toolStripTextBox1.Text;
				foreach (Collectioner c in art.collectioners)
				{
					if (coll.countryBirth == c.countryBirth)
					{
						int k = art.collectioners.IndexOf(c);
						newCollectioners.Add(art.collectioners[k]);
						collectionerBindingSource.DataSource = newCollectioners;
					}
				}
			}
			catch
			{
				newCollectioners = art.collectioners;
			}
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem19.Visible = true;
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			Collectioner coll = new Collectioner();
			List<Collectioner> newCollectioners = new List<Collectioner>();
			try
			{
				coll.favStyleDrawing = toolStripTextBox1.Text;
				foreach (Collectioner c in art.collectioners)
				{
					if (coll.favStyleDrawing == c.favStyleDrawing)
					{
						int k = art.collectioners.IndexOf(c);
						newCollectioners.Add(art.collectioners[k]);
						collectionerBindingSource.DataSource = newCollectioners;
					}
				}
			}
			catch
			{
				newCollectioners = art.collectioners;
			}
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem20.Visible = true;
		}

		private void toolStripMenuItem15_Click(object sender, EventArgs e)
		{
			Collectioner coll = new Collectioner();
			List<Collectioner> newCollectioners = new List<Collectioner>();
			try
			{
				coll.pictureName = toolStripTextBox1.Text;
				foreach (Collectioner c in art.collectioners)
				{
					if (coll.pictureName == c.pictureName)
					{
						int k = art.collectioners.IndexOf(c);
						newCollectioners.Add(art.collectioners[k]);
						collectionerBindingSource.DataSource = newCollectioners;
					}
				}
			}
			catch
			{
				newCollectioners = art.collectioners;
			}
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem21.Visible = true;
		}

		private void toolStripMenuItem16_Click(object sender, EventArgs e)
		{
			Collectioner coll = new Collectioner();
			List<Collectioner> newCollectioners = new List<Collectioner>();
			try
			{
				coll.pictureYear = int.Parse(toolStripTextBox1.Text);
				foreach (Collectioner c in art.collectioners)
				{
					if (coll.pictureYear == c.pictureYear)
					{
						int k = art.collectioners.IndexOf(c);
						newCollectioners.Add(art.collectioners[k]);
						collectionerBindingSource.DataSource = newCollectioners;
					}
				}
			}
			catch
			{
				newCollectioners = art.collectioners;
			}
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem22.Visible = true;
		}

		private void toolStripMenuItem17_Click(object sender, EventArgs e)
		{
			Collectioner coll = new Collectioner();
			List<Collectioner> newCollectioners = new List<Collectioner>();
			try
			{
				coll.pictureType = toolStripTextBox1.Text;
				foreach (Collectioner c in art.collectioners)
				{
					if (coll.pictureType == c.pictureType)
					{
						int k = art.collectioners.IndexOf(c);
						newCollectioners.Add(art.collectioners[k]);
						collectionerBindingSource.DataSource = newCollectioners;
					}
				}
			}
			catch
			{
				newCollectioners = art.collectioners;
			}
			collectionerBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem20.Visible = true;
		}

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem19_Click(object sender, EventArgs e)
		{
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem20_Click(object sender, EventArgs e)
		{
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);

		}

		private void toolStripMenuItem21_Click(object sender, EventArgs e)
		{
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem22_Click(object sender, EventArgs e)
		{
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem23_Click(object sender, EventArgs e)
		{
			collectionerBindingSource.DataSource = art.collectioners;
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem25_Click(object sender, EventArgs e)
		{
			art.Load();
			collectionerBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem26_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void dataGridViewCollectioner_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			chooseCollectioner = dataGridViewCollectioner.SelectedCells[0].Value.ToString();
			chooseCollectionerCountry = dataGridViewCollectioner.SelectedCells[1].Value.ToString();
			adc.textBox1.Text = chooseCollectioner;
			adc.textBox2.Text = chooseCollectionerCountry;
			textBox1.Text = chooseCollectioner;
			textBox1.Visible = true;
			button1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (adc.ShowDialog() == DialogResult.OK)
			{
				art.AddCollectioner(adc.collectioner);
				collectionerBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewCollectioner.Rows.Count - 1;
				dataGridViewCollectioner.Rows[lastIdx].Selected = true;
				dataGridViewCollectioner.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
	}
}
