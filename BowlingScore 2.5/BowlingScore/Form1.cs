using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BowlingScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string SelectTextFile(string initialDirectory)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Select a text file";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = SelectTextFile("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundGameplay gameplay = new BackgroundGameplay(textBox1.Text);
            gameplay.Show();
            if (gameplay.getScore.close == true)
            {
                gameplay.Close();
            }
        }
    }
}
