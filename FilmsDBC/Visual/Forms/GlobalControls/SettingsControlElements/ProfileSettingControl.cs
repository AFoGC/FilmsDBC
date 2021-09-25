using FilmsDBC.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.Forms.GlobalControls.SettingsControlElements
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
			MainInformation.Settings.UsedProfile = usedProfile;
			MainInformation.tableCollection.tableFilePath = usedProfile.MainFilePath;
		}

		public void RefreshControl()
		{
			profileCollection = MainInformation.Settings.Profiles;
			usedProfile = MainInformation.Settings.UsedProfile;

			textBox_profileName.Text = usedProfile.Name;

			comboBox_Profiles.Items.Clear();

			foreach (Profile prof in profileCollection.Profiles)
			{
				comboBox_Profiles.Items.Add(prof.Name);

				if (prof == usedProfile)
				{
					comboBox_Profiles.SelectedItem = prof.Name;
				}
			}

		}

		private void clickButton_changeDirectory_Click(object sender, EventArgs e)
		{
			if (textBox_profileName.Text != comboBox_Profiles.Text)
			{
				foreach (Profile prof in profileCollection.Profiles)
				{
					if (comboBox_Profiles.Text == prof.Name)
					{
						usedProfile = prof;

						textBox_profileName.Text = usedProfile.Name;
					}
				}
			}
		}
    }
}
