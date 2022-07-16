using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace lazyCopy
{
    // todo: error for invalid file format
    //      rename with multple file selected: name not update from key if only one selected
    //      progree bar
    public partial class Form1 : Form
    {
        static bool debug = false;//    show each action using which functions
        static string directoryName = @"";// key and file information path
        static string sourceDir = @"";// target folder path
        static Dictionary<string, FileData> fileInfoes = new Dictionary<string, FileData>();//   filePair
        static List<string> removelist = new List<string>();
        string[] files = { };//  list for the file in the folder

        struct FileData
        {
            public string destination;
            public string insert;
            public string index;
            public string savePath;
            public string fileType;
        };

        public Form1()
        {
            InitializeComponent();

            //  read if there is a defaultPath
            bool found = false;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\defaultPath.txt"))
            {
                string[] path = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + "\\defaultPath.txt");
                directoryName = path[0];
                found = true;
            }
            else
            {
                addMessageToListViewMessage("file not found", true);
            }

            if( found == true)
            {
                //  get file pair data
                ReadFile();

                //  load target folder file
                ReadFolder();

                //  load listView_message for removeList
                loadListViewRemove();
            }
        }
        
        // load key and file information
        private void ReadFile()
        {
            if (debug)
            {
                addMessageToListViewMessage("ReadFile()", false);
            }

            if(directoryName != "")
            {
                string[] filePairInfo = System.IO.File.ReadAllLines(directoryName);
                string[] subString = { };

                for (int i = 0; i < filePairInfo.Length; i++)
                {
                    if (filePairInfo[i].Contains("[folder Info]"))
                    {// get directory, source firectory,... data
                        //  directory
                        subString = filePairInfo[++i].Split(':');
                        textBox_filePairDirectory.Text = subString[1];
                        Array.Clear(subString, 0, subString.Length);//  clear the array for next line

                        //  source directory
                        subString = filePairInfo[++i].Split(':');
                        sourceDir = textBox_directory.Text = subString[1];
                        ReadFolder();
                        Array.Clear(subString, 0, subString.Length);//  clear the array for next line

                        //  remove list
                        subString = filePairInfo[++i].Split(':');
                        string[] subtitleSubString = subString[1].Split('*');

                        removelist = subtitleSubString.ToList();
                        Array.Clear(subtitleSubString, 0, subtitleSubString.Length);

                        //  pre-set path
                        subString = filePairInfo[++i].Split(':');
                        subtitleSubString = subString[1].Split('*');

                        //preSetList = subtitleSubString.ToList();
                        foreach(string subtitleSub in subtitleSubString)
                        {
                            comboBox_destination.Items.Add(subtitleSub);
                            comboBox_savePath.Items.Add(subtitleSub);
                        }
                        continue;
                    }

                    if (filePairInfo[i].Contains("[Events]"))
                    {// skip to the file pair data
                        i += 1;
                        continue;
                    }

                    if (!string.IsNullOrEmpty(filePairInfo[i]))
                    {
                        subString = filePairInfo[i].Split('*');

                        FileData tamp = new FileData();
                        ListViewItem item = new ListViewItem(subString[0]);

                        item.SubItems.Add(tamp.destination = subString[1]);
                        item.SubItems.Add(tamp.index = subString[3]);
                        item.SubItems.Add(tamp.savePath = subString[4]);
                        item.SubItems.Add(tamp.insert = subString[2]);
                        item.SubItems.Add(tamp.fileType = subString[5]);

                        //  add to fileInfoes and listView
                        fileInfoes.Add(subString[0], tamp);
                        listView_fileInfo.Items.Add(item);

                        Array.Clear(subString, 0, subString.Length);//  clear the array for next line
                    }
                }
            }
        }
        
        // load file list
        private void ReadFolder()
        {
            if (debug)
            {
                addMessageToListViewMessage("ReadFolder()", false);
            }

            if (textBox_directory.Text != "")
            {
                listView_files.Items.Clear();

                if (checkBox_file.Checked)
                {
                    files = Directory.GetFiles(textBox_directory.Text);//  only file

                    foreach (string file in files)
                    {// list file in the target folder
                        ListViewItem item = new ListViewItem();
                        string fName = file.Substring((textBox_directory.Text).Length);// Remove path from the file name.

                        item.Text = fName;
                        listView_files.Items.Add(item);
                    }
                }

                if (checkBox_folder.Checked)
                {
                    string[] folders = Directory.GetDirectories(textBox_directory.Text);//  only file

                    foreach (string folder in folders)
                    {// list file in the target folder
                        ListViewItem item = new ListViewItem();
                        string fName = folder.Substring((textBox_directory.Text).Length);// Remove path from the folder name.
                        item.Text = fName;
                        listView_files.Items.Add(item);
                    }
                }
            }
        }

        //  load listView_removeList
        private void loadListViewRemove()
        {
            if(listView_message.Columns.Count > 0)
            {//  add column for remove 
                if (listView_message.Columns[0].Text != "Remove List")
                {
                    listView_message.Columns.Clear();
                    listView_message.Columns.Insert(0, "Remove List");
                }
            }
            else
            {
                listView_message.Columns.Insert(0, "Remove List");
            }

            listView_message.Enabled = true;
            listView_message.Columns[0].Width = listView_message.MinimumSize.Width;

            foreach ( string remove in removelist)
            {// load all remove list
                listView_message.Items.Add(remove);
            }
        }

        private void updateListViewFileInfo()
        {
            if (debug)
            {
                addMessageToListViewMessage("updateListViewFileInfo()", false);
            }

            listView_fileInfo.Items.Clear();

            foreach (var fileInfo in fileInfoes)
            {
                ListViewItem item = new ListViewItem(fileInfo.Key);
                item.SubItems.Add(fileInfo.Value.destination);
                item.SubItems.Add(fileInfo.Value.index);
                item.SubItems.Add(fileInfo.Value.savePath);
                item.SubItems.Add(fileInfo.Value.insert);
                item.SubItems.Add(fileInfo.Value.fileType);

                listView_fileInfo.Items.Add(item);
            }

            fileInfoes.OrderBy(key => key.Key);
        }

        private void updateListViewFiles(ListView.SelectedListViewItemCollection selectedList)
        {
            if (debug)
            {
                addMessageToListViewMessage("updateListViewFiles()", false);
            }

            List<string> tampSelectedList = new List<string>();//   save selected list before listView_files clear

            foreach (ListViewItem listview in selectedList)
            {
                tampSelectedList.Add(listview.Text);
            }

            if (checkBox_file.Checked)
            {
                foreach (ListViewItem item in listView_files.Items)
                {// loop though listview_file item
                    bool fileSelected = false;
                 //textBox_message.AppendText( item.Index + ": " + item.Text + Environment.NewLine);
                 
                    foreach (string tampSelected in tampSelectedList)
                    {// update the item name if it is selected
                        if ( item.Text == tampSelected)
                        {// file in selected list
                            item.Text = findUpdatedName(files[item.Index].Substring((textBox_directory.Text).Length));

                            //addMessageToListViewMessage(item.Text, true);
                            fileSelected = true;
                            break;
                        }
                    }

                    if (files[item.Index].Substring((textBox_directory.Text).Length) != item.Text && fileSelected == false)
                    {// if listView item name is updated, rename it back
                        item.Text = files[item.Index].Substring((textBox_directory.Text).Length);
                    }
                }
            }
        }

        //  update name for listView_file
        private string findUpdatedName(string sourceName)
        {
            if (debug)
            {
                addMessageToListViewMessage("findUpdatedName()", false);
            }

            //  finding filePair match
            //  check if find in fileInfoes
            foreach (KeyValuePair<string, FileData> fileInfo in fileInfoes)
            {
                if (sourceName.Contains(fileInfo.Key))
                {
                    string[] file_extension = sourceName.Split('.');

                    if( file_extension.Last() == fileInfo.Value.fileType)
                    {
                        if(checkBox_removeList.Checked)
                        {
                            //  update file name using removelist
                            foreach (string subtitle in removelist)
                            {// find which string to remove
                                sourceName = sourceName.Replace(subtitle, "");
                            }
                        }

                        //  move file with season
                        if (fileInfo.Value.index != "N/A")
                        {
                            if (!sourceName.Contains(fileInfo.Value.insert))
                            {// add the seasonOrType if it is not there
                                int index = Convert.ToInt32(fileInfo.Value.index);
                                sourceName = sourceName.Insert(index, fileInfo.Value.insert);
                            }
                            break;
                        }
                    }
                }
            }
            return sourceName;
        }

        //  empty all textBox
        private void emptyInfoTextBox()
        {
            if (debug)
            {
                addMessageToListViewMessage("emptyInfoTextBox()", false);
            }

            textBox_Key.Text = "";
            comboBox_destination.Text = "";
            textBox_insert.Text = "";
            numericUpDown_index.Text = "0";
            comboBox_savePath.Text = "";
            textBox_fileType.Text = "";
        }

        //  add message to textBox_message
        private void addMessageToListViewMessage(string message, bool red)
        {
            if( listView_message.Columns.Count > 0)
            {
                if (listView_message.Columns[0].Text != "Message")
                {
                    listView_message.Clear();
                    listView_message.Columns.Insert(0, "Message");
                    listView_message.Columns[0].Width = listView_message.Width;
                    listView_message.Enabled = true;
                }
            }
            listView_message.Items.Add(message);

            if(red == true)
            {
                listView_message.Items[listView_message.Items.Count-1].ForeColor = Color.Red;
            }
            
            listView_message.Items[listView_message.Items.Count - 1].EnsureVisible();
        }

        //  empty everything for new file
        private void reset()
        {
            fileInfoes.Clear();
            removelist.Clear();

            listView_files.Items.Clear();
            listView_fileInfo.Items.Clear();
            listView_message.Clear();
        }

        // add or update key and file information
        private bool addFilePair()
        {
            //  check if any text box empty
            if (!String.IsNullOrEmpty(textBox_Key.Text) &&
                !String.IsNullOrEmpty(comboBox_destination.Text) &&
                !String.IsNullOrEmpty(textBox_insert.Text) &&
                !String.IsNullOrEmpty(numericUpDown_index.Text) &&
                !String.IsNullOrEmpty(comboBox_savePath.Text) &&
                !String.IsNullOrEmpty(textBox_fileType.Text))
            {

                FileData fileTamp = new FileData();
                fileTamp.destination = comboBox_destination.Text;
                fileTamp.insert = textBox_insert.Text;
                fileTamp.fileType = textBox_fileType.Text;

                if (numericUpDown_index.Text == "0")
                {
                    fileTamp.index = "N/A";
                }
                else
                {
                    fileTamp.index = numericUpDown_index.Text;
                }

                fileTamp.savePath = comboBox_savePath.Text;

                //  remove the old key
                if (listView_fileInfo.SelectedItems.Count == 0 || listView_fileInfo.SelectedItems[0].Text != textBox_Key.Text)
                {
                    fileInfoes.Remove(textBox_Key.Text);
                }
                else
                {
                    fileInfoes.Remove(listView_fileInfo.SelectedItems[0].Text);
                }

                // add the new key
                fileInfoes.Add(textBox_Key.Text, fileTamp);

                //  update listView_fileInfo
                updateListViewFileInfo();

                //  empty all textbox
                emptyInfoTextBox();
            }
            else
            {
                if (String.IsNullOrEmpty(textBox_Key.Text))
                {
                    addMessageToListViewMessage("Empty Key", true);
                }

                if (String.IsNullOrEmpty(comboBox_destination.Text))
                {
                    addMessageToListViewMessage("Empty Destination", true);
                }

                if (String.IsNullOrEmpty(textBox_insert.Text))
                {
                    addMessageToListViewMessage("Empty Insert", true);
                }

                if (String.IsNullOrEmpty(comboBox_savePath.Text))
                {
                    addMessageToListViewMessage("Empty Save Path", true);
                }

                if (String.IsNullOrEmpty(textBox_fileType.Text))
                {
                    addMessageToListViewMessage("Empty File Type", true);
                }
            }

            return true;
        }
//  listView_files
        // udpate folder pair list box
        private void listView_fileInfo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("listView_fileInfo_SelectedIndexChanged_1()", false);
            }

            if (listView_fileInfo.SelectedItems.Count == 1)
            {//  load the selected item to textbox for update
                textBox_Key.Text = listView_fileInfo.SelectedItems[0].Text;
                comboBox_destination.Text = listView_fileInfo.SelectedItems[0].SubItems[1].Text;
                numericUpDown_index.Text = listView_fileInfo.SelectedItems[0].SubItems[2].Text;
                comboBox_savePath.Text = listView_fileInfo.SelectedItems[0].SubItems[3].Text;
                textBox_insert.Text = listView_fileInfo.SelectedItems[0].SubItems[4].Text;
                textBox_fileType.Text = listView_fileInfo.SelectedItems[0].SubItems[5].Text;
            }
            else
            {// empty info textbox if no selection make
                emptyInfoTextBox();
            }
        }

        // add new file key from target folder
        private void listView_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("listView_files_SelectedIndexChanged()", true);
                addMessageToListViewMessage("listView_files.SelectedItems.Count: " + listView_files.SelectedItems.Count, true);
            }

            updateListViewFiles(listView_files.SelectedItems);// update listView_files

            if (listView_files.SelectedItems.Count == 1)
            {// allow changing position while updated in listView_file
                bool found = false;
                int index = 0;
                string[] file_extension = (listView_files.SelectedItems[0].Text).Split('.');

                foreach (KeyValuePair<string, FileData> fileInfo in fileInfoes)
                {//  find the file pair that fit the selected item
                    if ((listView_files.SelectedItems[0].Text).Contains(fileInfo.Key) && file_extension.Last() == fileInfo.Value.fileType)
                    {//  matched
                        // load the textBox for the info
                        textBox_Key.Text = fileInfo.Key;
                        comboBox_destination.Text = fileInfo.Value.destination;
                        textBox_insert.Text = fileInfo.Value.insert;
                        numericUpDown_index.Text = fileInfo.Value.index;
                        comboBox_savePath.Text = fileInfo.Value.savePath;
                        textBox_fileType.Text = fileInfo.Value.fileType;
                        found = true;// for empty the textbox

                        //  highlight key 
                        //listView_fileInfo.Items[index].Selected = true;
                        break;
                    }
                    index++;
                }

                if (found == false)
                {
                    textBox_Key.Text = listView_files.SelectedItems[0].Text;
                    comboBox_destination.Text = "N/A";
                    textBox_insert.Text = "N/A";
                    numericUpDown_index.Text = "0";
                    comboBox_savePath.Text = "N/A";

                    textBox_fileType.Text = file_extension.Last();
                }
            }
            else
            {// empty info textbox if no selection make
                emptyInfoTextBox();
            }
        }

        //  message or remove list
        private void listView_message_SelectedIndexChanged(object sender, EventArgs e)
        {// load remove textbox if colume == "Remove List"
            if(listView_message.Columns[0].Text == "Remove List")
            {
                if (listView_message.SelectedItems.Count == 1)
                {
                    textBox_removeList.Text = listView_message.SelectedItems[0].Text;
                }
            }
        }

