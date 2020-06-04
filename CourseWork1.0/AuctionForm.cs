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
	public partial class AuctionForm : Form
	{
		internal Art art;
		public string chooseAuctionName;
		public AddAuctionForm adu = new AddAuctionForm();
		public AuctionForm()
		{
			art = new Art();
			InitializeComponent();
			auctionBindingSource.DataSource = art.auctions;
			art.Load();
			auctionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			AddAuctionForm aduf = new AddAuctionForm();
			if (aduf.ShowDialog() == DialogResult.OK)
			{
				art.AddAuction(aduf.auction);
				auctionBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewAuction.Rows.Count - 1;
				dataGridViewAuction.Rows[lastIdx].Selected = true;
				dataGridViewAuction.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
		private void toolStripMenuItem12_Click(object sender, EventArgs e)
		{
			var editTool = dataGridViewAuction.SelectedRows[0].DataBoundItem as Auction;
			AddAuctionForm aduf = new AddAuctionForm(editTool);
			if (aduf.ShowDialog() == DialogResult.OK)
			{
				auctionBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
		}

		private void AuctionForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			dataGridViewAuction.Rows.Clear();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			var deleteItem = dataGridViewAuction.SelectedRows[0].DataBoundItem as Auction;
			if (DialogResult.OK == MessageBox.Show("Видалити запис?", "Видалити", MessageBoxButtons.OKCancel))
			{
				art.auctions.Remove(deleteItem);
				auctionBindingSource.ResetBindings(false);
				art.isChangeData = true;
			}
			auctionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			var sortedListAuctionName = from au in art.auctions
				orderby au.auctionName
				select au;
			auctionBindingSource.DataSource = sortedListAuctionName;
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			var sortedListDateHoldingEvent = from au in art.auctions
				orderby au.dateHoldingEvent
				select au;
			auctionBindingSource.DataSource = sortedListDateHoldingEvent;
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem13_Click(object sender, EventArgs e)
		{
			var sortedListPictureName = from au in art.auctions
				orderby au.pictureName
				select au;
			auctionBindingSource.DataSource = sortedListPictureName;
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			var sortedListPictureYear = from au in art.auctions
				orderby au.pictureYear
				select au;
			auctionBindingSource.DataSource = sortedListPictureYear;
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem15_Click(object sender, EventArgs e)
		{
			var sortedListPictureFirstPrice = from au in art.auctions
				orderby au.pictureFirstPrice
				select au;
			auctionBindingSource.DataSource = sortedListPictureFirstPrice;
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			Auction au = new Auction();
			List<Auction> newAuctions = new List<Auction>();
			try
			{
				au.auctionName = toolStripTextBox1.Text;
				foreach (Auction a in art.auctions)
				{
					if (au.auctionName == a.auctionName)
					{
						int k = art.auctions.IndexOf(a);
						newAuctions.Add(art.auctions[k]);
						auctionBindingSource.DataSource = newAuctions;
					}
				}
			}
			catch
			{
				newAuctions = art.auctions;
			}
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem18.Visible = true;
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			Auction au = new Auction();
			List<Auction> newAuctions = new List<Auction>();
			try
			{
				au.pictureName = toolStripTextBox1.Text;
				foreach (Auction a in art.auctions)
				{
					if (au.pictureName == a.pictureName)
					{
						int k = art.auctions.IndexOf(a);
						newAuctions.Add(art.auctions[k]);
						auctionBindingSource.DataSource = newAuctions;
					}
				}
			}
			catch
			{
				newAuctions = art.auctions;
			}
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem19.Visible = true;
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			Auction au = new Auction();
			List<Auction> newAuctions = new List<Auction>();
			try
			{
				au.pictureYear = int.Parse(toolStripTextBox1.Text);
				foreach (Auction a in art.auctions)
				{
					if (au.pictureYear == a.pictureYear)
					{
						int k = art.auctions.IndexOf(a);
						newAuctions.Add(art.auctions[k]);
						auctionBindingSource.DataSource = newAuctions;
					}
				}
			}
			catch
			{
				newAuctions = art.auctions;
			}
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem20.Visible = true;
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			Auction au = new Auction();
			List<Auction> newAuctions = new List<Auction>();
			try
			{
				au.pictureFirstPrice = int.Parse(toolStripTextBox1.Text);
				foreach (Auction a in art.auctions)
				{
					if (au.pictureFirstPrice == a.pictureFirstPrice)
					{
						int k = art.auctions.IndexOf(a);
						newAuctions.Add(art.auctions[k]);
						auctionBindingSource.DataSource = newAuctions;
					}
				}
			}
			catch
			{
				newAuctions = art.auctions;
			}
			auctionBindingSource.ResetBindings(false);
			art.isChangeData = true;
			art.Load();
			toolStripMenuItem21.Visible = true;
		}

		private void toolStripMenuItem16_Click(object sender, EventArgs e)
		{
			art.Load();
			auctionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem17_Click(object sender, EventArgs e)
		{
			art.Save();
		}

		private void toolStripMenuItem18_Click(object sender, EventArgs e)
		{
			auctionBindingSource.DataSource = art.auctions;
			art.Load();
			auctionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem19_Click(object sender, EventArgs e)
		{
			auctionBindingSource.DataSource = art.auctions;
			art.Load();
			auctionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem20_Click(object sender, EventArgs e)
		{
			auctionBindingSource.DataSource = art.auctions;
			art.Load();
			auctionBindingSource.ResetBindings(false);
		}

		private void toolStripMenuItem21_Click(object sender, EventArgs e)
		{
			auctionBindingSource.DataSource = art.auctions;
			art.Load();
			auctionBindingSource.ResetBindings(false);
		}

		private void dataGridViewAuction_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			chooseAuctionName = dataGridViewAuction.SelectedCells[0].Value.ToString();
			adu.textBox1.Text = chooseAuctionName;
			textBox1.Text = chooseAuctionName;
			textBox1.Visible = true;
			button1.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (adu.ShowDialog() == DialogResult.OK)
			{
				art.AddAuction(adu.auction);
				auctionBindingSource.ResetBindings(false);
				art.isChangeData = true;
				var lastIdx = dataGridViewAuction.Rows.Count - 1;
				dataGridViewAuction.Rows[lastIdx].Selected = true;
				dataGridViewAuction.FirstDisplayedScrollingRowIndex = lastIdx;
			}
		}
	}
}
