using FilmsDBC.CinemaDataTypes;
using FilmsDBC.StaticFilmClasses;
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
using TablesLibrary.Interpreter;

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
            if (MainInformation.Settings.DirectoryPath != textBox_filePath.Text)
            {
				MainInformation.Settings.DirectoryPath = textBox_filePath.Text;

				try
				{
					String filename = "Films.fdbc";
					String filmPathName = textBox_filePath.Text + "\\" + filename;
					if (!File.Exists(filmPathName))
					{

						using (FileStream sr = File.Create(filmPathName))
						{
							String strA = "";

							strA = "<DocStart>\n";
							foreach (Table table in MainInformation.tableCollection.Tables)
							{
								if (table.DataType == typeof(Genre))
								{
									strA += GenreMethods.GetDefaultGenres();
								}
								else
								{
									strA += table.GetVoidTableInfo();
								}
							}
							strA += "<DocEnd>\n";

							byte[] info = new UTF8Encoding(true).GetBytes(strA);
							sr.Write(info, 0, info.Length);
						}

						MainInformation.tableCollection.tableFilePath = filmPathName;
						MainInformation.LoadTables();
						MainInformation.MainForm.MainControl.loadCategories();
						MainInformation.MainForm.MainControl.loadGenres();
						MainInformation.MainForm.MainControl.loadFilmTable();
					}
				}
				finally { }
			}
			//MainInformation.Settings.DirectoryPath = textBox_filePath.Text;
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
