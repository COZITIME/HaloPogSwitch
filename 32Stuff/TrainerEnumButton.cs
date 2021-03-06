﻿using System;
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

    public partial class TrainerEnumButton : UserControl, ITrainerUI<byte>
    {

        private byte value;
        private SortedList<byte, MyButton> buttons;

        List<byte> byteList = new List<byte>();

        public TrainerEnumButton(string title, params ValueStringPair[] values)
        {
            InitializeComponent();
            label1.Text = title;

            buttons = new SortedList<byte, MyButton>();

            for (int i = 0; i < values.Length; i++)
            {

                //   vals[i] = values[i];

                var val = values[i].value;
                byteList.Add(val);

                MyButton butt = new MyButton();
                butt.Text = values[i].display;
                butt.Appearance = Appearance.Button;

                flowLayoutPanel1.Controls.Add(butt);
                buttons.Add(val, butt);
                butt.Click += new EventHandler((sender, eventArgs) => OnButtonPress(sender, eventArgs, butt, val));
            }
        }

        private void OnButtonPress(object sender, EventArgs eventArgs, MyButton butt, byte value)
        {

            this.value = value;
            SelectButton(value);

            SetValue(value);

            onValueChanged.Invoke(value);
        }

        void SelectButton(byte value)
        {
            foreach (var item in buttons)
            {
                item.Value.Checked = (value == item.Key);

            }
        }



        public ValueChanged<byte> onValueChanged { get; set; }

        public byte GetValue()
        {
            return value;
        }

        public void SetValue(byte value)
        {
            this.value = value;
            SelectButton(value);


        }

        public void AttemptShuffle()
        {
            if (!LoopBox.Checked) return;


            int index = byteList.IndexOf(value) + 1;
            index %= byteList.Count();

            byte newValue = byteList[index];

            SetValue(newValue);

            onValueChanged.Invoke(newValue);
        }
    }
}
