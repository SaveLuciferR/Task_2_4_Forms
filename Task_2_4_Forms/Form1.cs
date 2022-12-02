using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2_4_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";

			int k = 5;

			for (int i = 6; i <= 10; i++)
			{
				for (int j = 0; j < k; j++)
				{
					textBox1.Text += String.Format(i + "\t");
				}

				textBox1.Text += String.Format("\r\n");
				k--;
			}
		}
	}
}
