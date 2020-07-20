﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        //The below method is trying to return a list of all the possible moves you can make with a pawn.
        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
           return new List<Square>
           {
            Square.At(3, 0),
            Square.At(5, 0)
           };
        } 
    }
}




    // The below is a simplfied but longer way of creating a list that returns moves the pawns can make in certain squares.
    //   public override IEnumerable<Square> GetAvailableMoves(Board board)
    //     {
    //         List<Square> PawnMoves = new List<Square>();

    //         PawnMoves.Add(Square.At(3, 0));
    //         PawnMoves.Add(Square.At(5, 0));
    //         return PawnMoves;        
    //     }


   