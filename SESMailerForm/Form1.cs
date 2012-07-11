using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Amazon;
using Amazon.SimpleEmail.Model;
using Message = System.Windows.Forms.Message;

namespace SESMailerForm
{
	public partial class Form1 : Form
	{
		private List<User> _users;

		public Form1()
		{
			InitializeComponent();
			openFileDialog1.FileName = null;

		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if(result == DialogResult.OK)
			{
				
				label1.Text = openFileDialog1.FileName;
				using(var csv = new CsvHelper.CsvReader(File.OpenText(openFileDialog1.FileName)))
				{
					_users = csv.GetRecords<User>().OrderBy(x=>x.Email).ToList();
					listBox1.Items.AddRange(_users.ToArray());
					label2.Text = _users.Count.ToString();
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty( openFileDialog1.FileName))
			{
				MessageBox.Show("Must get a file first", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//smtp would've been quicker but the SSL that .NET uses isn't the same as AWS
				using (var sesClient = AWSClientFactory.CreateAmazonSimpleEmailServiceClient(txtAWSAccessKey.Text,txtAWSSecretKey.Text))
				{
					string sesFromEmail = txtFrom.Text;
					int counter = 1;
					foreach (var user in _users)
					{
						try
						{
							var sendEmailRequest = new SendEmailRequest()
								.WithDestination(new Destination().WithToAddresses(user.Email))
								.WithSource(sesFromEmail)
								.WithReturnPath(sesFromEmail)
								.WithMessage(new Amazon.SimpleEmail.Model.Message()
								             	.WithBody(new Body().WithHtml(new Content(txtMessage.Text).WithCharset("UTF-8")))
								             	.WithSubject(new Content(txtSubject.Text).WithCharset("UTF-8")));

							var response = sesClient.SendEmail(sendEmailRequest);
							txtOutput.AppendText("Processed: " + counter++);
							txtOutput.AppendText(Environment.NewLine);
							txtOutput.AppendText(user.Email);
							txtOutput.AppendText(Environment.NewLine);
							txtOutput.AppendText(response.SendEmailResult.MessageId);
							txtOutput.AppendText(Environment.NewLine);
							txtOutput.AppendText(Environment.NewLine);
							txtOutput.AppendText("------------");
							txtOutput.AppendText(Environment.NewLine);
						}
						catch (Exception exception)
						{
							txtErrors.AppendText(user.Email);
							txtErrors.AppendText(Environment.NewLine);
							txtErrors.AppendText(exception.Message);
							txtErrors.AppendText(Environment.NewLine);
							txtErrors.AppendText(Environment.NewLine);
							txtErrors.AppendText("------------");
							txtErrors.AppendText(Environment.NewLine);
						}
					}
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
