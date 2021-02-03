using HaloPogSwitch;
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
    public partial class TrainerEnumButtonArray : UserControl, TrainerUI<byte>
    {

          public Dictionary<byte, MyButton> buttons = new Dictionary<byte, MyButton>();

        public byte theValue;


        public TrainerEnumButtonArray(string titleThing, List<Node> nodes)
        {
            InitializeComponent();
            label1.Text = titleThing;

            OnButtonClickEvent += OnButtonPress;
            foreach (var item in nodes)
            {
                item.SetUpNodeData(flowLayoutPanel1.Controls, OnButtonClickEvent, buttons);
            }
           
           
        }


        public byte GetValue()
        {
            return theValue;
        }

        public void SetValue(byte value)
        {
            theValue = value;


            foreach (KeyValuePair<byte, MyButton> item in buttons)
            {
                item.Value.Checked = false;
            }
            buttons[theValue].Checked = true;
           

        }



     
        public void OnButtonPress (byte value)
        {
            SetValue(value);
            onValueChanged.Invoke(value);

          



        }

        public delegate void OnButtonClick(byte value);
        public OnButtonClick OnButtonClickEvent;

        public ValueChanged<byte> onValueChanged { get ; set ; }
    }

    public class Node
    {
        public string title;
        public byte value;

        public List<Node> nodes = new List<Node>();

        public TrainerEnumButtonArray.OnButtonClick clickCaller;
        public Control.ControlCollection collection;

        public Dictionary<byte, MyButton> buttons;
        public void SetUpNodeData (Control.ControlCollection collection, TrainerEnumButtonArray.OnButtonClick caller,  Dictionary<byte, MyButton> buttons)
        {
           
            this.collection = collection;
            this.clickCaller = caller;
            this.buttons = buttons;

            CreateButtons();
        }

        public Node (string title, byte value, List<Node> nodes)
        {
            this.title = title;
            this.value = value;
            this.nodes = nodes;
        }

        public Node()
        {
        }

        public Node(string title, byte value)
        {
            this.title = title;
            this.value = value;
        }

        public bool isHolder = false;
       

        public void CreateButtons()
        {
            if (nodes.Count > 0)
            {
                isHolder = true;

                ButtonArray buttonArray = new ButtonArray(title);
                collection.Add(buttonArray);

                Console.WriteLine("Adding Button Array: " + title);

                foreach (var item in nodes)
                {
                    item.SetUpNodeData(buttonArray.GetControlls(), clickCaller, buttons);
                }
            }
            else
            {
                MyButton butt = new MyButton();
                butt.Text = title;

                Console.WriteLine("Adding New Button: "+ title  + " v: " + value );

                collection.Add(butt);

                buttons.Add(value, butt);

                butt.Click += ClickEvent;

            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
           
            clickCaller.Invoke(value);
        }
    }
}

