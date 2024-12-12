using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingvin
{
    class Pingvin : UserControl
    {
        private Label label1;
        private Label label2;
        private Button button1;

        public string name { get; private set; }
        public int age { get; set; }
        public Pingvin(string name, int age)
        {
            InitializeComponent();
            if (name.Length > 0)
                this.name = name;
            else
                throw new Exception("Nincs neve a pingvinnek");
            this.age = age;
            label1.Text += name;
            label2.Text += age;
            button1.Click += PingvinHello;
        }
        void PingvinHello(Object s, EventArgs e)
        {
            MessageBox.Show($"Szia, {name} vagyok");
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kor:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Köszönj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pingvin
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pingvin";
            this.Size = new System.Drawing.Size(268, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
