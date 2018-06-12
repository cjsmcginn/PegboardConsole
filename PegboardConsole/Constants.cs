using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegboardConsole
{
    public class Constants
    {
        #region board and moves
        public static readonly byte[] BOARD = new byte[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        public static readonly int[][] BOARD_MOVES = new int[][]
        {
            new int[]{0,1,3},
            new int[]{0,2,5},
            new int[]{1,3,6},
            new int[]{1,4,8},
            new int[]{2,4,7},
            new int[]{2,5,9},
            new int[]{3,1,0},
            new int[]{3,4,5},
            new int[]{3,6,10},
            new int[]{3,7,12},
            new int[]{4,7,11},
            new int[]{4,8,13},
            new int[]{5,2,0},
            new int[]{5,4,3},
            new int[]{5,8,12},
            new int[]{5,9,14},
            new int[]{6,3,1},
            new int[]{6,7,8},
            new int[]{7,4,2},
            new int[]{7,8,9},
            new int[]{8,4,1},
            new int[]{8,7,6},
            new int[]{9,5,2},
            new int[]{9,8,7},
            new int[]{10,6,3},
            new int[]{10,11,12},
            new int[]{11,7,4},
            new int[]{11,12,13},
            new int[]{12,7,3},
            new int[]{12,8,5},
            new int[]{12,11,10},
            new int[]{12,13,14},
            new int[]{13,8,4},
            new int[]{13,12,11},
            new int[]{14,9,5},
            new int[]{14,13,12}
        };
        #endregion
    }
}
