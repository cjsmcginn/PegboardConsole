using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PegboardConsole.Models;

namespace PegboardConsole.Services
{
    public class PegboardGameService
    {

        List<MoveHistory> moveHistory;
        List<string> WinningSequences;
        private int initialEmpty = 0;
        void Initialize()
        {
            var initial = (byte[])Constants.BOARD.Clone();
            WinningSequences = new List<string>();
            initial[initialEmpty] = 0;
            moveHistory = new List<MoveHistory>();
            moveHistory.AddRange(Move(String.Format("Starting Position {0}",initialEmpty), initial));
 

        }

        void Play()
        {
            var nextHistory = new List<MoveHistory>();

                moveHistory.ForEach(history =>
                {
                    var c = Move(history.SequenceHistory, history.BoardState);
                    foreach (var item in c)
                    {
                        if (!item.Winner)
                        {
                            nextHistory.Add(item);
                        }
                        else
                        {
                            WinningSequences.Add(item.SequenceHistory);
                        }
                    }
                });

            moveHistory = nextHistory;
            if (nextHistory.Any())
                Play();

        }

        static List<MoveHistory> Move(string sequenceHistory,byte[] boardState)
        {
            var result = new List<MoveHistory>();
            foreach (var seq in Constants.BOARD_MOVES)
            {
                if (boardState[seq[0]] == 1 && boardState[seq[1]] == 1 && boardState[seq[2]] == 0)
                {
                    result.Add(new MoveHistory(boardState, seq,sequenceHistory));
                }
            }
            return result;
        }

        public List<string> StartSimulation(int initialPeg)
        {
            
            if (initialPeg < 15)
            {
                initialEmpty = initialPeg;
            }

            Initialize();
            Play();
            return WinningSequences;
        }
    }
}
