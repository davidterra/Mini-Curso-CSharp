using System;
using System.Windows.Forms;

namespace Exemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Click += new EventHandler(OnClick);
        }

        void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(((MouseEventArgs)e).Location.ToString());
        }


    }
}
