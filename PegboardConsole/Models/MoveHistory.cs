using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegboardConsole.Models
{
    public class MoveHistory
    {
        public MoveHistory(byte[] boardState, int[] sequence,string sequenceHistory)
        {
            var bs = (byte[])boardState.Clone();
            bs[sequence[0]] = 0;
            bs[sequence[1]] = 0;
            bs[sequence[2]] = 1;
            this.BoardState = bs;
            this.Sequence = sequence;
            this.Winner = this.BoardState.Count(x => x == 1) == 1;
            this.SequenceHistory = $"{sequenceHistory}--From:{sequence[0]} Over:{sequence[1]} To: {sequence[2]}";
        }
        public byte[] BoardState { get; }
        public int[] Sequence { get; }
        public string SequenceHistory { get; }
        public bool Winner { get; }
    }
}
