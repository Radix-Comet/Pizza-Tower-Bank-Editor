using System.Text;

namespace PizzaTowerBankEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {


                    //populate treeview
                    bankTreeView.Nodes.Clear();
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.AboutForm form = new Forms.AboutForm())
                form.ShowDialog();
        }

        SimpleRIFF.RIFF_Objects.RIFFObject? riffObject = null;

        public bool RIFFLoaded => riffObject is not null;

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "FMOD Bank Files (*.bank)|*.bank";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (SimpleRIFF.Streams.RIFFStream rs = new SimpleRIFF.Streams.RIFFStream(fs))
                        {
                            riffObject?.Children.Clear();
                            riffObject = new SimpleRIFF.RIFF_Objects.RIFFObject();

                            riffObject.Read(rs);
                            rs.Close();
                        }
                        fs.Close();
                    }


                    Console.WriteLine($"Done, RIFF has: {riffObject.Children.Count} children");

                    loadRIFFIntoTreeView();
                }
            }
        }

        private void unloadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            riffObject?.Children.Clear();
            riffObject = null;
            unloadTreeView();

            GC.Collect();
        }

        void loadRIFFIntoTreeView()
        {
            unloadTreeView();

            var rIFFNode = bankTreeView.Nodes.Add($"RIFF - TYPE: {riffObject!.FormType}");
            addListChildrenToTreeNode(rIFFNode, riffObject);

            return;

            void addListChildrenToTreeNode(TreeNode node, SimpleRIFF.Interfaces.IContainerChunk listObj)
            {
                foreach (var item in listObj.Children)
                {
                    if (item.CharacterCode.Code == "LIST")
                    {
                        var listType = (((SimpleRIFF.RIFF_Objects.RIFFListObject)item)).ListType;

                        string displayName = getFullNameFromNodeName(listType.Code);

                        if (displayName == string.Empty)
                            displayName = $"{item.CharacterCode.Code} - TYPE: {listType}";

                        var newNode = node.Nodes.Add(displayName);
                        addListChildrenToTreeNode(newNode, (SimpleRIFF.RIFF_Objects.RIFFListObject)item);
                    }
                    else if (item.CharacterCode.Code == "LCNT")
                    {
                        var data = ((SimpleRIFF.RIFF_Objects.RIFFGenericDataObject)item).Data;
                        node.Nodes.Add($"List Count: ({BitConverter.ToInt32(data)})");
                    }
                    else
                    {
                        string displayName = getFullNameFromNodeName(item.CharacterCode.Code);

                        if (displayName == string.Empty)
                            displayName = $"{item.CharacterCode.Code}";

                        var latestNode = node.Nodes.Add($"{displayName} - ({((SimpleRIFF.RIFF_Objects.RIFFGenericDataObject)item).Data.Length})");

                        latestNode.Tag = (SimpleRIFF.RIFF_Objects.RIFFGenericDataObject)item;
                        latestNode.ContextMenuStrip = blockContextMenuStrip;
                    }
                }
            }
        }
        void unloadTreeView()
        {
            bankTreeView.Nodes.Clear();
        }

        string getFullNameFromNodeName(string nodeName)
        {
            switch (nodeName)
            {
                case "PROJ":
                    return "Project (PROJ)";

                case "FMT ":
                    return "Format (FMT)";
                case "BNKI":
                    return "Bank Info (BNKI)";

                case "PRPS":
                    return "Properties (PRPS)";
                case "PROP":
                    return "Property (PROP)";

                case "GBSS":
                    return "Group Buses (GBSS)";
                case "GBUS":
                    return "Group Bus (GBUS)";
                case "GBSB":
                    return "Group Bus Binary (GBSB)";

                case "TLNS":
                    return "Timelines (TLNS)";
                case "TMLN":
                    return "Timeline (TMLN)";
                case "TLNB":
                    return "Timeline Binary (TLNB)";
                case "TRNS":
                    return "Tranisitions (TRNS)";
                case "TRAN":
                    return "Tranisition (TRAN)";
                case "TRNB":
                    return "Tranisition Binary (TRNB)";

                case "PRMS":
                    return "Parameters (PRMS)";
                case "PARM":
                    return "Parameter (PARM)";
                case "PRMB":
                    return "Parameter Binary (PRMB)";

                case "CMDS":
                    return "Commands (CMDS)";


                case "MODS":
                    return "Modules (MODS)";
                case "MODU":
                    return "Module (MODU)";
                case "MODB":
                    return "Module Binary (MODB)";

                case "EVTS":
                    return "Events (EVTS)";
                case "EVNT":
                    return "Event (EVNT)";
                case "EVTB":
                    return "Event Binary (EVTB)";

                case "HASH":
                    return "Hash (HASH)";

                case "SND ":
                    return "Sound (SND)";

                default:
                    return string.Empty;
            }

        }

        #region Tools
        private void extractBankAsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (!RIFFLoaded)
            {
                MessageBox.Show("There is no loaded Bank file", "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void importFolderAsBankToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportSelectedChunkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importChunkAsSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Context Menu
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleRIFF.RIFF_Objects.RIFFGenericDataObject item = (SimpleRIFF.RIFF_Objects.RIFFGenericDataObject)bankTreeView.SelectedNode.Tag;

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Choose where to save the exported chunk";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dlg.FileName, item.Data);
                }
            }
        }
        #endregion

        private void bankTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                bankTreeView.SelectedNode = e.Node;

        }
    }
}