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
	public partial class AddCollectionerForm : Form
	{
		public Collectioner collectioner { get; set; }
		Art art;
		public AddCollectionerForm()
		{
			art = new Art();
			InitializeComponent();
		}
		//edit
		public AddCollectionerForm(Collectioner Collectioner) : this()
		{
			collectioner = Collectioner;
			textBox1.Text = Collectioner.collectionerName;
			textBox2.Text = Collectioner.countryBirth;
			comboBox1.Text = Collectioner.favStyleDrawing;
			textBox5.Text = Collectioner.pictureName;
			textBox4.Text = Collectioner.pictureYear.ToString();
			comboBox2.Text = Collectioner.pictureType;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddCollectionerForm_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (collectioner == null)
			{
				collectioner = new Collectioner();
			}

			collectioner.collectionerName = textBox1.Text;
			collectioner.countryBirth = textBox2.Text;
			collectioner.favStyleDrawing = comboBox1.Text;
			collectioner.pictureName = textBox5.Text;
			collectioner.pictureYear = int.Parse(textBox4.Text);
			collectioner.pictureType = comboBox2.Text;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45))
			{
				e.Handled = true;
			}
			textBox2.MaxLength = 30;
		}

		private void comboBox1_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			comboBox1.Text = comboBox1.Text.Replace("  ", " ");
		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45))
			{
				e.Handled = true;
			}
			comboBox1.MaxLength = 30;
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

		private void comboBox2_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void comboBox2_TextChanged(object sender, EventArgs e)
		{
			comboBox2.Text = comboBox2.Text.Replace("  ", " ");
		}

		private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			comboBox2.MaxLength = 30;
		}

		private void AddCollectionerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
				return;
		}
	}
}
