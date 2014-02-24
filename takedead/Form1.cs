using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takedead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form form1 = new Form();
            Label lbl1 = new Label();
            lbl1.Text = "NO SEAS MALVADO";
            lbl1.Size = new System.Drawing.Size(200, 70);
            

            form1.BackColor = Color.Black;

            string message = "No debes hacer esto!";
            form1.Text = message;
            form1.Size = new System.Drawing.Size(550, 450);
            this.textBox2 = new System.Windows.Forms.TextBox();
            lbl1.Location = new System.Drawing.Point(87, 65);
            lbl1.BackColor = Color.Red;
            lbl1.Text = message;
            
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
