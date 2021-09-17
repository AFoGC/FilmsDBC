using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Settings
{
	public class Profile
	{
		private String name = "";

		public Profile(String name)
		{
			this.name = name;
		}

		public String Name
		{
			get { return name; }
		}

		public static String AllProfilesPath
		{
			get { return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Profiles"; }
		}

		public String ProfilePath
		{
			get { return AllProfilesPath + "\\" + name; }
		}

		public String MainFilePath
		{
			get { return ProfilePath + "\\Films.fdbc"; }
		}

		public static Profile[] GetAllProfiles
		{
			get
			{
				List<Profile> export = new List<Profile>();
				if (Directory.Exists(AllProfilesPath))
				{
                    foreach (String str in Directory.GetDirectories(AllProfilesPath))
                    {
						
						export.Add(new Profile(getDirecotryName(str)));
                    }
                    if (export.Count != 0)
                    {
						return export.ToArray();
                    }
				}
                else
                {
					Directory.CreateDirectory(AllProfilesPath + "\\Main");
                }

				export.Add(new Profile("Main"));
				return export.ToArray();
			}
		}

		private static String getDirecotryName(String import)
        {
			int i = import.Length - 1;
            for (; i > 0; i--)
            {
                if (import[i] == '\\')
                {
					return import.Substring(i);
                }
            }

			return "";
        }

        public override string ToString()
        {
			return name;
        }
    }
}
