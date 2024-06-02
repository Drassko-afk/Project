using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        public string TableName { get; private set; }

        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TableName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
