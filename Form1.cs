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

            /*
            if (Regex.IsMatch(folderPath + "\\win_64save", @"remote\\win_64save$") && !string.IsNullOrEmpty(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath + "\\win64_save");
                // Add files to the ListBox
                
                foreach (string file in files)
                {
                    //FileInfo fileInfo = new FileInfo(file);
                    //DateTime dtcreation = fileInfo.LastWriteTime;
                    File.Copy(file,backupPath);
                    //listBox1.Items.Add(Path.GetFileName(file));
                    //listBox1.Items.Add(dtcreation);
                }
            }
            else
            MessageBox.Show("folder path not set correctly");
            */
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
                Properties.Settings.Default.backuppath = dlg.SelectedPath;
                backupPath = dlg.SelectedPath;
                backupDirectory.Text = dlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void LoadBUbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();













            //string SaveFolders = Path.GetDirectoryName(backupPath + "\\DD2 Save Backup\\");
            //MessageBox.Show(SaveFolders);
        }

        private void createBUbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            // Specify the location where you want to create the folder
            if (string.IsNullOrEmpty(folderPath))
                MessageBox.Show($"Error creating Backup savefile, Steam folder path not set.");
            else if (string.IsNullOrEmpty(backupPath))
                MessageBox.Show($"Error creating Backup savefile, backup folder path is not set.");
            else
            {
                try
                {
                    // Check if the folder doesn't exist, then create it
                    if (!Directory.Exists(backupPath + "\\DD2 Save Backup"))
                    {
                        Directory.CreateDirectory(backupPath + "\\DD2 Save Backup");


                    }





                    //check if steamfolder is set correctly
                    if (Regex.IsMatch(folderPath + "\\win_64save", @"remote\\win_64save$") && !string.IsNullOrEmpty(folderPath))
                    {
                        string[] files = Directory.GetFiles(folderPath + "\\win64_save");
                        //generate folder to store savefiles

                        if (!string.IsNullOrEmpty(savefilename.Text))
                        {
                            Directory.CreateDirectory(backupPath + "\\DD2 Save Backup\\" + savefilename.Text);

                            foreach (string file in files)
                            {
                                //FileInfo fileInfo = new FileInfo(file);
                                //DateTime dtcreation = fileInfo.LastWriteTime;
                                File.Copy(file, backupPath + "\\DD2 Save Backup\\" + savefilename.Text + "\\" + Path.GetFileName(file), true);
                                //listBox1.Items.Add(Path.GetFileName(file));
                                //listBox1.Items.Add(dtcreation);
                            }
                        }
                        else
                        {

                            FileInfo fileInfo = new FileInfo(files[0]);
                            DateTime dtcreation = fileInfo.CreationTime;
                            string pattern = @"[\/\\\:\*\?\""\<\>\|]";
                            string cleanedFileName = Regex.Replace(dtcreation.ToString(), pattern, "-");
                            Directory.CreateDirectory(backupPath + "\\DD2 Save Backup\\" + "DD2 Save " + cleanedFileName);

                            foreach (string file in files)
                            {
                                //FileInfo fileInfo = new FileInfo(file);
                                //DateTime dtcreation = fileInfo.LastWriteTime;
                                File.Copy(file, backupPath + "\\DD2 Save Backup\\" + "DD2 Save " + cleanedFileName + "\\" + Path.GetFileName(file), true);
                                //listBox1.Items.Add(Path.GetFileName(file));
                                //listBox1.Items.Add(dtcreation);
                            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            unfocusbutton.Focus();
            ActualizeTreeView();
        }
    }
}
