using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Settings;
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

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.SettingsMenu.FormElements
{
    public partial class ProfileSettingControl : UserControl, ISettingsControls
	{
		private ProfileCollection profileCollection = null;
		private Profile usedProfile = null;



		public ProfileSettingControl()
		{
			InitializeComponent();
			clickButton_changeDirectory.SetDefaultButtonBlink();
			clickButton_expand_reduce.SetDefaultButtonBlink();
		}

		public void GetSettings()
		{
			MainInfo.Settings.UsedProfile = usedProfile;
			MainInfo.TableCollection.TableFilePath = usedProfile.MainFilePath;
		}

		public void RefreshControl()
		{
			profileCollection = MainInfo.Settings.Profiles;
			usedProfile = MainInfo.Settings.UsedProfile;

			textBox_profileName.Text = usedProfile.Name;

			comboBox_Profiles.Items.Clear();
			comboBox_rename.Items.Clear();
			comboBox_remove.Items.Clear();

			foreach (Profile prof in profileCollection.Profiles)
			{
				comboBox_Profiles.Items.Add(prof);
				comboBox_rename.Items.Add(prof);
				comboBox_remove.Items.Add(prof);

				if (prof == usedProfile)
				{
					comboBox_Profiles.SelectedItem = prof;
				}
			}

		}


		//В CRUD методах нужно ещё добавить проверок
		private void clickButton_changeDirectory_Click(object sender, EventArgs e)
		{
			usedProfile = (Profile)comboBox_Profiles.SelectedItem;
			textBox_profileName.Text = usedProfile.Name;
		}

		private void clickButton_rename_Click(object sender, EventArgs e)
		{
            if (textBox_rename.Text != "")
            {
				Profile profileFrom = (Profile)comboBox_rename.SelectedItem;
				profileFrom.RenameProfile(textBox_rename.Text);

				this.RefreshControl();

				comboBox_rename.SelectedItem = profileFrom;
			}
		}

		private void clickButton_remove_Click(object sender, EventArgs e)
		{
            if (comboBox_remove.Text != "")
            {
				Profile prof = (Profile)comboBox_remove.SelectedItem;
				Directory.Delete(prof.ProfilePath, true);

				profileCollection.RemoveProfile(prof);

				this.RefreshControl();
			}
		}

		private void clickButton_add_Click(object sender, EventArgs e)
		{
            if (textBox_add.Text != "")
            {
				bool exclusive = true;
				Profile newProfile = new Profile(textBox_add.Text);

				foreach (Profile prof in profileCollection.Profiles)
				{
					if (prof.Name == newProfile.Name) exclusive = false;
				}

				if (exclusive)
				{
					Directory.CreateDirectory(newProfile.ProfilePath);
					using (FileStream fs = File.Create(newProfile.MainFilePath)) { }

					TableCollection tc = MainInfo.GetDefaultTableCollectionData();
					tc.TableFilePath = newProfile.MainFilePath;

					Table<Genre> genreTable = tc.GetTable<Genre>();
					genreTable.RemoveAll(true);

					foreach (Genre genre in MainInfo.Tables.GenresTable)
					{
						genreTable.AddWithoutReindexation(genre);
					}

					tc.SaveTables();

					profileCollection.AddProfile(newProfile);
				}

				this.RefreshControl();
			}
		}

		private bool expanded = false;
		public bool Expanded
        {
            get
            {
				return expanded;
            }
            set
            {
                if (value)
                {
					this.Size = new Size(this.Size.Width, 80);
                }
                else
                {
					this.Size = new Size(this.Size.Width, 20);
				}

				expanded = value;
            }
        }
        private void clickButton_expand_reduce_Click(object sender, EventArgs e)
        {
			Expanded = !Expanded;
        }
    }
}
