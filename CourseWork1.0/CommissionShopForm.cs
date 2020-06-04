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
	public partial class CommissionShopForm : Form
	{
		internal Art art;
		public string comShopName;
		public string comShopCountry;
		public AddCommissionShopForm adc = new AddCommissionShopForm();
		public CommissionShopForm()
		{
			art = new Art();
			InitializeComponent();
			commissionShopBindingSource.DataSource = art.comShops;
			art.Load();
			commissionShopBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddCommissionShopForm adcsf = new AddCommissionShopForm();
			if (adcsf.ShowDialog() == DialogResult.OK)
			{
				art.AddComShop(adcsf.comshop);
				commissionShopBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewShop.Rows.Count - 1;
				dataGridViewShop.Rows[lastIdx].Selected = true;
				dataGridViewShop.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
		private void toolStripMenuItem16_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewShop.SelectedRows[0].DataBoundItem as CommissionShop;
			AddCommissionShopForm adcsf = new AddCommissionShopForm(editTool);
			if (adcsf.ShowDialog() == DialogResult.OK)
			{
				commissionShopBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}
		private void CommissionShopForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewShop.Rows.Clear();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewShop.SelectedRows[0].DataBoundItem as CommissionShop;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.comShops.Remove(deleteItem);
				commissionShopBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			commissionShopBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var sortedListShopName = from cs in art.comShops
				orderby cs.shopName
				select cs;
			commissionShopBindingSource.DataSource = sortedListShopName;
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var sortedListShopAddress = from cs in art.comShops
				orderby cs.shopAddress
				select cs;
			commissionShopBindingSource.DataSource = sortedListShopAddress;
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			var sortedListPictureName = from cs in art.comShops
				orderby cs.pictureName
				select cs;
			commissionShopBindingSource.DataSource = sortedListPictureName;
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			var sortedListPictureYear = from cs in art.comShops
				orderby cs.pictureYear
				select cs;
			commissionShopBindingSource.DataSource = sortedListPictureYear;
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			var sortedListPicturePrice = from cs in art.comShops
				orderby cs.picturePrice
				select cs;
			commissionShopBindingSource.DataSource = sortedListPicturePrice;
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			CommissionShop cs = new CommissionShop();
			List<CommissionShop> newComShops = new List<CommissionShop>();
			try
			{
				cs.shopName = toolStripTextBox1.Text;
				foreach (CommissionShop c in art.comShops)
				{
					if (cs.shopName == c.shopName)
					{
						int k = art.comShops.IndexOf(c);
						newComShops.Add(art.comShops[k]);
						commissionShopBindingSource.DataSource = newComShops;
					}
				}
			}
			catch
			{
				newComShops = art.comShops;
			}
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem19.Visible = true;
		}

		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			CommissionShop cs = new CommissionShop();
			List<CommissionShop> newComShops = new List<CommissionShop>();
			try
			{
				cs.shopAddress = toolStripTextBox1.Text;
				foreach (CommissionShop c in art.comShops)
				{
					if (cs.shopAddress == c.shopAddress)
					{
						int k = art.comShops.IndexOf(c);
						newComShops.Add(art.comShops[k]);
						commissionShopBindingSource.DataSource = newComShops;
					}
				}
			}
			catch
			{
				newComShops = art.comShops;
			}
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem20.Visible = true;
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			CommissionShop cs = new CommissionShop();
			List<CommissionShop> newComShops = new List<CommissionShop>();
			try
			{
				cs.pictureName= toolStripTextBox1.Text;
				foreach (CommissionShop c in art.comShops)
				{
					if (cs.pictureName == c.pictureName)
					{
						int k = art.comShops.IndexOf(c);
						newComShops.Add(art.comShops[k]);
						commissionShopBindingSource.DataSource = newComShops;
					}
				}
			}
			catch
			{
				newComShops = art.comShops;
			}
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem21.Visible = true;
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			CommissionShop cs = new CommissionShop();
			List<CommissionShop> newComShops = new List<CommissionShop>();
			try
			{
				cs.pictureYear = int.Parse(toolStripTextBox1.Text);
				foreach (CommissionShop c in art.comShops)
				{
					if (cs.pictureYear == c.pictureYear)
					{
						int k = art.comShops.IndexOf(c);
						newComShops.Add(art.comShops[k]);
						commissionShopBindingSource.DataSource = newComShops;
					}
				}
			}
			catch
			{
				newComShops = art.comShops;
			}
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem22.Visible = true;
		}

		private void toolStripMenuItem15_Click(object sender, EventArgs e)
		{
			CommissionShop cs = new CommissionShop();
			List<CommissionShop> newComShops = new List<CommissionShop>();
			try
			{
				cs.picturePrice = int.Parse(toolStripTextBox1.Text);
				foreach (CommissionShop c in art.comShops)
				{
					if (cs.picturePrice == c.picturePrice)
					{
						int k = art.comShops.IndexOf(c);
						newComShops.Add(art.comShops[k]);
						commissionShopBindingSource.DataSource = newComShops;
					}
				}
			}
			catch
			{
				newComShops = art.comShops;
			}
			commissionShopBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem23.Visible = true;
		}

		private void toolStripMenuItem17_Click(object sender, EventArgs e)
		{
			art.Load();
			commissionShopBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void toolStripMenuItem19_Click(object sender, EventArgs e)
		{
			commissionShopBindingSource.DataSource = art.comShops;
			art.Load();
			commissionShopBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem20_Click(object sender, EventArgs e)
		{
			commissionShopBindingSource.DataSource = art.comShops;
			art.Load();
			commissionShopBindingSource.ResetBindings(false);

		}

		private void toolStripMenuItem21_Click(object sender, EventArgs e)
		{
			commissionShopBindingSource.DataSource = art.comShops;
			art.Load();
			commissionShopBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem22_Click(object sender, EventArgs e)
		{
			commissionShopBindingSource.DataSource = art.comShops;
			art.Load();
			commissionShopBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem23_Click(object sender, EventArgs e)
		{
			commissionShopBindingSource.DataSource = art.comShops;
			art.Load();
			commissionShopBindingSource.ResetBindings(false);
		}

		private void dataGridViewShop_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			comShopName = dataGridViewShop.SelectedCells[0].Value.ToString();
			comShopCountry = dataGridViewShop.SelectedCells[1].Value.ToString();
			adc.textBox1.Text = comShopName;
			adc.textBox2.Text = comShopCountry;
			textBox1.Text = comShopName;
			textBox1.Visible = true;
			button1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (adc.ShowDialog() == DialogResult.OK)
			{
				art.AddComShop(adc.comshop);
				commissionShopBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewShop.Rows.Count - 1;
				dataGridViewShop.Rows[lastIdx].Selected = true;
				dataGridViewShop.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}

	}
}
