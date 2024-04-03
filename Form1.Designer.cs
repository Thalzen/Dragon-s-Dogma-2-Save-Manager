namespace Dragon_s_Dogma_2_Save_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textDirectory = new TextBox();
            steampathbtn = new Button();
            unfocuslab = new Label();
            createBUbtn = new Button();
            backupDirectory = new TextBox();
            backupathbtn = new Button();
            LoadBUbtn = new Button();
            label1 = new Label();
            savefilename = new TextBox();
            Newsavebtn = new Button();
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            unfocusbutton = new Button();
            label2 = new Label();
            Refreshbtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textDirectory
            // 
            textDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textDirectory.BackColor = Color.FromArgb(64, 64, 64);
            textDirectory.BorderStyle = BorderStyle.FixedSingle;
            textDirectory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDirectory.ForeColor = Color.Silver;
            textDirectory.Location = new Point(113, 12);
            textDirectory.Margin = new Padding(5, 6, 5, 6);
            textDirectory.Name = "textDirectory";
            textDirectory.Size = new Size(541, 25);
            textDirectory.TabIndex = 1;
            textDirectory.Text = " Select the \"remote\" folder that is located in your Steam folder.";
            // 
            // steampathbtn
            // 
            steampathbtn.BackColor = Color.FromArgb(31, 31, 31);
            steampathbtn.BackgroundImageLayout = ImageLayout.None;
            steampathbtn.FlatStyle = FlatStyle.Flat;
            steampathbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            steampathbtn.Location = new Point(7, 8);
            steampathbtn.Name = "steampathbtn";
            steampathbtn.Size = new Size(98, 32);
            steampathbtn.TabIndex = 2;
            steampathbtn.Text = "SteamFiles";
            steampathbtn.UseVisualStyleBackColor = false;
            steampathbtn.Click += steampathbtn_Click;
            // 
            // unfocuslab
            // 
            unfocuslab.AutoSize = true;
            unfocuslab.ForeColor = Color.Silver;
            unfocuslab.Location = new Point(5, 43);
            unfocuslab.Name = "unfocuslab";
            unfocuslab.Size = new Size(527, 19);
            unfocuslab.TabIndex = 3;
            unfocuslab.Text = "Example : YourDrive:\\Program Files (x86)\\Steam\\userdata\\XXXXXXX\\2054970\\remote";
            // 
            // createBUbtn
            // 
            createBUbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createBUbtn.BackgroundImageLayout = ImageLayout.None;
            createBUbtn.FlatStyle = FlatStyle.Flat;
            createBUbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createBUbtn.Location = new Point(112, 201);
            createBUbtn.Name = "createBUbtn";
            createBUbtn.Size = new Size(100, 40);
            createBUbtn.TabIndex = 4;
            createBUbtn.Text = "Create Backup";
            createBUbtn.UseVisualStyleBackColor = true;
            createBUbtn.Click += createBUbtn_Click;
            // 
            // backupDirectory
            // 
            backupDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backupDirectory.BackColor = Color.FromArgb(64, 64, 64);
            backupDirectory.BorderStyle = BorderStyle.FixedSingle;
            backupDirectory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backupDirectory.ForeColor = Color.Silver;
            backupDirectory.Location = new Point(113, 71);
            backupDirectory.Margin = new Padding(5, 6, 5, 6);
            backupDirectory.Name = "backupDirectory";
            backupDirectory.Size = new Size(541, 25);
            backupDirectory.TabIndex = 8;
            backupDirectory.Text = " Select a folder to store backup";
            // 
            // backupathbtn
            // 
            backupathbtn.BackColor = Color.FromArgb(31, 31, 31);
            backupathbtn.BackgroundImageLayout = ImageLayout.None;
            backupathbtn.FlatStyle = FlatStyle.Flat;
            backupathbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backupathbtn.Location = new Point(7, 67);
            backupathbtn.Name = "backupathbtn";
            backupathbtn.Size = new Size(98, 32);
            backupathbtn.TabIndex = 9;
            backupathbtn.Text = "Backup Path";
            backupathbtn.UseVisualStyleBackColor = false;
            backupathbtn.Click += backupathbtn_Click;
            // 
            // LoadBUbtn
            // 
            LoadBUbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoadBUbtn.BackgroundImageLayout = ImageLayout.None;
            LoadBUbtn.FlatStyle = FlatStyle.Flat;
            LoadBUbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadBUbtn.Location = new Point(112, 249);
            LoadBUbtn.Margin = new Padding(3, 5, 3, 3);
            LoadBUbtn.Name = "LoadBUbtn";
            LoadBUbtn.Size = new Size(100, 40);
            LoadBUbtn.TabIndex = 10;
            LoadBUbtn.Text = "Load Backup";
            LoadBUbtn.UseVisualStyleBackColor = true;
            LoadBUbtn.Click += LoadBUbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(5, 113);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 12;
            label1.Text = "Name save file :";
            // 
            // savefilename
            // 
            savefilename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            savefilename.BackColor = Color.Gray;
            savefilename.BorderStyle = BorderStyle.FixedSingle;
            savefilename.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savefilename.ForeColor = Color.Silver;
            savefilename.Location = new Point(7, 135);
            savefilename.Margin = new Padding(5, 6, 5, 6);
            savefilename.MaxLength = 50;
            savefilename.Name = "savefilename";
            savefilename.Size = new Size(205, 25);
            savefilename.TabIndex = 11;
            // 
            // Newsavebtn
            // 
            Newsavebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Newsavebtn.BackgroundImageLayout = ImageLayout.None;
            Newsavebtn.FlatStyle = FlatStyle.Flat;
            Newsavebtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Newsavebtn.Location = new Point(112, 383);
            Newsavebtn.Margin = new Padding(3, 5, 3, 3);
            Newsavebtn.Name = "Newsavebtn";
            Newsavebtn.Size = new Size(100, 40);
            Newsavebtn.TabIndex = 13;
            Newsavebtn.Text = "New Save";
            Newsavebtn.UseVisualStyleBackColor = true;
            Newsavebtn.Click += button1_Click;
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            treeView1.BackColor = Color.FromArgb(64, 64, 64);
            treeView1.ForeColor = Color.Silver;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(219, 135);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 1;
            treeView1.Size = new Size(435, 288);
            treeView1.TabIndex = 15;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder.png");
            imageList1.Images.SetKeyName(1, "folderopen.png");
            // 
            // unfocusbutton
            // 
            unfocusbutton.FlatStyle = FlatStyle.Popup;
            unfocusbutton.ForeColor = Color.FromArgb(64, 64, 64);
            unfocusbutton.Location = new Point(750, 25);
            unfocusbutton.Name = "unfocusbutton";
            unfocusbutton.Size = new Size(15, 12);
            unfocusbutton.TabIndex = 0;
            unfocusbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(379, 113);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 16;
            label2.Text = "Available backup :";
            // 
            // Refreshbtn
            // 
            Refreshbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Refreshbtn.BackgroundImageLayout = ImageLayout.None;
            Refreshbtn.FlatStyle = FlatStyle.Flat;
            Refreshbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refreshbtn.Location = new Point(5, 383);
            Refreshbtn.Margin = new Padding(3, 5, 3, 3);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(100, 40);
            Refreshbtn.TabIndex = 17;
            Refreshbtn.Text = "Refresh Backup";
            Refreshbtn.UseVisualStyleBackColor = true;
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(112, 297);
            button1.Margin = new Padding(3, 5, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 18;
            button1.Text = "Delete Backup";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(664, 432);
            Controls.Add(button1);
            Controls.Add(Refreshbtn);
            Controls.Add(label2);
            Controls.Add(treeView1);
            Controls.Add(Newsavebtn);
            Controls.Add(label1);
            Controls.Add(savefilename);
            Controls.Add(LoadBUbtn);
            Controls.Add(backupathbtn);
            Controls.Add(backupDirectory);
            Controls.Add(createBUbtn);
            Controls.Add(unfocuslab);
            Controls.Add(steampathbtn);
            Controls.Add(textDirectory);
            Controls.Add(unfocusbutton);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Dragon's Dogma 2 Save Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textDirectory;
        private Button steampathbtn;
        private Label unfocuslab;
        private Button createBUbtn;
        private TextBox backupDirectory;
        private Button backupathbtn;
        private Button LoadBUbtn;
        private Label label1;
        private TextBox savefilename;
        private Button Newsavebtn;
        private TreeView treeView1;
        private Button unfocusbutton;
        private ImageList imageList1;
        private Label label2;
        private Button Refreshbtn;
        private Button button1;
    }
}
