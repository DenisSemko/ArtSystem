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
	public partial class AddArtistForm : Form
	{
		public Artist artist { set; get; }
		Art art;
		public AddArtistForm()
		{
			art = new Art();
			InitializeComponent();
		}
		//edit
		public AddArtistForm(Artist Artist) : this()
		{
			artist = Artist;
			textBox1.Text = Artist.artistName;
			textBox2.Text = Artist.Country;
			comboBox1.Text = Artist.styleOfDrawing;
			dateTimePicker1.Value = Artist.dateOfBirth;

		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (artist == null)
			{
				artist = new Artist();
			}
			artist.artistName = textBox1.Text;
			artist.Country = textBox2.Text;
			artist.styleOfDrawing = comboBox1.Text;
			artist.dateOfBirth = dateTimePicker1.Value;
		}


		private void button3_Click(object sender, EventArgs e)
		{
			Close();
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

		private void textBox3_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			comboBox1.Text = comboBox1.Text.Replace("  ", " ");
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			comboBox1.MaxLength = 30;
		}

		private void AddArtistForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
				return;
		}
	}
}
