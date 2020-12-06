using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class ElephantTest
    {
        [Fact]
        public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
        {
           string initPos = "E2";

           Elephant elephant = new Elephant(initPos);

           Assert.Equal(initPos, elephant.currentPosition);
        }

        [Fact]
        public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
        {
            string initPos = "E9";

             Elephant elephant = new Elephant(initPos);

            Assert.Throws<Exception>(initPos, elephant.currentPosition);
        }
    }
}