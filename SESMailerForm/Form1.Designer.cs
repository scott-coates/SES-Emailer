namespace SESMailerForm
{
	partial class Form1
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtFrom = new System.Windows.Forms.TextBox();
			this.txtAWSSecretKey = new System.Windows.Forms.TextBox();
			this.txtAWSAccessKey = new System.Windows.Forms.TextBox();
			this.txtErrors = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 16);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(1272, 422);
			this.webBrowser1.TabIndex = 1;
			this.webBrowser1.Url = new System.Uri("http://htmleditor.in/index.html", System.UriKind.Absolute);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.webBrowser1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 260);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1278, 441);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// listBox1
			// 
			this.listBox1.DisplayMember = "Email";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 54);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 95);
			this.listBox1.TabIndex = 4;
			this.listBox1.ValueMember = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(227, 54);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(226, 180);
			this.txtMessage.TabIndex = 6;
			this.txtMessage.Text = "Message";
			// 
			// txtFrom
			// 
			this.txtFrom.Location = new System.Drawing.Point(563, 54);
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new System.Drawing.Size(129, 20);
			this.txtFrom.TabIndex = 7;
			this.txtFrom.Text = "CliqFlip<support@cliqflip.com>";
			// 
			// txtAWSSecretKey
			// 
			this.txtAWSSecretKey.Location = new System.Drawing.Point(563, 140);
			this.txtAWSSecretKey.Name = "txtAWSSecretKey";
			this.txtAWSSecretKey.Size = new System.Drawing.Size(129, 20);
			this.txtAWSSecretKey.TabIndex = 8;
			this.txtAWSSecretKey.Text = "AWSSecretKey";
			// 
			// txtAWSAccessKey
			// 
			this.txtAWSAccessKey.Location = new System.Drawing.Point(563, 98);
			this.txtAWSAccessKey.Name = "txtAWSAccessKey";
			this.txtAWSAccessKey.Size = new System.Drawing.Size(129, 20);
			this.txtAWSAccessKey.TabIndex = 9;
			this.txtAWSAccessKey.Text = "AWSAccessKey";
			// 
			// txtErrors
			// 
			this.txtErrors.Location = new System.Drawing.Point(775, 35);
			this.txtErrors.Multiline = true;
			this.txtErrors.Name = "txtErrors";
			this.txtErrors.Size = new System.Drawing.Size(226, 180);
			this.txtErrors.TabIndex = 10;
			this.txtErrors.Text = "Errors";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(1191, 231);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 11;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(227, 15);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(226, 20);
			this.txtSubject.TabIndex = 12;
			this.txtSubject.Text = "Subject";
			this.txtSubject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(1026, 35);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(226, 180);
			this.txtOutput.TabIndex = 13;
			this.txtOutput.Text = "Output";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(503, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "From Email";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1278, 701);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtErrors);
			this.Controls.Add(this.txtAWSAccessKey);
			this.Controls.Add(this.txtAWSSecretKey);
			this.Controls.Add(this.txtFrom);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOpenFile);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.TextBox txtAWSSecretKey;
		private System.Windows.Forms.TextBox txtAWSAccessKey;
		private System.Windows.Forms.TextBox txtErrors;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Label label3;
	}
}

