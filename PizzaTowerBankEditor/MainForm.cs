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
                    SimpleRIFF.RIFF_Objects.RIFFObject obj = new();
                    using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (SimpleRIFF.Streams.RIFFStream rs = new SimpleRIFF.Streams.RIFFStream(fs))
                        {
                            obj.Read(rs);
                            rs.Close();
                        }
                        fs.Close();
                    }

                    Console.WriteLine($"Done, RIFF has: {obj.Children.Count} children");

                    //populate treeview
                    treeView1.Nodes.Clear();
                    var rIFFNode = treeView1.Nodes.Add($"RIFF - TYPE: {obj.FormType}");
                    addListChildrenToTreeNode(rIFFNode, obj);
                }
            }


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

                        node.Nodes.Add($"{displayName} - ({((SimpleRIFF.RIFF_Objects.RIFFGenericDataObject)item).Data.Length})");
                    }
                }

                return;

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

                        case "SND ":
                            return "Sound (SND)";

                        default:
                            return string.Empty;
                    }

                }

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.AboutForm form = new Forms.AboutForm())
                form.ShowDialog();
        }
    }
}