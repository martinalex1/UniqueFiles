using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniqueFiles.Properties;

namespace UniqueFiles
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Dictionary<string, string> _repoDict = new Dictionary<string, string>();
        private string _repoPath;
        private string _resultMessage;
        bool _viewAll = true;
        bool _stop = false;
        public enum Change { Add, Update, No, Dup, Nodup, Err };
        readonly string[] _validPicExtensions = new[] { ".jpg", ".jpeg", ".jfif", ".png", ".gif", ".bmp", ".tif", ".ico", ".wmf", ".emf" };
        int _pos = 0;

        // -------------- form ---------------------------------------------------------------------

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Left = Settings.Default.MainX;
            this.Top = Settings.Default.MainY;
            this.Width = Settings.Default.MainW;
            this.Height = Settings.Default.MainH;
            _repoPath = Settings.Default.LastRepo;
            if (File.Exists(_repoPath))
            {
                RepoLoadFile(_repoPath);
            }
            else
            {
                _repoPath = "";
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.MainX = Left;
            Settings.Default.MainY = Top;
            Settings.Default.MainW = Width;
            Settings.Default.MainH = Height;
            Settings.Default.LastRepo = _repoPath;
            Settings.Default.Save();
        }

        private void TxtReponame_TextChanged(object sender, EventArgs e)
        {
            _repoPath = "";
        }

        private void CmdFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            fbDialog.SelectedPath = txtDirectory.Text;
            fbDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            if (fbDialog.ShowDialog(true) == DialogResult.OK)     // use dialog extension
            {
                txtDirectory.Text = fbDialog.SelectedPath;
            }
        }

        // -------------- drop -------------------
        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            ProcessDrop((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void FormMain_DragOver(object sender, DragEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                // control is pressed. Copy.
                e.Effect = DragDropEffects.Copy;    // + sign for sub-dirs
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        public void ProcessDrop(string[] files)
        {
            listResult.Items.Clear();
            _viewAll = true;
            int fileCount = 0;
            int dirCount = 0;
            int noDupCount = 0;
            foreach (string dropFile in files)
            {
                if (File.Exists(dropFile))
                {
                    fileCount++;
                    Change drop = DropCheckRepo(dropFile);
                    if (drop == Change.Nodup) noDupCount++;
                }
                else if (Directory.Exists(dropFile))
                { // is dir
                    dirCount++;
                    List<string> fileList;
                    fileList = Directory.GetFiles(dropFile, "*.*", SearchOption.AllDirectories).ToList();
                    foreach (string filePath in fileList)
                    {
                        fileCount++;
                        Change drop = DropCheckRepo(filePath);
                        if (drop == Change.Nodup) noDupCount++;

                        if ((fileCount % 100) == 0)
                        {
                            statusMain.Text = "Processed: " + fileCount + " of " + fileList.Count + " files";
                            Application.DoEvents();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No drop files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }  // end for
            _resultMessage = string.Format("Drop - directories: {0}, all files: {1}, missing files: {2}, duplicate files: {3}", dirCount, fileCount, noDupCount, fileCount - noDupCount);
            tabControl.SelectedTab = tabControl.TabPages["tabResult"];

        }

        // -------------- menu -------------------
        private void MnuNew_Click(object sender, EventArgs e)
        {
            RepoNew();
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            RepoOpen();
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            RepoSave();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            About frmAbout = new About();
            frmAbout.ShowDialog();
        }


        // -------------- functions -------------------

        void RepoNew()
        {
            _repoDict.Clear();
            txtReponame.Text = "";
            txtFileCount.Text = "0";
            txtChangeCount.Text = "0";
            txtDuplicateCount.Text = "0";
            txtLastUpdate.Text = "";
            _repoPath = "";
            lblDrop.Visible = false;
            
            txtView.Text = "";
            picBox.Image = null;
            listResult.Items.Clear();
            tabControl.SelectedTab = tabControl.TabPages["tabRepo"];
            statusMain.Text = "New repository";

        }

        void RepoOpen()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Repository files (*.repo)|*.repo|All files (*.*)|*.*";
            dialog.Title = "Select repository file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    RepoLoadFile(dialog.FileName);
                }
                else
                {
                    MessageBox.Show("File does not exist " + "\n" + dialog.FileName, "Load error",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        void RepoSave()
        {
            if (!File.Exists(_repoPath))
            {
                var dialog = new SaveFileDialog();
                dialog.Filter = "Repository files (*.repo)|*.repo|All files (*.*)|*.*";
                dialog.Title = "Save repository file";
                dialog.FileName = txtReponame.Text;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtReponame.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
                    _repoPath = dialog.FileName;
                    RepoSaveFile(_repoPath);
                }
            }
            else
            {
                RepoSaveFile(_repoPath);
            }
        }

        // -------------- tab 1 repo ---------------------------------------------------------------

        private void TabRepo_Enter(object sender, EventArgs e)
        {
            statusMain.Text = "";
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            string dirPath = txtDirectory.Text;
            if (Directory.Exists(dirPath))
            {
                cmdStop.Visible = true;
                _stop = false;
                statusMain.Text = "Update started";
                Application.DoEvents();
                listResult.Items.Clear();
                _viewAll = true;
                List<string> fileList;
                fileList = Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories).ToList();
                
                List<string> dictList = new List<string>();
                foreach (KeyValuePair<string, string> re in _repoDict)
                {
                    dictList.Add(re.Value);
                }
                
                List<string> notInDict = fileList.Except(dictList).ToList();  
                List<string> notInFList = dictList.Except(fileList).ToList();  
                Debug.WriteLine("filelist: {0} dict {1} not in dict {2} not in filelist {3}", fileList.Count, dictList.Count, notInDict.Count, notInFList.Count);
                int unchanged = Math.Abs(dictList.Count - notInDict.Count);
                //int unchanged = 0;
                int ch = 0;
                int dup = 0;
                int err = 0;
                ProcessList(ref notInDict, ref ch, ref dup, ref unchanged, ref err);

                txtFileCount.Text = unchanged.ToString();
                txtChangeCount.Text = ch.ToString();
                txtDuplicateCount.Text = dup.ToString();
                txtLastUpdate.Text = DateTime.Now.ToString();
                lblDrop.Visible = true;
                
                string errStr = "";
                if (err > 0) errStr = " - Errors: " + err.ToString();
                cmdStop.Visible = false;
                if (_stop)
                    statusMain.Text = "Update stopped" + errStr;
                else
                    statusMain.Text = "Update finished" + errStr;
                _resultMessage = string.Format("Load - all files: {0}, duplicate files: {1}", dup + ch, dup);
            }
            else
                statusMain.Text = "Invalid directory";
        }

        private void CmdStop_Click(object sender, EventArgs e)
        {
            _stop = true;
        }
        
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            RepoOpen();
        }

        // -------------- functions -------------------
        
        void ProcessList(ref List<string> fList, ref int chCount, ref int dupCount, ref int nchCount, ref int errCount)
        {   
            int f = 0;
            foreach (string filePath in fList)
            {
                Change load = LoadCheckRepo(filePath);
                if (load == Change.Add) chCount++;
                if (load == Change.Update) chCount++;
                if (load == Change.Dup) dupCount++;
                if (load == Change.No) nchCount++;
                if (load == Change.Err) errCount++;   
                f++;
                if ((f % 100) == 0)
                {
                    statusMain.Text = "Processed: " + f + " of " + fList.Count + " files";
                    if (_stop) break;
                    Application.DoEvents();
                }
            }
        }
        
        Change LoadCheckRepo(String filePath)
        // load file to repo and check for duplicates
        {
            try
            {            
                string md5 = CalculateMD5(filePath);
                if (_repoDict.ContainsKey(md5))
                {
                    if (filePath == _repoDict[md5])
                    {
                        return Change.No;
                    }
                    else
                    {
                        if (File.Exists(_repoDict[md5]))
                        {
                            ResultListAddDup(filePath, _repoDict[md5]);
                            return Change.Dup;
                        }
                        else   // rename
                        {
                            _repoDict[md5] = filePath;
                            return Change.Update;
                        }
                    }
                }
                else
                {
                    _repoDict.Add(md5, filePath);
                    return Change.Add;
                }
             }
            catch  
            {
                return Change.Err;
            }             
        }

        Change DropCheckRepo(String filePath)
        // check for non-duplicates from drop
        {
            string md5 = CalculateMD5(filePath);
            if (_repoDict.ContainsKey(md5))
            {
                return Change.Dup;
            }
            else
            {
                ResultListAddMissing(filePath);
                return Change.Nodup;
            }
        }

        string CalculateMD5(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (Stream stream = File.OpenRead(fileName))
                {
                    FileInfo fi = new FileInfo(fileName);
                    if (fi.Length < 4194304)
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "");
                    }
                    else  // first 4mb for large files
                    {
                        byte[] content = new byte[4194304];
                        stream.Read(content, 0, 4194304);
                        var hash = md5.ComputeHash(content);
                        return BitConverter.ToString(hash).Replace("-", "");
                    }
                }
            }
        }

        void RepoLoadFile(string repoPath)
        {
            _repoDict.Clear();
            _repoDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(repoPath));
            txtDirectory.Text = _repoDict["*"];

            txtReponame.Text = Path.GetFileNameWithoutExtension(repoPath);
            _repoPath = repoPath;
            txtReponame.TextChanged += new System.EventHandler(TxtReponame_TextChanged);   // delay event after initial text
            txtFileCount.Text = (_repoDict.Count - 1).ToString();
            txtChangeCount.Text = "0";
            txtDuplicateCount.Text = "0";
            FileInfo fi = new FileInfo(repoPath);
            txtLastUpdate.Text = fi.LastWriteTime.ToString();
            
            lblDrop.Visible = true;
            txtView.Text = "";
            picBox.Image = null;
            listResult.Items.Clear();
            tabControl.SelectedTab = tabControl.TabPages["tabRepo"];
            statusMain.Text = "Repository loaded: " + Path.GetFileName(repoPath);
        }

        void RepoSaveFile(string repoPath)
        {
            // store directory path in repo
            if (_repoDict.ContainsKey("*"))
            {
                _repoDict["*"] = txtDirectory.Text;
            }
            else
            {
                _repoDict.Add("*", txtDirectory.Text);
            }
            File.WriteAllText(repoPath, JsonConvert.SerializeObject(_repoDict, Formatting.Indented));
            statusMain.Text = "Repository saved: " + Path.GetFileName(repoPath);
        }

        // -------------- tab 2 result list ------------------------------------------------------------

        private void TabResult_Enter(object sender, EventArgs e)
        {
            statusMain.Text = _resultMessage;
        }

        private void ListResult_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages["tabView"];
            // starts TabView_Enter
        }

        // -------------- toolbar -------------------

        private void TbCheck_ButtonClick(object sender, EventArgs e)
        // select all
        {
            tbCheckAll.PerformClick();
        }

        private void TbCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listResult.Items.Count; i++)
            {
                listResult.Items[i].Checked = true;
            }
        }

        private void TbCheckNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listResult.Items.Count; i++)
            {
                listResult.Items[i].Checked = false;
            }
        }

        private void TbCheckSecond_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listResult.Items.Count; i += 2)
            {
                listResult.Items[i].Checked = true;
            }
        }


        private void TbView_ButtonClick(object sender, EventArgs e)
        // view all
        {
            tbViewAll.PerformClick();
        }

        private void TbViewAll_Click(object sender, EventArgs e)
        {
            _viewAll = true;
            tabControl.SelectedTab = tabControl.TabPages["tabView"];
        }

        private void TbViewChecked_Click(object sender, EventArgs e)
        {
            _viewAll = false;
            tabControl.SelectedTab = tabControl.TabPages["tabView"];
        }


        private void TbCopy_ButtonClick(object sender, EventArgs e)
        {
            tbCopyChecked.PerformClick();
        }

        private void TbCopyAll_Click(object sender, EventArgs e)
        {
            string toDir = "";
            int copyCount = 0;
            for (int i = 0; i < listResult.Items.Count; i++)
            {
                if (string.IsNullOrEmpty(toDir))
                {
                    FolderBrowserDialog fbDialog = new FolderBrowserDialog();
                    fbDialog.SelectedPath = txtDirectory.Text;
                    fbDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
                    if (fbDialog.ShowDialog(true) == DialogResult.OK)     // use dialog extension
                    {
                        toDir = fbDialog.SelectedPath;
                    }
                }
                string fPath = listResult.Items[i].SubItems[1].Text + @"\" + listResult.Items[i].Text;
                string fName = listResult.Items[i].Text;
                //Debug.WriteLine("copy all: {0} to {1}", fPath, toDir + fName);
                if (File.Exists(fPath) && !string.IsNullOrEmpty(toDir))
                {
                    File.Copy(fPath, toDir + @"\" + fName, true);
                    copyCount++;
                }
            }
            statusMain.Text = string.Format("Files copied: {0}", copyCount);
        }

        private void TbCopyChecked_Click(object sender, EventArgs e)
        {
            string toDir = "";
            int copyCount = 0;
            for (int i = 0; i < listResult.Items.Count; i++)
            {
                if (listResult.Items[i].Checked == true)
                {
                    if (string.IsNullOrEmpty(toDir))
                    {
                        FolderBrowserDialog fbDialog = new FolderBrowserDialog();
                        fbDialog.SelectedPath = txtDirectory.Text;
                        fbDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
                        if (fbDialog.ShowDialog(true) == DialogResult.OK)     // use dialog extension
                        {
                            toDir = fbDialog.SelectedPath;
                        }
                    }
                    string fPath = listResult.Items[i].SubItems[1].Text + @"\" + listResult.Items[i].Text;
                    string fName = listResult.Items[i].Text;
                    //Debug.WriteLine("copy checked: {0} to {1}", fPath, toDir + fName);
                    if (File.Exists(fPath) && !string.IsNullOrEmpty(toDir))
                    {
                        File.Copy(fPath, toDir + @"\" + fName, true);
                        copyCount++;
                    }
                }
            }
            statusMain.Text = string.Format("Files copied: {0}", copyCount);
        }

        private void TbDelete_ButtonClick(object sender, EventArgs e)
        {
            tbDeleteChecked.PerformClick();
        }

        private void TbDeleteChecked_Click(object sender, EventArgs e)
        // delete checked only
        {
            int delCount = 0;
            for (int i = listResult.Items.Count - 1; 0 <= i; i--)
            {
                if (listResult.Items[i].Checked == true)
                {
                    string fPath = listResult.Items[i].SubItems[1].Text + @"\" + listResult.Items[i].Text;

                    if (DelFile.MoveToRecycleBin(fPath))
                    {
                        listResult.Items[i].Remove();
                        delCount++;
                    }
                }
            }
            statusMain.Text = string.Format("Files deleted: {0}", delCount);
        }

        // -------------- drag & drop -------------------

        private void ListResult_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void ListResult_DragDrop(object sender, DragEventArgs e)
        {
            ProcessDrop((string[])e.Data.GetData(DataFormats.FileDrop));
            statusMain.Text = _resultMessage;
        }

        private void ListResult_DragOver(object sender, DragEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                // control is pressed. Copy.
                e.Effect = DragDropEffects.Copy;    // + sign for sub-dirs
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        // -------------- pop menu -------------------
        
        private void PopFolder_Click(object sender, EventArgs e)
        {
			if (listResult.SelectedItems.Count > 0) 
			{
				string dir = listResult.SelectedItems[0].SubItems[1].Text;
				if (Directory.Exists(dir)) {
					Process explorer = new Process();
					explorer.StartInfo.FileName = dir;
					explorer.Start(); 
				}
			}
        }

        private void PopView_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages["tabView"];
        }

        private void PopViewExternal_Click(object sender, EventArgs e)
        {
			if (listResult.SelectedItems.Count > 0) 
			{
				string fPath = listResult.SelectedItems[0].SubItems[1].Text + @"\" + listResult.SelectedItems[0].Text;
				if (File.Exists(fPath))
				{
					Process editor = new Process();
					editor.StartInfo.FileName = fPath;
					editor.Start();
				}
			}
        }
                
        // -------------- functions -------------------
        void ResultListAddDup(string filePath, string repoPath)
        // add original and duplicate
        {
            ListViewItem item = listResult.Items.Add(Path.GetFileName(filePath));
            item.ImageIndex = 0;
            item.SubItems.Add(Path.GetDirectoryName(filePath));
            item.SubItems.Add("duplicate");
            FileInfo fi = new FileInfo(filePath);
            item.SubItems.Add(fi.LastWriteTime.ToString());
            int size = (int)Math.Round(fi.Length / 1024.0);
            item.SubItems.Add(string.Format("{0:N0} KB", size));

            item = listResult.Items.Add(Path.GetFileName(repoPath));
            item.ImageIndex = 0;
            item.SubItems.Add(Path.GetDirectoryName(repoPath));
            item.SubItems.Add("duplicate");
            fi = new FileInfo(filePath);
            item.SubItems.Add(fi.LastWriteTime.ToString());
            size = (int)Math.Round(fi.Length / 1024.0);
            item.SubItems.Add(string.Format("{0:N0} KB", size));
        }

        void ResultListAddMissing(string filePath)
        // add missing file
        {
            ListViewItem item = listResult.Items.Add(Path.GetFileName(filePath));
            item.ImageIndex = 0;
            item.SubItems.Add(Path.GetDirectoryName(filePath));
            item.SubItems.Add("missing");
            FileInfo fi = new FileInfo(filePath);
            item.SubItems.Add(fi.LastWriteTime.ToString());
            int size = (int)Math.Round(fi.Length / 1024.0);
            item.SubItems.Add(string.Format("{0:N0} KB", size));
        }

        // -------------- tab 3 view   -------------------------------------------------------------

        private void TabControl_KeyDown(object sender, KeyEventArgs e)
        {
            bool ctrl = false;
            if (e.Modifiers == Keys.Control)
            {
                ctrl = true;
            }
            KDown(e.KeyValue, ctrl);
        }

        private void TabView_Enter(object sender, EventArgs e)
        // show first or selected file
        {
            if (listResult.Items.Count > 0)
            {
                string fPath;
                if (listResult.SelectedItems.Count > 0)
                {
                    fPath = listResult.SelectedItems[0].SubItems[1].Text + @"\" + listResult.SelectedItems[0].Text;
                    SetFilePosition(listResult.SelectedItems[0].Text, listResult.SelectedItems[0].SubItems[1].Text);
                    if (!File.Exists(fPath)) fPath = "";
                    ShowNext(fPath);
                }
                else
                {
                    _pos = -1;
                    ShowNext("");
                }

            }
        }

        // -------------- toolbar -------------------
        private void TbPrior_Click(object sender, EventArgs e)
        {
            ShowPrior();
        }

        private void TbNext_Click(object sender, EventArgs e)
        {
            ShowNext("");
        }

        private void TbChecked_Click(object sender, EventArgs e)
        {
            if (tbChecked.Text == "C")
            {
                tbChecked.Image = imageList.Images[1];
                tbChecked.Text = "U";
                listResult.Items[_pos].Checked = false;
            }
            else
            {
                tbChecked.Image = imageList.Images[0];
                tbChecked.Text = "C";
                listResult.Items[_pos].Checked = true;
            }
        }

        // -------------- functions -------------------

        void SetFilePosition(string fName, string fDir)
        {
            int pos = 0;
            for (int i = 0; i < listResult.Items.Count; i++)
            {
                if (listResult.Items[i].SubItems[1].Text == fDir && listResult.Items[i].Text == fName)
                    pos = i;
            }
            _pos = pos;
        }

        void ShowFile(string fPath)
        {
            try
            {
                if (FileIsImage(fPath))
                {
                    string ext = Path.GetExtension(fPath).ToLower();
                    if (ext == ".gif")     // can't load gif via stream
                    {
                        picBox.Visible = true;
                        txtView.Visible = false;
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;   // for large images    CenterImage für small images?
                        picBox.Image = Image.FromFile(fPath);
                    }
                    else
                    {
                        using (FileStream stream = new FileStream(fPath, FileMode.Open, FileAccess.Read))
                        {
                            picBox.Visible = true;
                            txtView.Visible = false;
                            picBox.SizeMode = PictureBoxSizeMode.Zoom;
                            picBox.Image = Image.FromStream(stream);

                            stream.Close();
                        }
                    }
                }
                else
                {
                    picBox.Visible = false;
                    txtView.Visible = true;
                    txtView.Text = File.ReadAllText(fPath);
                }
                statusMain.Text = string.Format("File ({0}/{1}): {2}", _pos, listResult.Items.Count, fPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("File is invalid \n" + fPath + "\n " + e.Message, "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        void ShowNext(string fPath)
        {
            if (string.IsNullOrEmpty(fPath))  // given for tab enter only
                fPath = FindNextFile();

            if (string.IsNullOrEmpty(fPath))
            {
                picBox.Visible = false;
                txtView.Visible = false;
                statusMain.Text = "No file found ";
            }
            else
                ShowFile(fPath);
        }

        void ShowPrior()
        {
            string fPath = FindPriorFile();
            if (string.IsNullOrEmpty(fPath))
            {
                picBox.Visible = false;
                txtView.Visible = false;
                statusMain.Text = "No file found ";
            }
            else
                ShowFile(fPath);
        }

        void DarkPic() 
        { 
            picBox.Image = null;
            statusMain.Text = "";
        }

        string FindPriorFile()
        {
            if (listResult.Items.Count < 1)
            {
                return "";
            }
            int pos = _pos;
            do
            {
                pos--;
                if (pos < 0)
                {
                    pos = listResult.Items.Count - 1;
                }
                if (_viewAll)
                {
                    _pos = pos;
                    string fPath = listResult.Items[pos].SubItems[1].Text + @"\" + listResult.Items[pos].Text;
                    if (!File.Exists(fPath)) fPath = "";
                    ShowCheckInd(listResult.Items[pos].Checked);
                    return fPath;
                }
                else  // checked 
                {
                    if (listResult.Items[pos].Checked == true)
                    {
                        _pos = pos;
                        string fPath = listResult.Items[pos].SubItems[1].Text + @"\" + listResult.Items[pos].Text;
                        if (!File.Exists(fPath)) fPath = "";
                        ShowCheckInd(listResult.Items[pos].Checked);
                        return fPath;
                    }
                }
                //Debug.WriteLine("s pos: " + pPos + " " + _picPos);
            } while (pos != _pos);
            return "";
        }

        string FindNextFile()
        // find all or checked
        {
            if (listResult.Items.Count < 1)
            {
                return "";
            }
            int pos = _pos;
            do
            {
                pos++;
                if (pos >= listResult.Items.Count)
                {
                    pos = 0;
                }
                if (_viewAll)
                {
                    _pos = pos;
                    string fPath = listResult.Items[pos].SubItems[1].Text + @"\" + listResult.Items[pos].Text;
                    if (!File.Exists(fPath)) fPath = "";
                    ShowCheckInd(listResult.Items[pos].Checked);
                    return fPath;
                }
                else  // checked
                {
                    if (listResult.Items[pos].Checked == true)
                    {
                        _pos = pos;
                        string fPath = listResult.Items[pos].SubItems[1].Text + @"\" + listResult.Items[pos].Text;
                        if (!File.Exists(fPath)) fPath = "";
                        ShowCheckInd(listResult.Items[pos].Checked);
                        return fPath;
                    }
                }
                //Debug.WriteLine("s p/os: " + pPos + " " + _picPos);
            } while (pos != _pos);
            return "";
        }

        public bool FileIsImage(string pPath)
        {
            string ext = Path.GetExtension(pPath).ToLower();
            return _validPicExtensions.Contains(ext);
        }

        public void ShowCheckInd(bool cInd)
        {
            if (cInd)
            {
                tbChecked.Image = imageList.Images[0];
                tbChecked.Text = "C";
            }
            else
            {
                tbChecked.Image = imageList.Images[1];
                tbChecked.Text = "U";
            }
        }

        public void KDown(int kValue, bool ctrl)
        {
            //Debug.WriteLine("char: " + kValue);
            switch (kValue)
            {
                case 13:   //  return
                case 38:   //  up
                case 39:   //  ->
                case 34:   //  pd
                case 32:   //  space
                    ShowNext("");
                    break;
                case 40:   //  down
                case 37:   //  <-
                case 33:   //  pu
                case 8:    //  back
                    ShowPrior();
                    break;
                case 66:   // b   
                case 68:   // d
                    DarkPic();
                    break;
                case 78:   // n
                    if (ctrl)
                    {
                        RepoNew();
                    }
                    break;
                case 79:   // o
                    if (ctrl)
                    {
                        RepoOpen();
                    }
                    break;
                case 83:   // ctrl 's'
                    if (ctrl)
                    {
                        RepoSave();
                    }
                    break;
                case 87:   // ctrl w 
                    if (ctrl)
                    {
                        this.Close();
                    }
                    break;
            }
        }

    }  // end class

    // extension to show given folder, does work for first call
    public static class FolderBrowserDialogExtension
    {
        public static DialogResult ShowDialog(this FolderBrowserDialog dialog, bool scrollIntoView)
        {
            return ShowDialog(dialog, null, scrollIntoView);
        }

        public static DialogResult ShowDialog(this FolderBrowserDialog dialog, IWin32Window owner, bool scrollIntoView)
        {
            if (scrollIntoView)
            {
                SendKeys.Send("{TAB}{TAB}{RIGHT}");
            }

            return dialog.ShowDialog(owner);
        }
    }

}
