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
        public List<frame> framesplayer1;
        public List<frame> framesplayer2;
        public Player player1 = new Player();
        public Player player2 = new Player();
        public List<int> allshoots = new List<int>();
        public List<int> shootsplayer1 = new List<int>();
        public List<int> shootsplayer2 = new List<int>();
        public ScoreDetection getScore = new ScoreDetection();
        public int totalplayer1;
        public int totalplayer2;
        public int currentplayer = 1;
        public int currentframe = 1;
        public int currentplayershoot = 1;
        public int whatever = 0;
        public Stack<int> turnstroller = new Stack<int>();

        public BackgroundGameplay(string directory)
        {
            InitializeComponent();
            getScore.scan(directory);
            this.framesplayer1 = getScore.playsPlayer1;
            this.framesplayer2 = getScore.playsPlayer2;
            this.player1 = getScore.Player1;
            this.player2 = getScore.Player2;
            getallframestogether(framesplayer1, framesplayer2);

        }
        public void getallframestogether(List<frame> player1, List<frame> player2)
        {
            for (int i = 0; i < 10; i++)
            {
                shootsplayer1.Add(player1[i].firstShoot);
                shootsplayer1.Add(player1[i].secodshoot); 
                allshoots.Add(player1[i].firstShoot);
                allshoots.Add(player1[i].secodshoot);
                if (i == 9)
                {
                    shootsplayer1.Add(player1[i].thirdshoot); 
                    allshoots.Add(player1[i].thirdshoot);
                }
                shootsplayer2.Add(player2[i].firstShoot);
                shootsplayer2.Add(player2[i].secodshoot); 
                allshoots.Add(player2[i].firstShoot);
                allshoots.Add(player2[i].secodshoot);
                if (i == 9)
                {
                    shootsplayer2.Add(player2[i].secodshoot);
                    allshoots.Add(player2[i].thirdshoot);
                }
            }
            allshoots.Reverse();
            foreach (int shoot in allshoots)
            {
                turnstroller.Push(shoot);
            }

            allshoots.Reverse();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Totalscoreframe5p2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turnstroller.Count == 0)
            {
                return;
            }
           switchtroller(turnstroller.Pop(), ref currentframe, currentplayer, ref currentplayershoot);
           
           if (currentplayer == 1)
           {
               God(player1, currentframe);
               if (currentplayershoot >= 2)
               for (int x = 0; x < framesplayer1.Count; x++ )
               {
                   if (framesplayer1[x].showinframe == currentframe)
                   {
                       switch (x)
                       {
                           case 0:
                         Totalscoreframe1p1.Text = framesplayer1[x].framescore.ToString();
                         Totalscoreframe1p1.Visible = true;
                         totalplayer1 += framesplayer1[x].framescore;
                         
                         break;
                           case 1: 
                                Totalscoreframe2p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe2p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 2: 
                                Totalscoreframe3p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe3p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 3:
                                Totalscoreframe4p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe4p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 4:
                                Totalscoreframe5p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe5p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 5: 
                                Totalscoreframe6p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe6p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 6: 
                                Totalscoreframe7p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe7p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 7: 
                                Totalscoreframe8p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe8p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 8: 
                                Totalscoreframe9p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe9p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                           case 9: 
                                Totalscoreframe10p1.Text = framesplayer1[x].framescore.ToString();
                       Totalscoreframe10p1.Visible = true;
                       totalplayer1 += framesplayer1[x].framescore;
                               break;
                       }
                     
                   }
                   
               }
           }
           else
           {
               God(player2, currentframe);
               if (currentplayershoot >= 2)
               for (int x = 0; x < framesplayer2.Count; x++)
               {
                   if (framesplayer2[x].showinframe == currentframe)
                   {
                       switch (x)
                       {
                           case 0:
                               Totalscoreframe1p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe1p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;

                               break;
                           case 1:
                               Totalscoreframe2p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe2p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 2:
                               Totalscoreframe3p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe3p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 3:
                               Totalscoreframe4p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe4p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 4:
                               Totalscoreframe5p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe5p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 5:
                               Totalscoreframe6p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe6p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 6:
                               Totalscoreframe7p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe7p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 7:
                               Totalscoreframe8p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe8p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 8:
                               Totalscoreframe9p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe9p2.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               break;
                           case 9:
                               Totalscoreframe10p2.Text = framesplayer2[x].framescore.ToString();
                               Totalscoreframe10p2.Visible = true;
                               Totalscoreframe10p1.Text = framesplayer1[x].framescore.ToString();
                               Totalscoreframe10p1.Visible = true;
                               totalplayer2 += framesplayer2[x].framescore;
                               totalplayer1 += framesplayer1[x].framescore;
                               break;
                       }

                   }
               }
            
           }

           if (currentplayershoot == 3)
           {

           }
           else
           {
               if (currentplayershoot == 2)
               {
                   currentplayershoot = 1;
               }
               else
               {
                   currentplayershoot++;
               }
           }
           Fullscoreplayer1.Text = totalplayer1.ToString();
           Fullscoreplayer2.Text = totalplayer2.ToString();
           if (currentframe == 11)
           {
               Currentgameframe.Text = "End";
           }
           else
           {
               Currentgameframe.Text = currentframe.ToString();
           }
        }
        public void switchtroller(int shoot, ref int currentframe, int currenplayer, ref int currentshoot)
        {
            switch (currentframe)
            {
                case 1:
                    if (currentplayer==1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame1p1.Text = shoot.ToString();
                            Shoot1frame1p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame1p1.Text = shoot.ToString();
                            Shoot2frame1p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame1p2.Text = shoot.ToString();
                            Shoot1frame1p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame1p2.Text = shoot.ToString();
                            Shoot2frame1p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;
                        }
                    }
                                 
                    break;
                case 2:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame2p1.Text = shoot.ToString();
                            Shoot1frame2p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame2p1.Text = shoot.ToString();
                            Shoot2frame2p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame2p2.Text = shoot.ToString();
                            Shoot1frame2p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame2p2.Text = shoot.ToString();
                            Shoot2frame2p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;
                        }
                    }
                    break;
                case 3:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame3p1.Text = shoot.ToString();
                            Shoot1frame3p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame3p1.Text = shoot.ToString();
                            Shoot2frame3p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame3p2.Text = shoot.ToString();
                            Shoot1frame3p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame3p2.Text = shoot.ToString();
                            Shoot2frame3p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;
                        }
                    }
                    break;
                case 4:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame4p1.Text = shoot.ToString();
                            Shoot1frame4p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame4p1.Text = shoot.ToString();
                            Shoot2frame4p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame4p2.Text = shoot.ToString();
                            Shoot1frame4p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame4p2.Text = shoot.ToString();
                            Shoot2frame4p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;
                        }
                    }
                    break;
                case 5:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame5p1.Text = shoot.ToString();
                            Shoot1frame5p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame5p1.Text = shoot.ToString();
                            Shoot2frame5p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame5p2.Text = shoot.ToString();
                            Shoot1frame5p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame5p2.Text = shoot.ToString();
                            Shoot2frame5p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;

                        }
                    }
                    break;
                case 6:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame6p1.Text = shoot.ToString();
                            Shoot1frame6p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame6p1.Text = shoot.ToString();
                            Shoot2frame6p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame6p2.Text = shoot.ToString();
                            Shoot1frame6p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame6p2.Text = shoot.ToString();
                            Shoot2frame6p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;

                        }
                    }
                    break;
                case 7:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame7p1.Text = shoot.ToString();
                            Shoot1frame7p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame7p1.Text = shoot.ToString();
                            Shoot2frame7p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame7p2.Text = shoot.ToString();
                            Shoot1frame7p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame7p2.Text = shoot.ToString();
                            Shoot2frame7p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;

                        }
                    }
                    break;
                case 8:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame8p1.Text = shoot.ToString();
                            Shoot1frame8p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame8p1.Text = shoot.ToString();
                            Shoot2frame8p1.Visible = true;
                            currentplayer = 2;
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame8p2.Text = shoot.ToString();
                            Shoot1frame8p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame8p2.Text = shoot.ToString();
                            Shoot2frame8p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;

                        }
                    }
                    break;
                case 9:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame9p1.Text = shoot.ToString();
                            Shoot1frame9p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame9p1.Text = shoot.ToString();
                            Shoot2frame9p1.Visible = true;
                            currentplayer = 2;
                            
                        }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame9p2.Text = shoot.ToString();
                            Shoot1frame9p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame9p2.Text = shoot.ToString();
                            Shoot2frame9p2.Visible = true;
                            currentplayer = 1;
                            currentframe++;
                            currentshoot = 0;

                        }
                    }
                    break;
                case 10:
                    if (currentplayer == 1)
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame10p1.Text = shoot.ToString();
                            Shoot1frame10p1.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame10p1.Text = shoot.ToString();
                            Shoot2frame10p1.Visible = true;
                            
                          
                        }
                        if (currentshoot == 3)
                        {
                            Shoot3frame10p1.Text = shoot.ToString();
                            Shoot3frame10p1.Visible = true;
                            currentplayer = 2;
                            currentshoot = 0;
                        }
                        if (currentshoot == 2) { currentshoot = 3; }
                    }
                    else
                    {
                        if (currentshoot == 1)
                        {
                            Shoot1frame10p2.Text = shoot.ToString();
                            Shoot1frame10p2.Visible = true;
                        }
                        if (currentshoot == 2)
                        {
                            Shoot2frame10p2.Text = shoot.ToString();
                            Shoot2frame10p2.Visible = true;
                            

                        }
                        if (currentshoot == 3)
                        {
                            Shoot3frame10p2.Text = shoot.ToString();
                            Shoot3frame10p2.Visible = true;
                            currentframe++;
                        }
                        if (currentshoot == 2) { currentshoot = 3; }
                    }
                    break;
            }
        }
        public void God(Player player,int currentframe)
        {
            int whatever = 0;
            switch (currentframe)
            {
                case 1:
                    if (player.Frame1.strike == true)
                    {
                        if (player.Frame2.strike == true)
                        {
                            whatever = player.Frame1.firstShoot + player.Frame2.firstShoot + player.Frame3.firstShoot;
                            player.Frame1.showinframe = 4;
                        }
                        else
                        {
                            whatever = player.Frame1.firstShoot + player.Frame2.firstShoot + player.Frame2.secodshoot;
                            player.Frame1.showinframe = 3;
                        }
                    }
                    if (player.Frame1.spare == true)
                    {
                        whatever = player.Frame1.firstShoot + player.Frame1.secodshoot + player.Frame2.firstShoot;
                        player.Frame1.showinframe = 3;
                    }
                    if (player.Frame1.strike == false && player.Frame1.spare == false)
                    {
                        whatever = player.Frame1.firstShoot + player.Frame1.secodshoot;
                        player.Frame1.showinframe = 2;
                    }
                    player.Frame1.framescore = whatever;
                    break;
                case 2:
                    if (player.Frame2.strike == true)
                    {
                        if (player.Frame3.strike == true)
                        {
                            whatever = player.Frame2.firstShoot + player.Frame3.firstShoot + player.Frame4.firstShoot;
                            player.Frame2.showinframe = 5;
                        }
                        else
                        {
                            whatever = player.Frame2.firstShoot + player.Frame3.firstShoot + player.Frame3.secodshoot;
                            player.Frame2.showinframe = 4;
                        }
                    }
                    if (player.Frame2.spare == true)
                    {
                        whatever = player.Frame2.firstShoot + player.Frame2.secodshoot + player.Frame3.firstShoot;
                        player.Frame2.showinframe = 4;
                    }
                    if (player.Frame2.strike == false && player.Frame2.spare == false)
                    {
                        whatever = player.Frame2.firstShoot + player.Frame2.secodshoot;
                        player.Frame2.showinframe = 3;
                    }
                    player.Frame2.framescore = whatever;
                    break;
                case 3:
                    if (player.Frame3.strike == true)
                    {
                        if (player.Frame4.strike == true)
                        {
                            whatever = player.Frame3.firstShoot + player.Frame4.firstShoot + player.Frame5.firstShoot;
                            player.Frame3.showinframe = 6;
                        }
                        else
                        {
                            whatever = player.Frame3.firstShoot + player.Frame4.firstShoot + player.Frame4.secodshoot;
                            player.Frame3.showinframe = 5;
                        
                        }
                    }
                    if (player.Frame3.spare == true)
                    {
                        whatever = player.Frame3.firstShoot + player.Frame3.secodshoot + player.Frame4.firstShoot;
                        player.Frame3.showinframe = 5;
                        
                    }
                    if (player.Frame3.strike == false && player.Frame3.spare == false)
                    {
                        whatever = player.Frame3.firstShoot + player.Frame3.secodshoot;
                        player.Frame3.showinframe = 4;
                        
                    }
                    player.Frame3.framescore = whatever;
                    break;
                case 4:
                    if (player.Frame4.strike == true)
                    {
                        if (player.Frame5.strike == true)
                        {
                            whatever = player.Frame4.firstShoot + player.Frame5.firstShoot + player.Frame6.firstShoot;
                            player.Frame4.showinframe = 7;
                        
                        }
                        else
                        {
                            whatever = player.Frame4.firstShoot + player.Frame5.firstShoot + player.Frame5.secodshoot;
                            player.Frame4.showinframe = 6;
                        }
                    }
                    if (player.Frame4.spare == true)
                    {
                        whatever = player.Frame4.firstShoot + player.Frame4.secodshoot + player.Frame5.firstShoot;
                        player.Frame4.showinframe = 6;
                    }
                    if (player.Frame4.strike == false && player.Frame4.spare == false)
                    {
                        whatever = player.Frame4.firstShoot + player.Frame4.secodshoot;
                        player.Frame4.showinframe = 5;
                    }
                    player.Frame4.framescore = whatever;
                    break;
                case 5:
                    if (player.Frame5.strike == true)
                    {
                        if (player.Frame6.strike == true)
                        {
                            whatever = player.Frame5.firstShoot + player.Frame6.firstShoot + player.Frame7.firstShoot;
                            player.Frame5.showinframe = 8;
                        }
                        else
                        {
                            whatever = player.Frame5.firstShoot + player.Frame6.firstShoot + player.Frame6.secodshoot;
                            player.Frame5.showinframe = 7;
                        }
                    }
                    if (player.Frame5.spare == true)
                    {
                        whatever = player.Frame5.firstShoot + player.Frame5.secodshoot + player.Frame6.firstShoot;
                        player.Frame5.showinframe = 7;
                    }
                    if (player.Frame5.strike == false && player.Frame5.spare == false)
                    {
                        whatever = player.Frame5.firstShoot + player.Frame5.secodshoot;
                        player.Frame5.showinframe = 6;
                    }
                    player.Frame5.framescore = whatever;
                    break;
                case 6:
                    if (player.Frame6.strike == true)
                    {
                        if (player.Frame7.strike == true)
                        {
                            whatever = player.Frame6.firstShoot + player.Frame7.firstShoot + player.Frame8.firstShoot;
                            player.Frame6.showinframe = 9;
                        }
                        else
                        {
                            whatever = player.Frame6.firstShoot + player.Frame7.firstShoot + player.Frame7.secodshoot;
                            player.Frame6.showinframe = 8;
                        }
                    }
                    if (player.Frame6.spare == true)
                    {
                        whatever = player.Frame6.firstShoot + player.Frame6.secodshoot + player.Frame7.firstShoot;
                        player.Frame6.showinframe = 8;
                    }
                    if (player.Frame6.strike == false && player.Frame6.spare == false)
                    {
                        whatever = player.Frame6.firstShoot + player.Frame6.secodshoot;
                        player.Frame6.showinframe = 7;
                    }
                    player.Frame6.framescore = whatever;
                    break;
                case 7:
                    if (player.Frame7.strike == true)
                    {
                        if (player.Frame8.strike == true)
                        {
                            whatever = player.Frame7.firstShoot + player.Frame8.firstShoot + player.Frame9.firstShoot;
                            player.Frame7.showinframe = 10;
                        }
                        else
                        {
                            whatever = player.Frame7.firstShoot + player.Frame8.firstShoot + player.Frame8.secodshoot;
                            player.Frame7.showinframe = 9;
                        }
                    }
                    if (player.Frame7.spare == true)
                    {
                        whatever = player.Frame7.firstShoot + player.Frame7.secodshoot + player.Frame8.firstShoot;
                        player.Frame7.showinframe = 9;
                    }
                    if (player.Frame7.strike == false && player.Frame7.spare == false)
                    {
                        whatever = player.Frame7.firstShoot + player.Frame7.secodshoot;
                        player.Frame7.showinframe = 8;
                    }
                    player.Frame7.framescore = whatever;
                    break;
                case 8:
                    if (player.Frame8.strike == true)
                    {
                        if (player.Frame9.strike == true)
                        {
                            whatever = player.Frame8.firstShoot + player.Frame9.firstShoot + player.Frame10.firstShoot;
                            player.Frame8.showinframe = 10;
                        }
                        else
                        {
                            whatever = player.Frame8.firstShoot + player.Frame9.firstShoot + player.Frame9.secodshoot;
                            player.Frame8.showinframe = 10;
                        }
                    }
                    if (player.Frame8.spare == true)
                    {
                        whatever = player.Frame8.firstShoot + player.Frame8.secodshoot + player.Frame9.firstShoot;
                        player.Frame8.showinframe = 10;
                    }
                    if (player.Frame8.strike == false && player.Frame8.spare == false)
                    {
                        whatever = player.Frame8.firstShoot + player.Frame8.secodshoot;
                        player.Frame8.showinframe = 9;
                    }
                    player.Frame8.framescore = whatever;break;
                case 9:
                    if (player.Frame9.strike == true)
                    {
                        if (player.Frame10.strike == true)
                        {
                            whatever = player.Frame9.firstShoot + player.Frame10.firstShoot + player.Frame10.secodshoot;
                            player.Frame9.showinframe = 10;
                        }
                        else
                        {
                            whatever = player.Frame9.firstShoot + player.Frame10.firstShoot + player.Frame10.secodshoot;
                            player.Frame9.showinframe = 10;
                        }
                    }
                    if (player.Frame9.spare == true)
                    {
                        whatever = player.Frame9.firstShoot + player.Frame9.secodshoot + player.Frame10.firstShoot;
                        player.Frame9.showinframe = 10;
                    }
                    if (player.Frame9.strike == false && player.Frame9.spare == false)
                    {
                        whatever = player.Frame9.firstShoot + player.Frame9.secodshoot;
                        player.Frame9.showinframe = 10;
                    }
                    player.Frame9.framescore = whatever;break;
                case 10:
                    if (player.Frame10.strike == true)
                    {
                        whatever = player.Frame10.firstShoot + player.Frame10.secodshoot + player.Frame10.thirdshoot;
                        player.Frame10.showinframe = 11;
                    }
                    if (player.Frame10.spare == true)
                    {
                        whatever = player.Frame10.firstShoot + player.Frame10.secodshoot + player.Frame10.thirdshoot;
                        player.Frame10.showinframe = 11;
                    }
                    if (player.Frame10.strike == false && player.Frame10.spare == false)
                    {
                        whatever = player.Frame10.firstShoot + player.Frame10.secodshoot;
                        player.Frame10.showinframe = 11;
                    }
                    player.Frame10.framescore = whatever;
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry :(, proximamente");
        }
           }
}
