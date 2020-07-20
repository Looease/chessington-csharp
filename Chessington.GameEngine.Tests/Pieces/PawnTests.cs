﻿using Chessington.GameEngine.Pieces;
 using FluentAssertions;
 using NUnit.Framework;

namespace Chessington.GameEngine.Tests.Pieces
{
    [TestFixture]
    public class PawnTests
    {
        [Test]
        // This test is testing whether a piece on square 4 can move to square 3
        // It is testing taht 3, 0 is a valid move for this pawn
        //The reason is is testing if this works is because we hardcoded that in on Pawn.CS.
        public void WhitePawns_CanMoveOneSquareUp()
        {
            var board = new Board();
            var pawn = new Pawn(Player.White);
            board.AddPiece(Square.At(4, 0), pawn);

            var moves = pawn.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(3, 0));
        }

        [Test]
        public void BlackPawns_CanMoveOneSquareDown()
        {
            var board = new Board();
            var pawn = new Pawn(Player.Black);
            board.AddPiece(Square.At(4, 0), pawn);

            var moves = pawn.GetAvailableMoves(board);

            moves.Should().Contain(Square.At(5, 0));
        }
    }
}