using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_擲骰子遊戲
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			var random = new Random();
			int[] results = {random.Next(1,7), random.Next(1, 7), random.Next(1, 7), random.Next(1, 7) };
			
			txtAns1.Text = results[0].ToString();
			txtAns2.Text = results[1].ToString();
			txtAns3.Text = results[2].ToString();
			txtAns4.Text = results[3].ToString();

			Array.Sort(results);
			textBox2.Text = string.Empty;
			if (results[0] == results[1])
			{
				int points = results[2] + results[3];
				textBox2.Text = points.ToString();
				return;
			}
			else if (results[1] == results[2])
			{
				int points = results[3] + results[0];
				textBox2.Text = points.ToString();
				return;
			}
			else if (results[2] == results[3])
			{
				int points = results[0] + results[1];
				textBox2.Text = points.ToString();
				return ;
			}
			else if(results[3] == results[0])
			{
				int points = results[1] + results[2];
				textBox2.Text = points.ToString();
				return;
			}	
			else return;
		}
	}
}
