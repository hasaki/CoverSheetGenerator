namespace CoverSheetGenerator
{
	partial class SettingsDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this._city = new System.Windows.Forms.TextBox();
			this._state = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._zip = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._route = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._total = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this._bundleSize = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this._jobName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.generate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "City:";
			// 
			// city
			// 
			this._city.Location = new System.Drawing.Point(45, 6);
			this._city.Name = "_city";
			this._city.Size = new System.Drawing.Size(183, 20);
			this._city.TabIndex = 1;
			// 
			// state
			// 
			this._state.Location = new System.Drawing.Point(276, 6);
			this._state.Name = "_state";
			this._state.Size = new System.Drawing.Size(46, 20);
			this._state.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(235, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "State:";
			// 
			// zip
			// 
			this._zip.Location = new System.Drawing.Point(359, 6);
			this._zip.Name = "_zip";
			this._zip.Size = new System.Drawing.Size(67, 20);
			this._zip.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(328, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Zip:";
			// 
			// route
			// 
			this._route.Location = new System.Drawing.Point(57, 32);
			this._route.Name = "_route";
			this._route.Size = new System.Drawing.Size(369, 20);
			this._route.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Route:";
			// 
			// total
			// 
			this._total.Location = new System.Drawing.Point(52, 71);
			this._total.Name = "_total";
			this._total.Size = new System.Drawing.Size(63, 20);
			this._total.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Total:";
			// 
			// bundleSize
			// 
			this._bundleSize.Location = new System.Drawing.Point(193, 71);
			this._bundleSize.Name = "_bundleSize";
			this._bundleSize.Size = new System.Drawing.Size(65, 20);
			this._bundleSize.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(121, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Bundle Size:";
			// 
			// jobName
			// 
			this._jobName.Location = new System.Drawing.Point(76, 119);
			this._jobName.Name = "_jobName";
			this._jobName.Size = new System.Drawing.Size(350, 20);
			this._jobName.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Job Name:";
			// 
			// generate
			// 
			this.generate.Location = new System.Drawing.Point(351, 177);
			this.generate.Name = "generate";
			this.generate.Size = new System.Drawing.Size(75, 23);
			this.generate.TabIndex = 14;
			this.generate.Text = "&Generate...";
			this.generate.UseVisualStyleBackColor = true;
			this.generate.Click += new System.EventHandler(this.generate_Click);
			// 
			// SettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 212);
			this.Controls.Add(this.generate);
			this.Controls.Add(this._jobName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this._bundleSize);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._total);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._route);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._zip);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._state);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._city);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SettingsDialog";
			this.Text = "Cover Sheet Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _city;
		private System.Windows.Forms.TextBox _state;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _zip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _route;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _total;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox _bundleSize;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _jobName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button generate;
	}
}

