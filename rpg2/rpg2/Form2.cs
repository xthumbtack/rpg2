using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rpg2
{
    public partial class Form2 : Form
    {
        public static int x = 0;
        public Form2()
        {
            InitializeComponent();
            runGame();
        }

        private void runGame()
        {
            dialogue_box.Text = Objects.text1[x];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void dialogue_box_TextChanged(object sender, EventArgs e)
        {
            dialogue_box.Text = Objects.text1[x];
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dialogue_box.Text = Objects.text1[x++];
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (x != 0) dialogue_box.Text = Objects.text1[x--];
            
        }
    }
}