//  button
        //  button for testing
        //private async void button_debug_Click(object sender, EventArgs e)
        private void button_debug_Click(object sender, EventArgs e)
        {
            addMessageToListViewMessage("button_debug_Click()", false);
            addMessageToListViewMessage(sourceDir, false);
            /*
            Task<bool> task = new Task<bool>(() => IsPrime(button_add_Click )));

            task.Start();

            bool done = await task;
            button_add_Click(sender, e);*/
        }
        
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_remove_Click()", false);
            }

            fileInfoes.Remove(listView_fileInfo.SelectedItems[0].Text);

            updateListViewFileInfo();
        }

        // moving file to destination folder
        private void button_copy_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_copy_Click()", false);
            }
            //foreach (ListViewItem item in listView_files.Items)
            //  loop the selected item in listViem_files
            for( int i = 0; i < listView_files.SelectedItems.Count; i++)
            {// loop selected file
                string[] file_extension = (listView_files.SelectedItems[i].Text).Split('.');
                //addMessageToListViewMessage(listView_files.SelectedItems[i].Index.ToString());
                
                foreach (KeyValuePair<string, FileData> fileInfo in fileInfoes)
                {// loop every key
                    if ((listView_files.SelectedItems[i].ToString()).Contains(fileInfo.Key) && file_extension.Last() == fileInfo.Value.fileType)
                    { //  find the key for it
                        //  use the listView name for final name
                        addMessageToListViewMessage(listView_files.SelectedItems[i].Text + " Move", false);

                        if(listView_files.SelectedItems[i].ToString() != files[listView_files.SelectedItems[i].Index].ToString())
                        {// file need to rename before copy
                            File.Move(files[listView_files.SelectedItems[i].Index].ToString(), sourceDir + listView_files.SelectedItems[i].Text);
                        }

                        if ( (fileInfo.Value.index == "N/A" && fileInfo.Value.insert != "N/A") || (fileInfo.Value.index != "N/A" && fileInfo.Value.insert == "N/A") )
                        {// file that index have to update
                            addMessageToListViewMessage("Need To Update Index for " + listView_files.SelectedItems[i].Text, true);
                        }

                        //  copy the file to destination: get the file name form files[selected index] for old name
                        if (!Directory.Exists(fileInfo.Value.destination))
                        {// create folder if not exists 
                            Directory.CreateDirectory(fileInfo.Value.destination);
                        }

                        File.Copy( (sourceDir + listView_files.SelectedItems[i].Text), (fileInfo.Value.destination + "\\" + listView_files.SelectedItems[i].Text), true);

                        //  move the file to savePath
                        if (fileInfo.Value.savePath != "N/A")
                        {// move file
                            if (!Directory.Exists(fileInfo.Value.savePath))
                            {// create folder if not exists 
                                Directory.CreateDirectory(fileInfo.Value.savePath);
                            }

                            if (File.Exists(fileInfo.Value.savePath + "\\" + listView_files.SelectedItems[i].Text))
                            {// // Ensure that the target does not exist.
                                File.Delete(fileInfo.Value.savePath + "\\" + listView_files.SelectedItems[i].Text);
                            }

                            File.Move(sourceDir + listView_files.SelectedItems[i].Text, fileInfo.Value.savePath + "\\" + listView_files.SelectedItems[i].Text);
                        }
                    }
                }//foreach (var fileInfo in fileInfoes)
            }//foreach(ListView.SelectedListViewItemCollection select in listView_files.SelectedItems)

            addMessageToListViewMessage("", false);
            addMessageToListViewMessage("Done...", false);
            ReadFolder();
        }
        
        private void button_add_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_add_Click()", false);
            }
            addFilePair();
        }

        // clear all textbox
        private void button_clear_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_clear_Click()", false);
            }

            emptyInfoTextBox();
        }

        // enter target directory
        private void button_directory_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_directory_Click()", false);
            }

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_directory.Text = folderDlg.SelectedPath;
                //Environment.SpecialFolder root = folderDlg.RootFolder;

                //  load file to list view (listView_files)
                ReadFolder();
            }
        }

        //  get file path
        private void button_filePair_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_filePair_Click()", false);
            }

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = @"c:\";//   default c drive directory

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                reset();
                directoryName = fdlg.FileName;
                ReadFile();
            }
        }

        // save file pair and exit
        private void button_exitSave_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_exitSave_Click()", false);
            }
            //  save the path for next time 
            //Directory.GetCurrentDirectory() + "/defaultPath.txt"
            using (StreamWriter outputFile = new StreamWriter(Directory.GetCurrentDirectory() + "/defaultPath.txt"))
            {
                outputFile.WriteLine(textBox_filePairDirectory.Text);

            }

            //  save the data
            using (StreamWriter outputFile = new StreamWriter(textBox_filePairDirectory.Text))
            {
                outputFile.WriteLine("[folder Info]");

                outputFile.WriteLine("directoryName:" + textBox_filePairDirectory.Text);
                outputFile.WriteLine("sourceDir:" + textBox_directory.Text);
                outputFile.Write("removelist:");
                for (int i = 0; i < (removelist.Count) - 1; i++)
                {
                    outputFile.Write(removelist[i] + "*");
                }
                outputFile.WriteLine(removelist[removelist.Count - 1]);

                outputFile.Write("pre - set path:");
                for (int i = 0; i < comboBox_destination.Items.Count - 1; i++)
                {
                    outputFile.Write(comboBox_destination.Items[i] + "*");
                }
                outputFile.WriteLine(comboBox_destination.Items[comboBox_destination.Items.Count - 1]);


                outputFile.WriteLine();
                outputFile.WriteLine("[Events]");
                outputFile.WriteLine("Format: Key, Destination, Insert, Index, SavePath, Type");

                foreach (KeyValuePair<string, FileData> line in fileInfoes)
                {
                    outputFile.WriteLine(line.Key + "*" + line.Value.destination + "*" + line.Value.insert + "*" +
                        line.Value.index + "*" + line.Value.savePath + "*" + line.Value.fileType);
                }
            }
            Application.Exit();
        }

        private void button_showRemoveList_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_showRemoveList_Click()", false);
            }

            if (listView_message.Columns.Count > 0)
            {
                if (listView_message.Columns[0].Text != "Remove List")
                {
                    listView_message.Clear();
                    listView_message.Columns.Insert(0, "Remove List");
                    listView_message.Columns[0].Width = listView_message.MinimumSize.Width;
                    listView_message.Enabled = true;

                    //  liset the remove list to listView_files
                    loadListViewRemove();
                }
            }
        }

        //  remove item from remove list
        private void button_removeRemoveList_Click(object sender, EventArgs e)
        {
            if (listView_message.Columns[0].Text == "Remove List")
            {
                if (listView_message.SelectedItems.Count == 1)
                {
                    removelist.Remove(listView_message.SelectedItems[0].Text);
                    listView_message.Items.RemoveAt(listView_message.SelectedItems[0].Index);
                    textBox_removeList.Text = "";
                }
            }
        }

        //  add item to remove list
        private void button_addRemoveList_Click(object sender, EventArgs e)
        {
            removelist.Add(textBox_removeList.Text);

            textBox_removeList.Text = "";

            listView_message.Clear();
            loadListViewRemove();
        }

        //  rename file name
        private void button_rename_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_rename_Click()", false);
            }

            if( textBox_insert.Text != "" && numericUpDown_index.ToString() != "0")
            {//  have to have index and insert
                for (int i = 0; i < listView_files.SelectedItems.Count; i++)
                {// loop selected file
                    //  update the name in the folder
                    File.Move(files[listView_files.SelectedItems[i].Index].ToString(), sourceDir + listView_files.SelectedItems[i].Text);

                    //  update the name in the files
                    files[listView_files.SelectedItems[i].Index] = listView_files.SelectedItems[i].Text;
                }

                emptyInfoTextBox();
            }
            else
            {
                if(textBox_insert.Text == "")
                {
                    addMessageToListViewMessage("Enpty Insert", true);
                }
                if(numericUpDown_index.ToString() == "0")
                {
                    addMessageToListViewMessage("Enpty Index", true);
                }
            }
        }

        //  get destination path
        private void button_destination_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_destination_Click()", false);
            }

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                comboBox_destination.Text = folderDlg.SelectedPath;
            }
        }
        
        //  get savePath path
        private void button_savePath_Click(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("button_savePath_Click()", false);
            }

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                comboBox_savePath.Text = folderDlg.SelectedPath;
            }
        }
