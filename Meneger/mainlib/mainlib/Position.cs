﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mainlib
{
    public class Position
    {
        private static int[,] playerX = new int[3, 40] { {579,523,472,416,364,312,259,206,156,104,22,22,22,22,22,22,22,22,22,22,22,127,
            179,231,284,337,388,439,492,541,623,623,623,623,623,623,623,623,623,623} ,
            {579,523,472,416,364,312,259,206,156,104,22,22,22,22,22,22,22,22,22,22,22,127,179,231,284,337,388,439,492,541,623,598,
             598,598,598,598,598,598,598,598} ,{601,532,488,429,380,327,272,227,169,119,39,32,35,35,35,35,35,35,35,35,35,106,159,215,
            263,314,365,413,467,521,603,605,605,605,605,605,605,605,605,605} };
        private static int[,] playerY = new int[3, 40] { {616,616,616,616,616,616,616,616,616,616,616,544,492,439,387,335,284,229,177,126,
            45,45,45,45,45,45,45,45,45,45,45,151,202,256,304,357,412,461,510,567},{640,640,640,640,640,640,640,640,640,640,640,568,
            516,464,411,359,308,253,201,150,69,69,69,69,69,69,69,69,69,69,69,151,202,256,309,357,412,461,510,567},{630,630,630,630,
            630,630,630,630,630,630,630,567,510,462,410,353,305,251,195,148,52,52,52,52,52,52,52,52,52,52,64,127,180,230,281,337,387,441,492,548} };


        public  int GetPlayerCoordinateX(int player,int position)
        {
            return playerX[player,position];
        }
        public  int GetPlayerCoordinateY(int player, int position)
        {
            return playerY[player, position];
        }

    }
}
