﻿using System;

namespace Oblig2
{
    public class Rook : Piece
    {
        //Base = sender informasjon fra parameter til symbol i Piece class (class som blir arvet)
        public Rook() : base("TRN")
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}

//public bool Move(string fromPosition, string toPosition)
//{
//    if (_type == "Rook") return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
//    if (_type == "Bishop")
//    {
//        var diffCol = fromPosition[0] - toPosition[0];
//        var diffRow = fromPosition[1] - toPosition[1];
//        return Math.Abs(diffRow) == Math.Abs(diffCol);
//    }
//    return true;
//}