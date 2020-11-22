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
        public void Turn(string startPosition, string finalPosition, FigureColor figureColor)
        {
            if(figureColor == FigureColor.White)
            {
                if(CurrentPosition[1]==2)
                {
                    if(finalPosition[1]<=4 && finalPosition[1] > 2)
                    {
                        Console.WriteLine($"пешка перешла с {CurrentPosition} на {finalPosition}");
                        CurrentPosition = finalPosition;
                    }
                }
                else
                {
                    if((int)finalPosition[1]==(int)CurrentPosition[1]+1)
                    {
                        Console.WriteLine($"пешка перешла с {CurrentPosition} на {finalPosition}");
                        CurrentPosition = finalPosition;
                    }
                }
            }
        }

        
    }

    public enum FigureColor
    {
        White, Black
    }
}
