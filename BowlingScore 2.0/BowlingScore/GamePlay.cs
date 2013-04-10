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
    public partial class BackgroundGameplay : Form
    {
        public Player player1;
        public Player player2;
        public ScoreDetection getScore = new ScoreDetection();
        int index = 1, currentplayer = 1;
        int totalscoreplayer1 = 0;
        int totalscoreplayer2 = 0;
        int currentframe = 1;
        public BackgroundGameplay(string directory)
        {
            InitializeComponent();
            getScore.scan(directory);
            this.player1 = getScore.Player1;
            this.player2 = getScore.Player2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Totalscoreframe5p2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
