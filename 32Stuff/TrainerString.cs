using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI32
{
    public partial class TrainerText : UserControl, TrainerUI<string>
    {

        Regex regex = new Regex(@"[^\u0000-\u007F\s\b¤¦]");

        bool spaceOutString = false;

        int maxLength;
        bool nerfSymbols = false;

        public ValueChanged<string> onValueChanged { get; set; }

        public TrainerText(string title, string main, int textBoxCharLength = 4, bool spaceOutString = false, CharacterCasing characterCasing = CharacterCasing.Normal, bool nerfSymbols = false)
        {
            InitializeComponent();
            textBox.CharacterCasing = characterCasing;

            label_main.Text = main;
            Label_title.Text = title;

            this.maxLength = textBoxCharLength;
            textBox.MaxLength = textBoxCharLength;


            this.spaceOutString = spaceOutString;
            this.nerfSymbols = nerfSymbols;
        }

        public string GetValue()
        {

            
            string text = textBox.Text;

            if (spaceOutString)
            {
                while (text.Length < maxLength)
                {
                    text += " ";
                }
            }

            return text;
        }

        public void SetValue(string value)
        {
            textBox.Text = value;
        }

        
        private void textBox_TextChanged(object sender, EventArgs e)
        {
           
            if ( nerfSymbols && regex.IsMatch(textBox.Text))
            {
                textBox.Text = "";
            }
            onValueChanged?.Invoke(textBox.Text);
        }

   

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (nerfSymbols && regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

          
                
            
        }
    }



}
