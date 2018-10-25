using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio56
{
	public partial class Form1 : Form
	{
		private string archivoPath;
		public Form1()
		{
			InitializeComponent();
			toolStripStatusLabel1.Text = richTextBox1.Text.Length + " Caracteres";
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = richTextBox1.Text.Length + " Caracteres";
		}

		private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Archivos txt(*.txt)|*.txt";
			if(save.ShowDialog() == DialogResult.OK)
			{
				archivoPath = save.FileName;
			}
			guardarToolStripMenuItem_Click(sender, e);
			
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Archivos txt(*.txt)|*.txt";
			if(open.ShowDialog() == DialogResult.OK)
			{
				archivoPath = open.FileName;
				StreamReader sr = new StreamReader(archivoPath);
				richTextBox1.Text = sr.ReadToEnd();
				sr.Close();
			}
		}

		private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StreamWriter sw = new StreamWriter(archivoPath);
			sw.WriteLine(richTextBox1.Text);
			sw.Close();
		}
	}
}
