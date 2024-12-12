using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingvin
{
    public partial class Form1 : Form
    {
        List<Pingvin> allPingvin = new List<Pingvin>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            button1.Click += ButtonClick;
        }
        void ButtonClick(Object s, EventArgs e)
        {
            try
            {
                Pingvin onePingvin = new Pingvin(textBox1.Text, int.Parse(textBox2.Text));
                groupBox2.Controls.Add(onePingvin);
                onePingvin.Top = onePingvin.Height * allPingvin.Count;
                allPingvin.Add(onePingvin);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
