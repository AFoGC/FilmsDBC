using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements
{
	public partial class DirectoryPathSettingControl : UserControl, ISettingsControls
	{
		public DirectoryPathSettingControl()
		{
			InitializeComponent();
			clickButton_changeDirectory.SetDefaultButtonBlink();
		}

		public void GetSetting()
		{
			MainInformation.Settings.DirectoryPath = textBox_filePath.Text;
		}

		public void RefreshControl()
		{
			textBox_filePath.Text = MainInformation.Settings.DirectoryPath;
		}

		private void clickButton_changeDirectory_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					textBox_filePath.Text = fbd.SelectedPath;
				}
				String filename = "Films.fdbc";

				try
				{
					//
					// Доделать всю эту хуйню с работой и прверкой изминения директорий.
					//



					//if (!checkForFilename(filename, Directory.GetFiles(fbd.SelectedPath)))
					String filmPathName = fbd.SelectedPath + "\\" + filename;
					if (File.Exists(filmPathName))
					{
						//File.Create(filmPathName);
						//MainInformation.tableCollection.tableFilePath = filmPathName;

						using (FileStream sr = File.Create(filmPathName))
						{
							String strA = MainInformation.tableCollection.GetVoidTableCollection();
							byte[] info = new UTF8Encoding(true).GetBytes(strA);
							sr.Write(info, 0, info.Length);
						}
						MainInformation.LoadTables();
					}
				}
                finally { }
			}
		}



		private bool checkForFilename(String filename, String[] files)
		{
			foreach (String file in files)
			{
				if (file == filename)
				{
					return true;
				}
			}
			return false;
		}
	}
}
