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
    public partial class tableLayoutPanel1 : UserControl, ITrainerUI<byte>
    {

        public int butSize = 25;
        public List<ButtonColourData<byte>> buttons = new List<ButtonColourData<byte>>(); 

        public struct ButtonColourData<T>
        {
            public CheckBox button;
            public ColourData<T> colourData;

           
            public ButtonColourData(CheckBox button, ColourData<T> colourData)
            {
                this.button = button;
                this.colourData = colourData;
            }
        }

        public tableLayoutPanel1(string name, ColourData<byte>[] colours)
        {
            InitializeComponent();

            label2.Text = name;
           


            foreach (ColourData<byte> cdata in colours)
            {
                CheckBox butt = new CheckBox();
                butt.Appearance = Appearance.Button;
                butt.BackColor = cdata.colour;

                butt.Width = butt.Height = butSize;
                butt.FlatAppearance.BorderSize = 10;
                

                buttons.Add(new ButtonColourData<byte>(butt, cdata));
                
                butt.Click += new EventHandler((sender, eventArgs) => OnButtonClick(sender, eventArgs, butt, cdata));
                flowLayoutPanel1.Controls.Add(butt);
            }
            
        }
        ColourData<byte> current;
        private void OnButtonClick(object sender, EventArgs e, CheckBox butt, ColourData<byte> colourData)
        {
            if (current.value != colourData.value) 
            {
                current = colourData;
                SetSelected();
                onValueChanged.Invoke(colourData.value);

            }
        }

        public void SetSelected()
        {
            
            foreach (var item in buttons)
            {
                item.button.Checked = item.colourData.value == current.value;
            }
        }
       

        public ValueChanged<byte> onValueChanged { get; set ; }

        public byte GetValue()
        {
            return current.value;
        }


        ButtonColourData<byte> butt;
        public void SetValue(byte value)
        {
            current.value = value;
            butt = buttons.FirstOrDefault(b => b.colourData.value == value);
            SetSelected();

            
        }

        public void AttemptShuffle()
        {
            if (!LoopBox.Checked) return;

            int index = buttons.IndexOf(butt);
            index++;
            index %= buttons.Count();
            var value = buttons[index].colourData.value;

            SetValue(value);
            SetSelected();
            onValueChanged.Invoke(value);
        }

        public struct ColourData<T>
        {
            public Color colour;
            public String colourName;
            public T value;

            public ColourData(Color colour, string colourName, T value)
            {
                this.colour = colour;
                this.colourName = colourName;
                this.value = value;
            }
        }
    }
}
