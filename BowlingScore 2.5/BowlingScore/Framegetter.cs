using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScore
{
    class Framegetter
    {

        public frame getplay(int index, Player currentplayer)
        {
            frame sender = new frame();
            switch (index)
            {
                case 1: sender = frame1(currentplayer, index); break;
                case 2: sender = frame1(currentplayer, index); break;
                case 3: sender = frame1(currentplayer, index); break;
                case 4: sender = frame1(currentplayer, index); break;
                case 5: sender = frame2(currentplayer, index); break;
                case 6: sender = frame2(currentplayer, index); break;
                case 7: sender = frame2(currentplayer, index); break;
                case 8: sender = frame2(currentplayer, index); break;
                case 9: sender = frame3(currentplayer, index); break;
                case 10: sender = frame3(currentplayer, index); break;
                case 11: sender = frame3(currentplayer, index); break;
                case 12: sender = frame3(currentplayer, index); break;
                case 13: sender = frame4(currentplayer, index); break;
                case 14: sender = frame4(currentplayer, index); break;
                case 15: sender = frame4(currentplayer, index); break;
                case 16: sender = frame4(currentplayer, index); break;
                case 17: sender = frame5(currentplayer, index); break;
                case 18: sender = frame5(currentplayer, index); break;
                case 19: sender = frame5(currentplayer, index); break;
                case 20: sender = frame5(currentplayer, index); break;
                case 21: sender = frame6(currentplayer, index); break;
                case 22: sender = frame6(currentplayer, index); break;
                case 23: sender = frame6(currentplayer, index); break;
                case 24: sender = frame6(currentplayer, index); break;
                case 25: sender = frame7(currentplayer, index); break;
                case 26: sender = frame7(currentplayer, index); break;
                case 27: sender = frame7(currentplayer, index); break;
                case 28: sender = frame7(currentplayer, index); break;
                case 29: sender = frame8(currentplayer, index); break;
                case 30: sender = frame8(currentplayer, index); break;
                case 31: sender = frame8(currentplayer, index); break;
                case 32: sender = frame8(currentplayer, index); break;
                case 33: sender = frame9(currentplayer, index); break;
                case 34: sender = frame9(currentplayer, index); break;
                case 35: sender = frame9(currentplayer, index); break;
                case 36: sender = frame9(currentplayer, index); break;
                case 37: sender = frame10(currentplayer, index); break;
                case 38: sender = frame10(currentplayer, index); break;
                case 39: sender = frame10(currentplayer, index); break;
                case 40: sender = frame10(currentplayer, index); break;
                case 41: sender = frame10(currentplayer, index); break;
                case 42: sender = frame10(currentplayer, index); break;
            }
            return sender;
        }
        public frame frame1(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame2(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame3(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame4(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame5(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame6(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame7(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame8(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame9(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
        public frame frame10(Player currentplayer, int index)
        {
            frame frame = new frame();

            return frame;
        }
    }
}
