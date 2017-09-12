using System.Windows.Forms;

namespace Exemplo2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Click += (s, e) =>
            {
                MessageBox.Show(
                    ((MouseEventArgs)e).Location.ToString());
            };
        }
    }
}
