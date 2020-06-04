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
using System.Windows.Forms.VisualStyles;

namespace CourseWork1._0
{
	public partial class AddPictureForm : Form
	{
		public Picture picture { get; set; }
		Art art;
		public AddPictureForm()
		{
			art = new Art();
			InitializeComponent();

		}
		//edit
		public AddPictureForm(Picture Picture) : this()
		{
			picture = Picture;
			textBox7.Text = Picture.authorName;
			textBox1.Text = Picture.pictureName;
			comboBox1.Text = Picture.pictureGenre;
			textBox6.Text = Picture.pictureYear.ToString();
			textBox3.Text = Picture.drawingMaterial;
			textBox4.Text = Picture.pictureSize;
			textBox5.Text = Picture.displayMethod;
		}
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (picture == null)
			{
				picture = new Picture();
			}
			picture.authorName = textBox7.Text;
			picture.pictureName = textBox1.Text;
			picture.pictureGenre = comboBox1.Text;
			picture.pictureYear = int.Parse(textBox6.Text);
			picture.drawingMaterial = textBox3.Text;
			picture.pictureSize = textBox4.Text;
			picture.displayMethod = textBox5.Text;
		}
		private void AddPictureForm_Load(object sender, EventArgs e)
		{

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
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 39))
			{
				e.Handled = true;
			}
			comboBox1.MaxLength = 30;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 44))
			{
				e.Handled = true;
			}
			textBox1.MaxLength = 30;
		}

		private void textBox6_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			textBox6.Text = textBox6.Text.Replace("  ", " ");
		}

		private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox4.MaxLength = 4;
		}
		private void textBox7_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			textBox7.Text = textBox7.Text.Replace("  ", " ");
		}

		private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 39))
			{
				e.Handled = true;
			}
			textBox7.MaxLength = 30;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox3.MaxLength = 30;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox4.MaxLength = 30;
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
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
			{
				e.Handled = true;
			}
			textBox4.MaxLength = 30;
		}

		private void AddPictureForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult != DialogResult.OK)
				return;
		}

	}
}
