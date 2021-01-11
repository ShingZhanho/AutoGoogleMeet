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
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace ReleaseTool {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private string _dirPath = string.Empty;

        private void frmMain_Load(object sender, EventArgs e) {
            // Selects folder
            var odd = new FolderBrowserDialog() {
                Description = "Choose a directory"
            };
            if (odd.ShowDialog() == DialogResult.OK) {
                _dirPath = odd.SelectedPath;
            } else
                Application.Exit();

            var folder = new Folder(_dirPath);
            treeFiles.Nodes.Add(folder.Node);
        }

        private void treeFiles_AfterSelect(object sender, TreeViewEventArgs e) {
            var myNode = (MyNode) e.Node;
            statusFilename.Text = myNode.Path;
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            var bgw = new BackgroundWorker() {
                WorkerReportsProgress = false, WorkerSupportsCancellation = false
            };
            bgw.DoWork += (bgwSender, bgwE) => {
                btnGenerate.Enabled = false;
                richTextBox1.Enabled = false;
                treeFiles.Enabled = false;

                var myNode = (MyNode) treeFiles.Nodes[0];
                var rootFolder = new JsonRootFolder(myNode, myNode.Path);
                var json = JsonConvert.SerializeObject(rootFolder);
                var results = new List<object>();
                results.Add(json);
                bgwE.Result = results;
            };
            bgw.RunWorkerCompleted += (bgwCSender, bgwCE) => {
                btnGenerate.Enabled = true;
                richTextBox1.Enabled = true;
                treeFiles.Enabled = true;

                var results = (List<object>) bgwCE.Result;
                richTextBox1.Text = results[0].ToString();
            };
            bgw.RunWorkerAsync();
        }
    }

    internal class Folder {
        internal Folder(string path) {
            Node = new MyNode(Path.GetFileName(path), path, MyNode.NodeType.Folder);

            // Add sub nodes
            foreach (var dir in Directory.GetDirectories(path)) Node.Nodes.Add(new Folder(dir).Node);

            foreach (var file in Directory.GetFiles(path)) Node.Nodes.Add(new MyNode(Path.GetFileName(file), file, MyNode.NodeType.File));
        }

        internal MyNode Node;
    }

    internal class MyNode : TreeNode {
        internal MyNode(string name, string path, NodeType type) : base(name) {
            Path = path;
            Checked = !new[] {".pdb", ".config"}.Contains(System.IO.Path.GetFileName(path)
                .Replace(System.IO.Path.GetFileNameWithoutExtension(path), string.Empty));
            TypeOfNode = type;
        }

        internal string Path { get; }
        internal NodeType TypeOfNode { get; }

        internal enum NodeType {
            Folder, File
        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    internal class JsonRootFolder {
        internal JsonRootFolder(MyNode node, string root) {
            foreach (MyNode myNode in node.Nodes) {
                if (!myNode.Checked) continue;
                if (myNode.TypeOfNode == MyNode.NodeType.Folder)
                    JsonFolders.Add(new JsonFolder(myNode, root));
                else 
                    JsonFiles.Add(new JsonFile(myNode, root));
            }
        }
        
        [JsonProperty("folders")]
        internal List<JsonFolder> JsonFolders = new List<JsonFolder>();
        [JsonProperty("files")]
        internal List<JsonFile> JsonFiles = new List<JsonFile>();

        [JsonObject(MemberSerialization.OptIn)]
        internal class JsonFolder : JsonRootFolder {
            internal JsonFolder(MyNode node, string root) : base(node, root) {
                RelativePath = node.Path.Replace(root, string.Empty);
            }

            [JsonProperty("path")]
            internal string RelativePath;
        }

        [JsonObject(MemberSerialization.OptIn)]
        internal class JsonFile {
            internal JsonFile(MyNode node, string root) {
                RelativePath = node.Path.Replace(root, string.Empty);
                using (var md5 = MD5.Create())
                using (var stream = File.OpenRead(node.Path)) {
                    var hash = md5.ComputeHash(stream);
                    MD5Value = BitConverter.ToString(hash).Replace("-", "").ToUpper();
                }
            }

            [JsonProperty("path")]
            internal string RelativePath;
            [JsonProperty("md5")]
            internal string MD5Value;
        }
    }
}