//  checkBox
        private void checkBox_file_CheckedChanged(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("checkBox_file_CheckedChanged()", false);
            }

            ReadFolder();
        }

        private void checkBox_folder_CheckedChanged(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("checkBox_folder_CheckedChanged()", false);
            }

            ReadFolder();
        }

//  textBox
        //  textBox_directory manual entry
        private void textBox_directory_KeyDown(object sender, KeyEventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("textBox_directory_KeyDown()", false);
            }

            if (e.KeyCode == Keys.Enter)
            {
                ReadFolder();
            }
        }

        //  textBox_filePairDirectory manual entry
        private void textBox_filePairDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("textBox_filePairDirectory_KeyDown()", false);
            }

            if (e.KeyCode == Keys.Enter)
            {
                reset();
                directoryName = textBox_filePairDirectory.Text;
                ReadFile();
            }

        }

        //  numericUpDown
        private void numericUpDown_index_ValueChanged(object sender, EventArgs e)
        {
            if (debug)
            {
                addMessageToListViewMessage("numericUpDown_index_ValueChanged()", false);
            }

            if (listView_files.SelectedItems.Count == 1 && numericUpDown_index.Text != "0")
            {
                //  update the file name using the information in the text box
                listView_files.Items[listView_files.SelectedItems[0].Index].Text = 
                    files[listView_files.SelectedItems[0].Index].Substring((textBox_directory).Text.Length)
                        .Insert(Convert.ToInt32(numericUpDown_index.Value), textBox_insert.Text);
            }
        }
    }
}
