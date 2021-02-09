using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI32
{
    public partial class TrainerTreeList : UserControl, ITrainerUI<byte> 
    {

        List<ValueTreeNode<byte>> allNodes = new List<ValueTreeNode<byte>>();
        public TrainerTreeList(string titleThing, ValueTreeNode<byte>[] nodes)
        {
            InitializeComponent();

            Label_title.Text = titleThing;
            foreach (ValueTreeNode<byte> item in nodes)
            {
                item.AddChildrenToList(ref allNodes);
                treeView1.Nodes.Add(item);
            }
        }

        public ValueChanged<byte> onValueChanged { get; set; }

        public void AttemptShuffle()
        {
            throw new NotImplementedException();
        }

        public byte GetValue()
        {
            return (treeView1.SelectedNode as ValueTreeNode<byte>).value;
        }

        public void SetValue(byte value)
        {
            treeView1.SelectedNode = allNodes.FirstOrDefault(n => n.value == value);
            // ValueTreeNode<byte> nodee = (treeView1.Nodes as ValueTreeNode<byte>);

        }

        

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            onValueChanged?.Invoke(GetValue());
        }
    }
}

public class ValueTreeNode<T> : TreeNode
{
    public T value;
    //  public string text;

    public ValueTreeNode(string text, T value) : base(text)
    {
        this.value = value;
        this.Text = text;
    }

    public void AddChildrenToList(ref List<ValueTreeNode<T>> list)
    {
        foreach (var n in this.Nodes)
        {
            var node = n as ValueTreeNode<T>;
            node.AddChildrenToList(ref list);
        }

    }
}
