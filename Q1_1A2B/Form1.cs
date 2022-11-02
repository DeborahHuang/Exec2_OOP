using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_1A2B
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			int answer = 0;
			var random = new Random();
			answer = random.Next(1000, 10000);
			lblRightAnswer.Text = answer.ToString();
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			string guessNumber =string.Empty;
			string answer=lblInsertAnswer.Text;

			try
			{
				guessNumber = GetGuessNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			int[] answers =  { answer[0], answer[1], answer[2] , answer[3] };
			int[] guessNumbers =  { guessNumber[0], guessNumber[1], guessNumber[2], guessNumber[3] };

			int A=0; int B=0;
			for (int i = 0; i<4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (i == j)
					{
						A++;
					}
					else continue;
				}
			}

		
			if (A == 4)
			{
				MessageBox.Show("您贏了!!");
			}

			string result = $"{A}A{B}B";
			lblGuseeNumber.Text = $"答案\r\n{guessNumber}";
			lblResult.Text = $"結果\r\n{result}";

			
			
		}

		private string GetGuessNumber()
		{
			string input= txtAnswer.Text;
			bool isInt = int.TryParse(input, out int guessNumber);
			if (isInt == false) throw new Exception("請輸入四位數數字");
			if (guessNumber > 9999) throw new Exception("答案不能超過四位數字");
			else return guessNumber.ToString();
		}
	}
}
