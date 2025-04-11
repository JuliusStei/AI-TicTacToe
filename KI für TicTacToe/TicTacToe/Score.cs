using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Score
    {
        public int WinCountPlayer1 { get; set; } = 0;
        public int WinCountPlayer2 { get; set; } = 0;
        public int LossCountPlayer1 { get; set; } = 0;
        public int LossCountPlayer2 { get; set; } = 0;
        public int DrawCount { get; set; } = 0;
        public int GamesPlayedCount { get; set; } = 0;
        public Score() { }
        public void Reset()
        {
            WinCountPlayer1 = 0;
            WinCountPlayer2 = 0;
            LossCountPlayer1 = 0;
            LossCountPlayer2 = 0;
            DrawCount = 0;
            GamesPlayedCount = 0;
        }
    }
}
