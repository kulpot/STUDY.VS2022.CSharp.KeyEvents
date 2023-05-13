using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: this.Text = keyData.ToString(); break;
            }

            return base.ProcessDialogKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.Enter: this.Text = e.KeyCode.ToString(); break;
            }
        }*/

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            //if(e.KeyCode == Keys.E && e.Modifiers)
            if(e.KeyCode == Keys.E && e.Control) //ctrl E
            {
                this.Text = "waaaa";
            }

            //e.Handled = true;
        }
    }
}
