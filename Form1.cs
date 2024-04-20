namespace Dragon_s_Dogma_2_Save_Manager
{
    using Microsoft.Web.WebView2.WinForms;
    using Microsoft.Web.WebView2.Core;
    using System.Drawing.Text;
    using System.IO;
    using Microsoft.Win32;
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {


        string folderPath = Properties.Settings.Default.filepath;
        string backupPath = Properties.Settings.Default.backuppath;
        string selectedbackupfilePath;
        string selectedbackupfilePathcheck;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {


            /*string steamRegistryPath = @"HKEY_CURRENT_USER\Software\Valve\Steam";
            string steamInstallPath = Registry.GetValue(steamRegistryPath, "SteamPath", null) as string;

            if (!string.IsNullOrEmpty(steamInstallPath))
            {
                textDirectory.Text = steamInstallPath;
            }
            else
            {
                
            }*/


            unfocusbutton.Focus();


            if (!string.IsNullOrEmpty(folderPath))
            {
                textDirectory.Text = folderPath;
                unfocuslab.Visible = false;
            }


            if (!string.IsNullOrEmpty(backupPath))
                backupDirectory.Text = backupPath;


            if (string.IsNullOrEmpty(textDirectory.Text))
            {
                textDirectory.Text = " Select the \"remote\" folder that is located in your Steam folder.";
                unfocuslab.Visible = true;
            }

            if (string.IsNullOrEmpty(backupDirectory.Text))
            {
                backupDirectory.Text = " Select a folder to store backup.";
            }

            ActualizeTreeView();

        }

        private void steampathbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();

            if (string.IsNullOrEmpty(dlg.SelectedPath))
            {
                textDirectory.Text = " Select the \"remote\" folder that is located in your Steam folder.";
                Properties.Settings.Default.filepath = dlg.SelectedPath;
                folderPath = dlg.SelectedPath;
                Properties.Settings.Default.Save();
                unfocuslab.Visible = true;
            }
            else
            {
                textDirectory.Text = dlg.SelectedPath;
                Properties.Settings.Default.filepath = dlg.SelectedPath;
                folderPath = dlg.SelectedPath;
                Properties.Settings.Default.Save();
                unfocuslab.Visible = false;
            }
        }

        private void backupathbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();

            if (string.IsNullOrEmpty(dlg.SelectedPath))
            {
                backupDirectory.Text = " Select a folder to store backup.";
                Properties.Settings.Default.backuppath = dlg.SelectedPath;
                backupPath = dlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                dlg.SelectedPath = Regex.Replace(dlg.SelectedPath, @"\\DD2\sSave\sBackup$", "");
                Properties.Settings.Default.backuppath = dlg.SelectedPath;
                backupPath = dlg.SelectedPath;
                backupDirectory.Text = dlg.SelectedPath;
                Properties.Settings.Default.Save();
            }

            ActualizeTreeView();
        }

        private void createBUbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            // Specify the location where you want to create the folder
            if (Regex.IsMatch(folderPath + "\\win64_save", @"remote\\win64_save$") && !string.IsNullOrEmpty(folderPath))
                MessageBox.Show($"Error creating Backup savefile, Steam folder path not set correctly.");
            else if (string.IsNullOrEmpty(backupPath))
                MessageBox.Show($"Error creating Backup savefile, backup folder path is not set correctly.");
            else
            {
                try
                {
                    // Check if the folder doesn't exist, then create it
                    if (!Directory.Exists(backupPath + "\\DD2 Save Backup"))
                    {
                        Directory.CreateDirectory(backupPath + "\\DD2 Save Backup");

                    }
                    else if (Regex.IsMatch(backupPath, @"\\DD2\sSave\sBackup$"))
                    {
                        backupPath = Regex.Replace(backupPath, @"\\DD2\sSave\sBackup$", "");
                    }

                    string[] files = Directory.GetFiles(folderPath + "\\win64_save");

                    //generate folder to store savefiles
                    if (!string.IsNullOrEmpty(savefilename.Text))
                    {
                        Directory.CreateDirectory(backupPath + "\\DD2 Save Backup\\" + savefilename.Text);

                        foreach (string file in files)
                        {

                            File.Copy(file, backupPath + "\\DD2 Save Backup\\" + savefilename.Text + "\\" + Path.GetFileName(file), true);

                        }
                    }
                    else
                    {

                        FileInfo fileInfo = new FileInfo(files[0]);
                        DateTime dtcreation = fileInfo.CreationTime;
                        string pattern = @"[\/\\\:\*\?\""\<\>\|]";
                        string cleanedFileName = Regex.Replace(dtcreation.ToString(), pattern, "-");
                        string cleanedFileName1 = Regex.Replace(cleanedFileName, @"\d{2}$", "");
                        string cleanedFileName2 = Regex.Replace(cleanedFileName1, @"-(?!.*-)", "");
                        string cleanedFileNameF = Regex.Replace(cleanedFileName2, @"-(?!.*-)", "h");
                        Directory.CreateDirectory(backupPath + "\\DD2 Save Backup\\" + "DD2 Save " + cleanedFileNameF);

                        foreach (string file in files)
                        {

                            File.Copy(file, backupPath + "\\DD2 Save Backup\\" + "DD2 Save " + cleanedFileNameF + "\\" + Path.GetFileName(file), true);

                        }

                    }


                    ActualizeTreeView();



                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error : {ex.Message}");
                }
            }
        }

        private void LoadBUbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            if (MessageBox.Show("Load this Backup : " + selectedbackupfilePathcheck + " ?", "Backup load", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(backupPath))
                    MessageBox.Show($"Error loading Backup savefile, backup folder path is not set.");

                else if (selectedbackupfilePathcheck != null)
                {
                    try
                    {
                        //check if steamfolder is set correctly
                        if (Regex.IsMatch(folderPath + "\\win64_save", @"remote\\win64_save$") && !string.IsNullOrEmpty(folderPath))
                        {
                            string[] files = Directory.GetFiles(selectedbackupfilePath);

                            foreach (string file in files)
                            {

                                File.Copy(file, folderPath + "\\win64_save\\" + Path.GetFileName(file), true);

                            }

                            ActualizeTreeView();
                        }
                        else
                            MessageBox.Show("Error steam folder path not set correctly, make sure that it is set to \"remote\"");

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error : {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Error, No backup selected.");
                }


            }



        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete Backup ?", "Backup deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                unfocusbutton.Focus();
                string SaveFoldersDelete = selectedbackupfilePath;
                Directory.Delete(selectedbackupfilePath, true);
                ActualizeTreeView();
            }

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            ActualizeTreeView();
        }

        private void ActualizeTreeView()
        {
            if (Directory.Exists(backupPath + "\\DD2 Save Backup"))
            {
                string[] SaveFolders = Directory.GetDirectories(backupPath + "\\DD2 Save Backup\\");
                treeView1.Nodes.Clear();
                // Add folder to the ListBox
                foreach (string Save in SaveFolders)
                {
                    treeView1.Nodes.Add(Path.GetFileName(Save));
                    //listBox1.Items.Add(Path.GetFileName(Save));
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            unfocusbutton.Focus();
            selectedbackupfilePath = backupPath + "\\DD2 Save Backup\\" + treeView1.SelectedNode.Text;
            selectedbackupfilePathcheck = treeView1.SelectedNode.Text;

        }

        private void NewSavebtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();

        }
    }
}
