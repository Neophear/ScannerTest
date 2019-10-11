using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScannerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            textBox1.Text += Environment.NewLine + e.KeyData;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text += Environment.NewLine + e.KeyCode;
        }
    }
}
