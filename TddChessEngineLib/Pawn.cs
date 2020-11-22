using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public string CurrentPosition {get; private set;}
        public FigureColor  figureColor {get;}
        public Pawn(string initialPosition, FigureColor figurecolor)
        {
            CurrentPosition = initialPosition;
            figureColor = figurecolor;
        }
        public void Turn(string startPosition, string finishPosition)
        {
            CurrentPosition = finishPosition;
        }

        
    }

    public enum FigureColor
    {
        White, Black
    }
}
