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
	public partial class AddMuseumForm : Form
	{
		public Museum museum { get; set; }
		Art art;
		public AddMuseumForm()
		{
			art = new Art();
			InitializeComponent();
		}
		//edit
		public AddMuseumForm(Museum Museum) : this()
		{
			museum = Museum;
			textBox1.Text = Museum.museumName;
			textBox2.Text = Museum.countryLocation;
			textBox3.Text = Museum.museumAddress;
			textBox5.Text = Museum.pictureName;
			textBox4.Text = Museum.pictureYear.ToString();
			comboBox2.Text = Museum.pictureType;
		}
		
		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AddMuseumForm_Load(object sender, EventArgs e)
		{
			
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (museum == null)
			{
				museum = new Museum();
			}
			museum.museumName = textBox1.Text;
			museum.countryLocation = textBox2.Text;
			museum.museumAddress = textBox3.Text;
			museum.pictureName = textBox5.Text;
			museum.pictureYear = int.Parse(textBox4.Text);
			museum.pictureType = comboBox2.Text;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45))
			{
				e.Handled = true;
			}
			textBox3.MaxLength = 30;
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
			textBox3.MaxLength = 30;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45)
			    && (e.KeyChar != 44))
			{
				e.Handled = true;
			}
			textBox3.MaxLength = 30;
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

		private void AddMuseumForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
				return;
		}
	}
}
