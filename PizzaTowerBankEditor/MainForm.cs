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
                        string displayName = $"{item.CharacterCode.Code} - TYPE: {listType}";
                        if (listType.Code == "PRPS")
                            displayName = "Properties (PRPS)";
                        else if (listType.Code == "MODS")
                            displayName = "Modules (MODS)";
                        else if (listType.Code == "MODU")
                            displayName = "Module (MODU)";

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
                        node.Nodes.Add($"{item.CharacterCode.Code} - ({((SimpleRIFF.RIFF_Objects.RIFFGenericDataObject)item).Data.Length})");
                    }
                }

                return;


            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.AboutForm form = new Forms.AboutForm())
                form.ShowDialog();
        }
    }
}