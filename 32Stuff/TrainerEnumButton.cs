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

    public partial class TrainerEnumButton : UserControl, TrainerUI<byte>
    {

        private byte value;
        private Dictionary<byte,MyButton> buttons;

     

        public TrainerEnumButton(string title, params ValueStringPair[] values)
        {
            InitializeComponent();
            Label_title.Text = title;

          

            buttons = new Dictionary<byte, MyButton>();

            for (int i = 0; i < values.Length; i++)
            {

                //   vals[i] = values[i];

                var val = values[i].value;
                MyButton butt = new MyButton();
                butt.Text = values[i].display;
                butt.Appearance = Appearance.Button;
               
                flowLayoutPanel1.Controls.Add(butt);
                buttons.Add(val, butt);
                butt.Click += new EventHandler((sender, eventArgs) => OnButtonPress(sender, eventArgs, butt, val));


            }
        }

        private void ShuffleTick(object sender, EventArgs e)
        {
            
        }

        private void OnButtonPress(object sender, EventArgs eventArgs, MyButton butt, byte value)
        {
            
            this.value = value;
            SelectButton(value);

            SetValue(value);

            onValueChanged.Invoke(value);
        }

         void SelectButton (byte value)
        {
            foreach (var item in buttons)
            {
                item.Value.Checked = (value == item.Key);
            }
        }

        public ValueChanged<byte> onValueChanged { get ; set ; }

        public byte GetValue()
        {
            return value;
        }

        public void SetValue(byte value)
        {
            this.value = value;
            SelectButton(value);

           
        }

        public void AttempShuffle()
        {
         
        }
    }
}
