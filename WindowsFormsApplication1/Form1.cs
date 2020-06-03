using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恭喜你拥有一名可爱的男朋友~~", "^v^");
            this.Dispose();
        }
        private static int times; //
        private void button2_Click(object sender, EventArgs e)
        {
            times++;
            if (times == 1)
                MessageBox.Show("保大！", "(>▽<)");
            else if (times == 2)
                MessageBox.Show("房产证写你名！", "(>▽<)");
            else if (times == 3)
                MessageBox.Show("工资全给你！", "(>▽<)");
            else if (times == 4)
            {
                MessageBox.Show("只爱你一个！", "(>▽<)");
                times = 0;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            Random r = new Random();
            button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("不回答不能退出哦！", "(╯_╰)╭");
            e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }
    }
}
