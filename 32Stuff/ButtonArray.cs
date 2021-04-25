using System.Windows.Forms;
namespace HaloPogSwitch
{
    public partial class ButtonArray : UserControl
    {
        public ButtonArray(string text)
        {
           
            InitializeComponent();
            label1.Text = text;
        }

        internal ControlCollection GetControlls()
        {
            return flowLayoutPanel1.Controls;
        }
    }
}
