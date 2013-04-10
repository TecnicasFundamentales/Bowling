using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BowlingScore
{
    public class ScoreDetection
    {
        public Player Player1 = new Player();
        public Player Player2 = new Player();
        List<frame> playsPlayer1 = new List<frame>();
        List<frame> playsPlayer2 = new List<frame>();
        List<frame> extraframes = new List<frame>();
        public bool longgame = false;
        public bool close = false;
        public void scan(string directory)
        {
            scoreasign(getPlays(directory));
            if (close == true)
            {
                return;
            }
            scoredistribution();
        }
        public List<int> getPlays(string directory)
        {
            string line;
            List<int> jugadas = new List<int>();
            StreamReader read = new StreamReader(directory);
            while ((line = read.ReadLine()) != null)
            {
                if (line == "")
                {
                    continue;
                }
                if (line == "0" || line == "1" || line == "2" || line == "3" || line == "4" || line == "5" || line == "6" 
                    || line == "7" || line == "8" || line == "9" || line == "10")
                {
                        jugadas.Add(Convert.ToInt32(line));
                }
                else
                {

                }
            }
            return jugadas;
        }
        public void scoreasign(List<int> jugadas)
        {
            if (jugadas.Count == 0)
            {
                MessageBox.Show("Wrong values, please select an autentic plays file");
                close = true;
                return;
            }
            if (jugadas.Count >= 40 && jugadas.Count <= 42)
            {
                if (jugadas.Count > 40)
                {
                    longgame = true;
                }
                int countplays = 0;
                frame frame;
                for (int i = 0; i < jugadas.Count; i++)
                {
                    if (i < 36)
                    {
                        if (countplays == 0)
                        {
                            frame = new frame();
                            frame.firstShoot = jugadas[i];
                            i++;
                            frame.secodshoot = jugadas[i];
                            playsPlayer1.Add(frame);
                            countplays = 1;
                            continue;
                        }
                        if (countplays == 1)
                        {
                            frame = new frame();
                            frame.firstShoot = jugadas[i];
                            i++;
                            frame.secodshoot = jugadas[i];
                            playsPlayer2.Add(frame);
                            countplays = 0;
                        }
                    }
                    else
                    {
                        if (countplays == 0)
                        {
                            frame = new frame();
                            frame.firstShoot = jugadas[i];
                            i++;
                            frame.secodshoot = jugadas[i];
                            i++;
                            frame.thirthshoot = jugadas[i];
                            playsPlayer1.Add(frame);
                            countplays = 1;
                            continue;
                        }
                        if (countplays == 1)
                        {
                            frame = new frame();
                            frame.firstShoot = jugadas[i];
                            i++;
                            frame.secodshoot = jugadas[i];
                            i++;
                            frame.thirthshoot = jugadas[i];
                            playsPlayer2.Add(frame);
                            countplays = 0;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("this is not a full game, please select a full game");
                close = true;
                return;
            }

        }
        public void scoredistribution()
        {
            Player1.Frame1 = assignStrikeorSpare(playsPlayer1[0]);
            Player1.Frame2 = assignStrikeorSpare(playsPlayer1[1]);
            Player1.Frame3 = assignStrikeorSpare(playsPlayer1[2]);
            Player1.Frame4 = assignStrikeorSpare(playsPlayer1[3]);
            Player1.Frame5 = assignStrikeorSpare(playsPlayer1[4]);
            Player1.Frame6 = assignStrikeorSpare(playsPlayer1[5]);
            Player1.Frame7 = assignStrikeorSpare(playsPlayer1[6]);
            Player1.Frame8 = assignStrikeorSpare(playsPlayer1[7]);
            Player1.Frame9 = assignStrikeorSpare(playsPlayer1[8]);
            Player1.Frame10 = assignStrikeorSpare(playsPlayer1[9]);

            Player2.Frame1 = assignStrikeorSpare(playsPlayer2[0]);
            Player2.Frame2 = assignStrikeorSpare(playsPlayer2[1]);
            Player2.Frame3 = assignStrikeorSpare(playsPlayer2[2]);
            Player2.Frame4 = assignStrikeorSpare(playsPlayer2[3]);
            Player2.Frame5 = assignStrikeorSpare(playsPlayer2[4]);
            Player2.Frame6 = assignStrikeorSpare(playsPlayer2[5]);
            Player2.Frame7 = assignStrikeorSpare(playsPlayer2[6]);
            Player2.Frame8 = assignStrikeorSpare(playsPlayer2[7]);
            Player2.Frame9 = assignStrikeorSpare(playsPlayer2[8]);
            Player2.Frame10 = assignStrikeorSpare(playsPlayer2[9]);

        }
        public frame assignStrikeorSpare(frame frame)
        {
            if (frame.firstShoot == 10)
            {
                frame.strike = true;
            }
            if (frame.firstShoot + frame.secodshoot == 10 && frame.secodshoot != 0)
            {
                frame.spare = true;
            }
            return frame;
        }
    }
}
