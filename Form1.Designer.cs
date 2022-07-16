namespace lazyCopy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_index = new System.Windows.Forms.Label();
            this.listView_files = new System.Windows.Forms.ListView();
            this.columnHeader_file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_copy = new System.Windows.Forms.Button();
            this.textBox_directory = new System.Windows.Forms.TextBox();
            this.button_fileDirectory = new System.Windows.Forms.Button();
            this.textBox_filePairDirectory = new System.Windows.Forms.TextBox();
            this.button_filePair = new System.Windows.Forms.Button();
            this.numericUpDown_index = new System.Windows.Forms.NumericUpDown();
            this.button_remove = new System.Windows.Forms.Button();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.comboBox_savePath = new System.Windows.Forms.ComboBox();
            this.comboBox_destination = new System.Windows.Forms.ComboBox();
            this.button_savePath = new System.Windows.Forms.Button();
            this.button_destination = new System.Windows.Forms.Button();
            this.button_rename = new System.Windows.Forms.Button();
            this.label_fileType = new System.Windows.Forms.Label();
            this.textBox_fileType = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_insert = new System.Windows.Forms.TextBox();
            this.label_insert = new System.Windows.Forms.Label();
            this.listView_fileInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_removeList = new System.Windows.Forms.CheckBox();
            this.button_exitSave = new System.Windows.Forms.Button();
            this.checkBox_folder = new System.Windows.Forms.CheckBox();
            this.button_debug = new System.Windows.Forms.Button();
            this.checkBox_file = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_removeList = new System.Windows.Forms.TextBox();
            this.button_addRemoveList = new System.Windows.Forms.Button();
            this.button_removeRemoveList = new System.Windows.Forms.Button();
            this.button_showRemoveList = new System.Windows.Forms.Button();
            this.listView_message = new System.Windows.Forms.ListView();
            this.progressBar_file = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_index)).BeginInit();
            this.groupBox_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Key
            // 
            this.textBox_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Key.Location = new System.Drawing.Point(126, 22);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(365, 20);
            this.textBox_Key.TabIndex = 1;
            // 
            // label_firstName
            // 
            this.label_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_firstName.Location = new System.Drawing.Point(85, 12);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_firstName.Size = new System.Drawing.Size(35, 30);
            this.label_firstName.TabIndex = 3;
            this.label_firstName.Text = "Key";
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(302, 232);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(85, 29);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add / Update";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_index
            // 
            this.label_index.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_index.AutoSize = true;
            this.label_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_index.Location = new System.Drawing.Point(55, 102);
            this.label_index.Name = "label_index";
            this.label_index.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_index.Size = new System.Drawing.Size(65, 30);
            this.label_index.TabIndex = 8;
            this.label_index.Text = "Position";
            // 
            // listView_files
            // 
            this.listView_files.AllowColumnReorder = true;
            this.listView_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_file});
            this.listView_files.FullRowSelect = true;
            this.listView_files.HideSelection = false;
            this.listView_files.Location = new System.Drawing.Point(11, 45);
            this.listView_files.Name = "listView_files";
            this.listView_files.Size = new System.Drawing.Size(465, 407);
            this.listView_files.TabIndex = 12;
            this.listView_files.UseCompatibleStateImageBehavior = false;
            this.listView_files.View = System.Windows.Forms.View.Details;
            this.listView_files.SelectedIndexChanged += new System.EventHandler(this.listView_files_SelectedIndexChanged);
            // 
            // columnHeader_file
            // 
            this.columnHeader_file.Text = "File";
            this.columnHeader_file.Width = 600;
            // 
            // button_copy
            // 
            this.button_copy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_copy.Location = new System.Drawing.Point(8, 188);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(82, 39);
            this.button_copy.TabIndex = 13;
            this.button_copy.Text = "Copy/Move";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // textBox_directory
            // 
            this.textBox_directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_directory.Location = new System.Drawing.Point(100, 12);
            this.textBox_directory.Name = "textBox_directory";
            this.textBox_directory.Size = new System.Drawing.Size(515, 26);
            this.textBox_directory.TabIndex = 14;
            this.textBox_directory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_directory_KeyDown);
            // 
            // button_fileDirectory
            // 
            this.button_fileDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_fileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_fileDirectory.Location = new System.Drawing.Point(12, 10);
            this.button_fileDirectory.MaximumSize = new System.Drawing.Size(82, 30);
            this.button_fileDirectory.Name = "button_fileDirectory";
            this.button_fileDirectory.Size = new System.Drawing.Size(82, 30);
            this.button_fileDirectory.TabIndex = 15;
            this.button_fileDirectory.Text = "Directory";
            this.button_fileDirectory.UseVisualStyleBackColor = true;
            this.button_fileDirectory.Click += new System.EventHandler(this.button_directory_Click);
            // 
            // textBox_filePairDirectory
            // 
            this.textBox_filePairDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_filePairDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_filePairDirectory.Location = new System.Drawing.Point(621, 12);
            this.textBox_filePairDirectory.Name = "textBox_filePairDirectory";
            this.textBox_filePairDirectory.Size = new System.Drawing.Size(470, 26);
            this.textBox_filePairDirectory.TabIndex = 16;
            this.textBox_filePairDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_filePairDirectory_KeyDown);
            // 
            // button_filePair
            // 
            this.button_filePair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_filePair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_filePair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_filePair.Location = new System.Drawing.Point(1097, 10);
            this.button_filePair.MaximumSize = new System.Drawing.Size(82, 30);
            this.button_filePair.Name = "button_filePair";
            this.button_filePair.Size = new System.Drawing.Size(82, 30);
            this.button_filePair.TabIndex = 17;
            this.button_filePair.Text = "File";
            this.button_filePair.UseVisualStyleBackColor = true;
            this.button_filePair.Click += new System.EventHandler(this.button_filePair_Click);
            // 
            // numericUpDown_index
            // 
            this.numericUpDown_index.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_index.Location = new System.Drawing.Point(126, 112);
            this.numericUpDown_index.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_index.Name = "numericUpDown_index";
            this.numericUpDown_index.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_index.TabIndex = 18;
            this.numericUpDown_index.ValueChanged += new System.EventHandler(this.numericUpDown_index_ValueChanged);
            // 
            // button_remove
            // 
            this.button_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_remove.Location = new System.Drawing.Point(393, 232);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(85, 29);
            this.button_remove.TabIndex = 19;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // groupBox_info
            // 
            this.groupBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_info.Controls.Add(this.comboBox_savePath);
            this.groupBox_info.Controls.Add(this.comboBox_destination);
            this.groupBox_info.Controls.Add(this.button_savePath);
            this.groupBox_info.Controls.Add(this.button_destination);
            this.groupBox_info.Controls.Add(this.button_rename);
            this.groupBox_info.Controls.Add(this.label_fileType);
            this.groupBox_info.Controls.Add(this.textBox_fileType);
            this.groupBox_info.Controls.Add(this.button_clear);
            this.groupBox_info.Controls.Add(this.textBox_insert);
            this.groupBox_info.Controls.Add(this.label_insert);
            this.groupBox_info.Controls.Add(this.label_firstName);
            this.groupBox_info.Controls.Add(this.textBox_Key);
            this.groupBox_info.Controls.Add(this.button_remove);
            this.groupBox_info.Controls.Add(this.numericUpDown_index);
            this.groupBox_info.Controls.Add(this.label_index);
            this.groupBox_info.Controls.Add(this.button_add);
            this.groupBox_info.Location = new System.Drawing.Point(11, 458);
            this.groupBox_info.MinimumSize = new System.Drawing.Size(0, 191);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(497, 278);
            this.groupBox_info.TabIndex = 21;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Info";
            // 
            // comboBox_savePath
            // 
            this.comboBox_savePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox_savePath.FormattingEnabled = true;
            this.comboBox_savePath.Location = new System.Drawing.Point(126, 138);
            this.comboBox_savePath.Name = "comboBox_savePath";
            this.comboBox_savePath.Size = new System.Drawing.Size(362, 24);
            this.comboBox_savePath.TabIndex = 33;
            // 
            // comboBox_destination
            // 
            this.comboBox_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox_destination.FormattingEnabled = true;
            this.comboBox_destination.Location = new System.Drawing.Point(126, 52);
            this.comboBox_destination.Name = "comboBox_destination";
            this.comboBox_destination.Size = new System.Drawing.Size(362, 24);
            this.comboBox_destination.TabIndex = 32;
            // 
            // button_savePath
            // 
            this.button_savePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_savePath.Location = new System.Drawing.Point(6, 135);
            this.button_savePath.Name = "button_savePath";
            this.button_savePath.Size = new System.Drawing.Size(114, 29);
            this.button_savePath.TabIndex = 31;
            this.button_savePath.Text = "Save Path";
            this.button_savePath.UseVisualStyleBackColor = true;
            this.button_savePath.Click += new System.EventHandler(this.button_savePath_Click);
            // 
            // button_destination
            // 
            this.button_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_destination.Location = new System.Drawing.Point(9, 48);
            this.button_destination.Name = "button_destination";
            this.button_destination.Size = new System.Drawing.Size(114, 29);
            this.button_destination.TabIndex = 30;
            this.button_destination.Text = "Destination";
            this.button_destination.UseVisualStyleBackColor = true;
            this.button_destination.Click += new System.EventHandler(this.button_destination_Click);
            // 
            // button_rename
            // 
            this.button_rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rename.Location = new System.Drawing.Point(120, 231);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(85, 29);
            this.button_rename.TabIndex = 25;
            this.button_rename.Text = "Rename";
            this.button_rename.UseVisualStyleBackColor = true;
            this.button_rename.Click += new System.EventHandler(this.button_rename_Click);
            // 
            // label_fileType
            // 
            this.label_fileType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fileType.AutoSize = true;
            this.label_fileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_fileType.Location = new System.Drawing.Point(48, 162);
            this.label_fileType.Name = "label_fileType";
            this.label_fileType.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_fileType.Size = new System.Drawing.Size(72, 40);
            this.label_fileType.TabIndex = 24;
            this.label_fileType.Text = "File Type";
            // 
            // textBox_fileType
            // 
            this.textBox_fileType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_fileType.Location = new System.Drawing.Point(126, 170);
            this.textBox_fileType.Name = "textBox_fileType";
            this.textBox_fileType.Size = new System.Drawing.Size(365, 23);
            this.textBox_fileType.TabIndex = 23;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(211, 232);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 29);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_insert
            // 
            this.textBox_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_insert.Location = new System.Drawing.Point(126, 82);
            this.textBox_insert.Name = "textBox_insert";
            this.textBox_insert.Size = new System.Drawing.Size(365, 20);
            this.textBox_insert.TabIndex = 21;
            // 
            // label_insert
            // 
            this.label_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_insert.AutoSize = true;
            this.label_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label_insert.Location = new System.Drawing.Point(31, 72);
            this.label_insert.Name = "label_insert";
            this.label_insert.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label_insert.Size = new System.Drawing.Size(92, 30);
            this.label_insert.TabIndex = 20;
            this.label_insert.Text = "Insert Word";
            // 
            // listView_fileInfo
            // 
            this.listView_fileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_fileInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_fileInfo.FullRowSelect = true;
            this.listView_fileInfo.HideSelection = false;
            this.listView_fileInfo.Location = new System.Drawing.Point(482, 45);
            this.listView_fileInfo.MultiSelect = false;
            this.listView_fileInfo.Name = "listView_fileInfo";
            this.listView_fileInfo.Size = new System.Drawing.Size(698, 407);
            this.listView_fileInfo.TabIndex = 23;
            this.listView_fileInfo.UseCompatibleStateImageBehavior = false;
            this.listView_fileInfo.View = System.Windows.Forms.View.Details;
            this.listView_fileInfo.SelectedIndexChanged += new System.EventHandler(this.listView_fileInfo_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Destination";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Position";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Save Path";
            this.columnHeader4.Width = 164;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "insert";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "File Type";
            this.columnHeader6.Width = 155;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBox_removeList);
            this.groupBox1.Controls.Add(this.button_exitSave);
            this.groupBox1.Controls.Add(this.checkBox_folder);
            this.groupBox1.Controls.Add(this.button_debug);
            this.groupBox1.Controls.Add(this.checkBox_file);
            this.groupBox1.Controls.Add(this.button_copy);
            this.groupBox1.Location = new System.Drawing.Point(513, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 278);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show";
            // 
            // checkBox_removeList
            // 
            this.checkBox_removeList.AutoSize = true;
            this.checkBox_removeList.Checked = true;
            this.checkBox_removeList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_removeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.checkBox_removeList.Location = new System.Drawing.Point(10, 68);
            this.checkBox_removeList.Name = "checkBox_removeList";
            this.checkBox_removeList.Size = new System.Drawing.Size(91, 19);
            this.checkBox_removeList.TabIndex = 27;
            this.checkBox_removeList.Text = "RemoveList";
            this.checkBox_removeList.UseVisualStyleBackColor = true;
            // 
            // button_exitSave
            // 
            this.button_exitSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_exitSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button_exitSave.Location = new System.Drawing.Point(8, 233);
            this.button_exitSave.Name = "button_exitSave";
            this.button_exitSave.Size = new System.Drawing.Size(82, 39);
            this.button_exitSave.TabIndex = 26;
            this.button_exitSave.Text = "Exit/Save";
            this.button_exitSave.UseVisualStyleBackColor = true;
            this.button_exitSave.Click += new System.EventHandler(this.button_exitSave_Click);
            // 
            // checkBox_folder
            // 
            this.checkBox_folder.AutoSize = true;
            this.checkBox_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.checkBox_folder.Location = new System.Drawing.Point(10, 46);
            this.checkBox_folder.Name = "checkBox_folder";
            this.checkBox_folder.Size = new System.Drawing.Size(61, 19);
            this.checkBox_folder.TabIndex = 1;
            this.checkBox_folder.Text = "Folder";
            this.checkBox_folder.UseVisualStyleBackColor = true;
            this.checkBox_folder.CheckedChanged += new System.EventHandler(this.checkBox_folder_CheckedChanged);
            // 
            // button_debug
            // 
            this.button_debug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_debug.Location = new System.Drawing.Point(8, 153);
            this.button_debug.Name = "button_debug";
            this.button_debug.Size = new System.Drawing.Size(82, 29);
            this.button_debug.TabIndex = 25;
            this.button_debug.Text = "Debug";
            this.button_debug.UseVisualStyleBackColor = true;
            this.button_debug.Visible = false;
            this.button_debug.Click += new System.EventHandler(this.button_debug_Click);
            // 
            // checkBox_file
            // 
            this.checkBox_file.AutoSize = true;
            this.checkBox_file.Checked = true;
            this.checkBox_file.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.checkBox_file.Location = new System.Drawing.Point(10, 25);
            this.checkBox_file.Name = "checkBox_file";
            this.checkBox_file.Size = new System.Drawing.Size(46, 19);
            this.checkBox_file.TabIndex = 0;
            this.checkBox_file.Text = "File";
            this.checkBox_file.UseVisualStyleBackColor = true;
            this.checkBox_file.CheckedChanged += new System.EventHandler(this.checkBox_file_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.textBox_removeList);
            this.groupBox2.Controls.Add(this.button_addRemoveList);
            this.groupBox2.Controls.Add(this.button_removeRemoveList);
            this.groupBox2.Controls.Add(this.button_showRemoveList);
            this.groupBox2.Location = new System.Drawing.Point(626, 687);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 58);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove List";
            // 
            // textBox_removeList
            // 
            this.textBox_removeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox_removeList.Location = new System.Drawing.Point(84, 20);
            this.textBox_removeList.Name = "textBox_removeList";
            this.textBox_removeList.Size = new System.Drawing.Size(300, 26);
            this.textBox_removeList.TabIndex = 17;
            // 
            // button_addRemoveList
            // 
            this.button_addRemoveList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_addRemoveList.Location = new System.Drawing.Point(391, 20);
            this.button_addRemoveList.Name = "button_addRemoveList";
            this.button_addRemoveList.Size = new System.Drawing.Size(72, 29);
            this.button_addRemoveList.TabIndex = 16;
            this.button_addRemoveList.Text = "Add";
            this.button_addRemoveList.UseVisualStyleBackColor = true;
            this.button_addRemoveList.Click += new System.EventHandler(this.button_addRemoveList_Click);
            // 
            // button_removeRemoveList
            // 
            this.button_removeRemoveList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_removeRemoveList.Location = new System.Drawing.Point(469, 20);
            this.button_removeRemoveList.Name = "button_removeRemoveList";
            this.button_removeRemoveList.Size = new System.Drawing.Size(72, 29);
            this.button_removeRemoveList.TabIndex = 15;
            this.button_removeRemoveList.Text = "Remove";
            this.button_removeRemoveList.UseVisualStyleBackColor = true;
            this.button_removeRemoveList.Click += new System.EventHandler(this.button_removeRemoveList_Click);
            // 
            // button_showRemoveList
            // 
            this.button_showRemoveList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_showRemoveList.Location = new System.Drawing.Point(6, 20);
            this.button_showRemoveList.Name = "button_showRemoveList";
            this.button_showRemoveList.Size = new System.Drawing.Size(72, 29);
            this.button_showRemoveList.TabIndex = 14;
            this.button_showRemoveList.Text = "Show";
            this.button_showRemoveList.UseVisualStyleBackColor = true;
            this.button_showRemoveList.Click += new System.EventHandler(this.button_showRemoveList_Click);
            // 
            // listView_message
            // 
            this.listView_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_message.Enabled = false;
            this.listView_message.FullRowSelect = true;
            this.listView_message.HideSelection = false;
            this.listView_message.Location = new System.Drawing.Point(626, 458);
            this.listView_message.MinimumSize = new System.Drawing.Size(552, 189);
            this.listView_message.MultiSelect = false;
            this.listView_message.Name = "listView_message";
            this.listView_message.Size = new System.Drawing.Size(553, 193);
            this.listView_message.TabIndex = 27;
            this.listView_message.Tag = "";
            this.listView_message.UseCompatibleStateImageBehavior = false;
            this.listView_message.View = System.Windows.Forms.View.Details;
            this.listView_message.SelectedIndexChanged += new System.EventHandler(this.listView_message_SelectedIndexChanged);
            // 
            // progressBar_file
            // 
            this.progressBar_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar_file.Location = new System.Drawing.Point(626, 658);
            this.progressBar_file.Name = "progressBar_file";
            this.progressBar_file.Size = new System.Drawing.Size(553, 23);
            this.progressBar_file.TabIndex = 29;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1193, 745);
            this.Controls.Add(this.progressBar_file);
            this.Controls.Add(this.listView_message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_fileInfo);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.button_filePair);
            this.Controls.Add(this.textBox_filePairDirectory);
            this.Controls.Add(this.button_fileDirectory);
            this.Controls.Add(this.textBox_directory);
            this.Controls.Add(this.listView_files);
            this.MinimumSize = new System.Drawing.Size(1209, 784);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_index)).EndInit();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_index;
        private System.Windows.Forms.ListView listView_files;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.TextBox textBox_directory;
        private System.Windows.Forms.Button button_fileDirectory;
        private System.Windows.Forms.TextBox textBox_filePairDirectory;
        private System.Windows.Forms.Button button_filePair;
        private System.Windows.Forms.ColumnHeader columnHeader_file;
        private System.Windows.Forms.NumericUpDown numericUpDown_index;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.ListView listView_fileInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label_insert;
        private System.Windows.Forms.TextBox textBox_insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_folder;
        private System.Windows.Forms.CheckBox checkBox_file;
        private System.Windows.Forms.Button button_debug;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_exitSave;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox checkBox_removeList;
        private System.Windows.Forms.Label label_fileType;
        private System.Windows.Forms.TextBox textBox_fileType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_removeList;
        private System.Windows.Forms.Button button_addRemoveList;
        private System.Windows.Forms.Button button_removeRemoveList;
        private System.Windows.Forms.Button button_showRemoveList;
        private System.Windows.Forms.Button button_rename;
        private System.Windows.Forms.ListView listView_message;
        private System.Windows.Forms.ProgressBar progressBar_file;
        private System.Windows.Forms.Button button_savePath;
        private System.Windows.Forms.Button button_destination;
        private System.Windows.Forms.ComboBox comboBox_destination;
        private System.Windows.Forms.ComboBox comboBox_savePath;
    }
}

