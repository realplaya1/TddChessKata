using System;
using TddChessEngineLib;
using Xunit;
namespace TddChessEngineLibTests
{
    
    public class RookTests
    {
        [Fact]
        public void RookInit()
        {
            string initPos = "A1";

            Rook rook = new Rook(initPos);

            if (initPos[1] < 8 && initPos[1] > 1)
            {
                Assert.Equal(initPos, rook.currPos);
            }

        }
    }
}