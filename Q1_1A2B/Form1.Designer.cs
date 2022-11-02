namespace Q1_1A2B
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.btnResult = new System.Windows.Forms.Button();
			this.lblGuseeNumber = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblInsertAnswer = new System.Windows.Forms.Label();
			this.lblRightAnswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(170, 40);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(151, 25);
			this.txtAnswer.TabIndex = 0;
			// 
			// btnResult
			// 
			this.btnResult.Location = new System.Drawing.Point(341, 31);
			this.btnResult.Name = "btnResult";
			this.btnResult.Size = new System.Drawing.Size(92, 38);
			this.btnResult.TabIndex = 1;
			this.btnResult.Text = "查看結果";
			this.btnResult.UseVisualStyleBackColor = true;
			this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
			// 
			// lblGuseeNumber
			// 
			this.lblGuseeNumber.AutoSize = true;
			this.lblGuseeNumber.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGuseeNumber.Location = new System.Drawing.Point(120, 107);
			this.lblGuseeNumber.Name = "lblGuseeNumber";
			this.lblGuseeNumber.Size = new System.Drawing.Size(44, 22);
			this.lblGuseeNumber.TabIndex = 2;
			this.lblGuseeNumber.Text = "答案";
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(302, 107);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(44, 22);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "結果";
			// 
			// lblInsertAnswer
			// 
			this.lblInsertAnswer.AutoSize = true;
			this.lblInsertAnswer.Location = new System.Drawing.Point(48, 43);
			this.lblInsertAnswer.Name = "lblInsertAnswer";
			this.lblInsertAnswer.Size = new System.Drawing.Size(116, 15);
			this.lblInsertAnswer.TabIndex = 4;
			this.lblInsertAnswer.Text = "請輸入四位數字:";
			// 
			// lblRightAnswer
			// 
			this.lblRightAnswer.AutoSize = true;
			this.lblRightAnswer.Location = new System.Drawing.Point(392, 321);
			this.lblRightAnswer.Name = "lblRightAnswer";
			this.lblRightAnswer.Size = new System.Drawing.Size(41, 15);
			this.lblRightAnswer.TabIndex = 5;
			this.lblRightAnswer.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 356);
			this.Controls.Add(this.lblRightAnswer);
			this.Controls.Add(this.lblInsertAnswer);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.lblGuseeNumber);
			this.Controls.Add(this.btnResult);
			this.Controls.Add(this.txtAnswer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnResult;
		private System.Windows.Forms.Label lblGuseeNumber;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblInsertAnswer;
		private System.Windows.Forms.Label lblRightAnswer;
	}
}

