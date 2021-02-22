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

namespace HaloPog
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            FillRichText(@"data/Hi.txt");             
        }

        public void FillRichText(string aPath)
        {
            string content = File.ReadAllText(aPath);
            richTextBox1.Text = content;
        }

    }
}
