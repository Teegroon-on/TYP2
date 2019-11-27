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

namespace WindowsFormsAppTYP2
{
	public partial class Form1 : Form
	{
		List<string[]> data = new List<string[]>();
		string[] dataHash = new string[100];
		Random rnd = new Random();
		int[] perm = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonLoadFromFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
			string buffer = null;
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamReader FilePassRead = new StreamReader(fileDialog.FileName);
				buffer = FilePassRead.ReadLine();
				FilePassRead.Close();
			}
			data.Clear();
			int Num = 0;
			while(true)
			{
				if (buffer != " ")
				{
					if (buffer.Substring(0, buffer.IndexOf(";")).Length < 33)
					{
						data.Add(new string[2]);
						data[data.Count - 1][0] = Num.ToString();
						data[data.Count - 1][1] = buffer.Substring(0, buffer.IndexOf(";"));
						Num++;
					}
					buffer = buffer.Substring(buffer.IndexOf(";") + 1);

				}
				else
				{
					break;
				}
			}


			foreach(string[] item in data)
			{
				listBoxID.Items.Add(item[1]);
				dataGridViewSimple.Rows.Add(item);
				AddHash(item[1]);
			}

			for(int i=0; i < 100; i++)
			{
				dataGridViewHF.Rows.Add(i, dataHash[i]);
			}
		}


		private int Hash(int i)
		{
			int j = 0;
			j = rnd.Next(0, i + 1);
			return j;
		}

		private void AddHash(string value)
		{
			perm = Enumerable.Range(0, 100).ToArray();
			int n = 0;
			for(int i = 100 - 1; i >= 1; i--)
			{
				n = Hash(i + 1);
				if (dataHash[n] == null)
				{
					dataHash[n] = value;
					break;
				}
				else
				{
					int temp = perm[n];
					perm[n] = perm[i];
					perm[i] = temp;
				}
			}

		}

		private int FindHash(string value)
		{
			int HashNum = -1;
			perm = Enumerable.Range(0, 100).ToArray();

			for(int i = 100 - 1; i >= 1; i--)
			{
				int n = Hash(i + 1);
				if (dataHash[n] == value)
				{
					HashNum = n;
				}
				else
				{
					int temp = perm[n];
					perm[n] = perm[i];
					perm[i] = temp;
				}

			}
			return HashNum;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			if (textBoxSearch.Text != "" && textBoxSearch.Text != " ")
			{
				int HashNum = FindHash(textBoxSearch.Text);
				if (HashNum != -1)
				{
					richTextBoxHfResult.Text = "Идетификатор найден \n Его номер " + HashNum.ToString();
				}
				else
				{
					richTextBoxHfResult.Text = "Идентификатор не найден";
				}

				string SimpleNum = "-1";
				for(int i = 0; i < data.Count; i++)
				{
					if(data[i][1] == textBoxSearch.Text)
					{
						SimpleNum = (Convert.ToInt32(data[i][0])).ToString();
					}
				}

				if(!SimpleNum.Contains("-1"))
				{
					richTextBoxSimpleResult.Text = "Идентификатор найден \n его номер " + SimpleNum;
				}
				else
				{
					richTextBoxSimpleResult.Text = "Идентификатор не найден";
				}
				
			}
			else
			{
				MessageBox.Show("Введите идентификатор для поиска");
			}
		}
	}
}
