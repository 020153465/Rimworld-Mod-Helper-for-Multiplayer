using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Rimworld_Mods_Helper
{
    public partial class Main_menu : Form
    {
        public static int GLOBALI = 0;
        public void Set_RTB_color(RichTextBox rtb, bool isCorrect)
        {
            try
            {
                if (isCorrect)
                {
                    rtb.BackColor = Color.ForestGreen;
                    rtb.ForeColor = Color.GhostWhite;
                }
                else
                {
                    rtb.BackColor = Color.OrangeRed;
                    rtb.ForeColor = Color.Black;
                }
            }
            catch (System.NullReferenceException)
            {
                return;
            }
        }

        public void CorrectSound(bool isCorrect)
        {
            if (isCorrect) { SystemSounds.Exclamation.Play(); }
            else { SystemSounds.Hand.Play(); }
        }
        public void Init_config_folder()
        {
            String appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            String path = Path.GetFullPath(appdata + "/../Locallow/Ludeon Studios/RimWorld by Ludeon Studios/");
            bool isCorrect = false;
            if (Directory.Exists(path) &&
                Directory.Exists(path + "/Config"))
            {
                configRTB.Text = path;
                isCorrect = true;
            }
            else
            {
                configRTB.Text = "Error, Config folder not found !";
            }
            Set_RTB_color(configRTB, isCorrect);
        }

        public void Init_mods_folder()
        {
            String fn = Path.GetFullPath("Rimworld Mods Helper.setting");
            bool isCorrect = false;
            if (File.Exists(fn))
            {
                string path = File.ReadLines(fn).First();
                if (Check_mods_folder(path))
                {
                    modRTB.Text = path;
                    isCorrect = true;
                }
            }
            Set_RTB_color(modRTB, isCorrect);
        }

        public void Init_ins_folder()
        {
            String cd = Directory.GetCurrentDirectory();
            bool isCorrect = false;
            if (Directory.Exists(cd + "/Config/"))
            {
                if (Directory.EnumerateFileSystemEntries(cd + "/Config/").Any())
                {
                    insConfigStatus.Text = "Detected";
                    insConfigBtn.Enabled = true;
                    isCorrect = true;
                }
                else { insConfigStatus.Text = "Empty"; }
            }
            else { Directory.CreateDirectory(cd + "/Config/"); }
            if (!isCorrect) { insConfigBtn.Enabled = false; }
            Set_RTB_color(insConfigStatus, isCorrect);

            isCorrect = false;
            if (Directory.Exists(cd + "/Mods/"))
            {
                if (Directory.EnumerateFileSystemEntries(cd + "/Mods/").Any())
                {
                    insModStatus.Text = "Detected";
                    insModBtn.Enabled = true;
                    SetModList(cd + "/Mods/");
                    isCorrect = true;
                }
                else { insModStatus.Text = "Empty"; }
            }
            else { Directory.CreateDirectory(cd + "/Mods/"); }
            if (!isCorrect) { insModBtn.Enabled = false; }
            Set_RTB_color(insModStatus, isCorrect);
        }

        public bool Check_mods_folder(String path)
        {
            if (Directory.Exists(path + "/../Data/Core") &&
                Directory.Exists(path + "/../MonoBleedingEdge"))
            {
                return true;
            }
            return false;
        }

        private void SetModList(string mod_path)
        {
            modListRTB.Text = "";
            foreach (string folder in Directory.EnumerateDirectories(mod_path))
            {
                string mod_name = GetModName(folder);
                if (mod_name != null)
                {
                    modListRTB.Text += mod_name + "\n";
                }
            }
        }

        private string GetModName(string path)
        {
            string mod_name = null;
            if (Directory.Exists(path + "/About/"))
            {
                if (File.Exists(path + "/About/About.xml"))
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(path + "/About/About.xml");
                    mod_name = path.Split('/').Last() + " | " + xml.DocumentElement.SelectSingleNode("/ModMetaData/name").InnerText;
                }
            }
            return mod_name;
        }
        private void OnChanged(object sender, FileSystemEventArgs e) { Init_ins_folder(); }
        private void OnChanged(object sender, RenamedEventArgs e) { Init_ins_folder(); }
        private void OnError(object sender, ErrorEventArgs e) { MessageBox.Show("File watcher has encountered error !", "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public Main_menu()
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Mods/");
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Config/");
            InitializeComponent();
            Init_component();
            Init_config_folder();
            Init_mods_folder();
            Init_ins_folder();
        }

        private void Init_component()
        {
            configLabel.Location = new Point(10, 10);
            configLabel.Size = new Size(100, 30);
            configRTB.Location = new Point(configLabel.Location.X + configLabel.Size.Width + 10, configLabel.Location.Y);
            configRTB.Size = new Size(splitContainer1.Panel1.Width - configRTB.Location.X - 10, configLabel.Size.Height);
            configRTB.SelectionAlignment = HorizontalAlignment.Center;

            modLabel.Location = new Point(configLabel.Location.X, configLabel.Location.Y + configLabel.Size.Height + 10);
            modLabel.Size = configLabel.Size;
            mpBtn1.Size = new Size(70, modLabel.Size.Height);
            mpBtn1.Location = new Point(splitContainer1.Panel1.Width - 10 - mpBtn1.Size.Width, modLabel.Location.Y);
            modRTB.Location = new Point(modLabel.Location.X + modLabel.Size.Width + 10, modLabel.Location.Y);
            modRTB.Size = new Size(mpBtn1.Location.X - modRTB.Location.X - 10, modLabel.Size.Height);
            modRTB.SelectionAlignment = HorizontalAlignment.Center;

            // Seperator //
            sepLabel.Location = new Point(0, modLabel.Location.Y + modLabel.Size.Height + 10);
            sepLabel.Size = new Size(this.MaximumSize.Width, 1);
            // Seperator //

            insConfigLabel.Location = new Point(10, 0);
            insConfigLabel.Size = new Size(200, 30);
            insConfigStatus.Location = new Point(insConfigLabel.Location.X + insConfigLabel.Size.Width + 10, insConfigLabel.Location.Y);
            insConfigStatus.Size = new Size(100, 30);
            insConfigStatus.SelectionAlignment = HorizontalAlignment.Center;
            insModStatus.Size = insConfigStatus.Size;
            insModStatus.Location = new Point(splitContainer1.Panel2.Width - insModStatus.Size.Width - 10, insConfigLabel.Location.Y);
            insModStatus.SelectionAlignment = HorizontalAlignment.Center;
            insModLabel.Size = new Size(200, 30);
            insModLabel.Location = new Point(insModStatus.Location.X - 210, insModStatus.Location.Y);

            insConfigBtn.Location = new Point(insConfigLabel.Location.X, splitContainer1.Panel2.Height - 40);
            insConfigBtn.Size = new Size(150, 30);
            insModBtn.Size = new Size(150, 30);
            insModBtn.Location = new Point(splitContainer1.Panel2.Width - insModBtn.Size.Width - 10, splitContainer1.Panel2.Height - 40);
            progressBar.Size = new Size(splitContainer1.Panel2.Width - insConfigBtn.Size.Width * 2 - 20, insConfigBtn.Size.Height);
            progressBar.Location = new Point(splitContainer1.Size.Width / 2 - progressBar.Size.Width / 2, insConfigBtn.Location.Y);

            modListRTB.Location = new Point(insConfigLabel.Location.X, insConfigLabel.Location.Y + insConfigLabel.Size.Height + 10);
            modListRTB.Size = new Size(splitContainer1.Panel2.Width - 20, insConfigBtn.Location.Y - insConfigLabel.Location.Y - configLabel.Size.Height * 2 + 10);

            watcher.Path = Directory.GetCurrentDirectory();
            watcher.Error += OnError;
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnChanged;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mpBtn1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mod_folder = new FolderBrowserDialog();
            mod_folder.Description = "Select Rimworld's Mods folder";
            bool isCorrect = false;
            if (mod_folder.ShowDialog() == DialogResult.OK)
            {
                String sel_path = mod_folder.SelectedPath;
                if (Check_mods_folder(sel_path))
                {
                    File.WriteAllText("Rimworld Mods Helper.setting", sel_path);
                    isCorrect = true;
                }
                else if(Check_mods_folder(sel_path + "/Mods")){
                    sel_path += "/Mods";
                    File.WriteAllText("Rimworld Mods Helper.setting", sel_path);
                    isCorrect = true;
                }
                modRTB.Text = sel_path;
                Set_RTB_color(modRTB, isCorrect);
                CorrectSound(isCorrect);
            }
        }

        private void configLabel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(configRTB.Text))
            {
                Process.Start(configRTB.Text);
            }
        }

        private void modLabel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(modRTB.Text))
            {
                Process.Start(modRTB.Text);
            }
        }

        private void insModBtn_Click(object sender, EventArgs e)
        {
            string[] mods = modListRTB.Lines;
            string cd = Directory.GetCurrentDirectory();
            progressBar.Maximum = mods.Length-2;
            progressBar.Value = 0;
            for (int i = 0; i < mods.Length - 1; i++)
            {
                string mod = mods[i].Split('|').First();
                // Delete mod in game's mod folder first //
                string old_mod_path = modRTB.Text + "/" + mod + "/";
                if (Directory.Exists(old_mod_path)) { Directory.Delete(old_mod_path, true); }
                // Copy new mod to game's mod folder //
                string new_mod_path = cd + "/Mods/" + mod;
                // Create all of the directories //
                foreach (string dirPath in Directory.GetDirectories(new_mod_path, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(new_mod_path, old_mod_path));
                }
                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(new_mod_path, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(new_mod_path, old_mod_path), true);
                }

                mod = mods[i].Replace(" - [Installed]", "").Trim();
                mods[i] = mod + " - [Installed]";
                SetProgressBar(i);
            }
            modListRTB.Lines = mods;
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Installed Mods Successfully !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void insConfigBtn_Click(object sender, EventArgs e)
        {
            string cd = Directory.GetCurrentDirectory();
            progressBar.Value = 0;
            string new_config_path = cd + "/Config/";
            string old_config_path = configRTB.Text + "/";
            progressBar.Value = 10;
            // Create all of the directories //
            foreach (string dirPath in Directory.GetDirectories(new_config_path, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(new_config_path, old_config_path));
            }
            progressBar.Value = 50;
            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(new_config_path, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(new_config_path, old_config_path), true);
            }
            progressBar.Value = 100;
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Installed Config Successfully !", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetProgressBar(int i) 
        {
            progressBar.Value = i;
            progressBar.Update();
            progressBar.Refresh();
        }
    }
}

