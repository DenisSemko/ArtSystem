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
	public partial class AddCommissionShopForm : Form
	{
		public CommissionShop comshop { get; set; }
		public AddCommissionShopForm()
		{
			InitializeComponent();
		}
		//edit
		public AddCommissionShopForm(CommissionShop ComissionShop) : this()
		{
			comshop = ComissionShop;
			textBox1.Text = ComissionShop.shopName;
			textBox2.Text = ComissionShop.shopAddress;
			textBox5.Text = ComissionShop.pictureName;
			textBox4.Text = ComissionShop.pictureYear.ToString();
			textBox3.Text = ComissionShop.picturePrice.ToString();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddCommissionShopForm_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (comshop == null)
			{
				comshop = new CommissionShop();
			}

			comshop.shopName = textBox1.Text;
			comshop.shopAddress = textBox2.Text;
			comshop.pictureName = textBox5.Text;
			comshop.pictureYear = int.Parse(textBox4.Text);
			comshop.picturePrice = int.Parse(textBox3.Text);
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == MessageBox.Show("Ви справді хочете вийти?", "Вийти", MessageBoxButtons.OKCancel))
			{
				Hide();
			}
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text.Replace("  ", " ");
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox1.MaxLength = 30;
		}

		private void textBox2_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox2.Text.Replace("  ", " ");
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45) 
			    && (e.KeyChar != 44))
			{
				e.Handled = true;
			}
			textBox2.MaxLength = 30;
		}

		private void textBox5_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			textBox5.Text = textBox5.Text.Replace("  ", " ");
		}

		private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
			{
				e.Handled = true;
			}
			textBox5.MaxLength = 30;
		}

		private void textBox4_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			textBox4.Text = textBox4.Text.Replace("  ", " ");
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox4.MaxLength = 4;
		}

		private void textBox3_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			textBox3.Text = textBox3.Text.Replace("  ", " ");
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox3.MaxLength = 30;
		}

		private void AddCommissionShopForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
				return;
		}
	}
}
