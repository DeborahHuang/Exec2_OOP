namespace Q2_擲骰子遊戲
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
			this.lbl = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtAns1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lblPoints = new System.Windows.Forms.Label();
			this.txtAns2 = new System.Windows.Forms.TextBox();
			this.txtAns3 = new System.Windows.Forms.TextBox();
			this.txtAns4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbl.Location = new System.Drawing.Point(35, 41);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(99, 22);
			this.lbl.TabIndex = 0;
			this.lbl.Text = "擲四顆骰子:";
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnStart.Location = new System.Drawing.Point(161, 30);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(118, 45);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "開始";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtAns1
			// 
			this.txtAns1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAns1.Location = new System.Drawing.Point(37, 96);
			this.txtAns1.Multiline = true;
			this.txtAns1.Name = "txtAns1";
			this.txtAns1.Size = new System.Drawing.Size(60, 77);
			this.txtAns1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox2.Location = new System.Drawing.Point(117, 199);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(162, 77);
			this.textBox2.TabIndex = 2;
			// 
			// lblPoints
			// 
			this.lblPoints.AutoSize = true;
			this.lblPoints.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPoints.Location = new System.Drawing.Point(63, 226);
			this.lblPoints.Name = "lblPoints";
			this.lblPoints.Size = new System.Drawing.Size(48, 22);
			this.lblPoints.TabIndex = 0;
			this.lblPoints.Text = "點數:";
			// 
			// txtAns2
			// 
			this.txtAns2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAns2.Location = new System.Drawing.Point(103, 96);
			this.txtAns2.Multiline = true;
			this.txtAns2.Name = "txtAns2";
			this.txtAns2.Size = new System.Drawing.Size(60, 77);
			this.txtAns2.TabIndex = 2;
			// 
			// txtAns3
			// 
			this.txtAns3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAns3.Location = new System.Drawing.Point(169, 96);
			this.txtAns3.Multiline = true;
			this.txtAns3.Name = "txtAns3";
			this.txtAns3.Size = new System.Drawing.Size(60, 77);
			this.txtAns3.TabIndex = 2;
			// 
			// txtAns4
			// 
			this.txtAns4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAns4.Location = new System.Drawing.Point(235, 96);
			this.txtAns4.Multiline = true;
			this.txtAns4.Name = "txtAns4";
			this.txtAns4.Size = new System.Drawing.Size(60, 77);
			this.txtAns4.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 340);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.txtAns4);
			this.Controls.Add(this.txtAns2);
			this.Controls.Add(this.txtAns3);
			this.Controls.Add(this.txtAns1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblPoints);
			this.Controls.Add(this.lbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtAns1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblPoints;
		private System.Windows.Forms.TextBox txtAns2;
		private System.Windows.Forms.TextBox txtAns3;
		private System.Windows.Forms.TextBox txtAns4;
	}
}

