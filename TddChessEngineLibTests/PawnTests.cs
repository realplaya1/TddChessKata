using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            string startPosition = "E2";
            string finalPosition = "E4";
            FigureColor figureColor = FigureColor.White;

            Pawn pawn = new Pawn(startPosition, figureColor);

            pawn.Turn(startPosition, finalPosition, figureColor);

            Assert.Equal(finalPosition, pawn.CurrentPosition, figureColor);
        }
    }
}
