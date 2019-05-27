using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Preview;
using System.Threading;

namespace UnitTestPreview
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Subtitle_NotDelay()
        {
            
            Player player = new Player();
            player.Outputfile = @"C:\Users\nln10\Videos\Marvel Studios Avengers Endgame - Official Trailer";
            player.subtitle();
           
            Assert.IsNotNull(Player.Sub);
        }
        [TestMethod]
        public void Test_Subtitle_delay()
        {

            Player player = new Player();
            player.Outputfile = @"C:\Users\nln10\Videos\Marvel Studios Avengers Endgame - Official Trailer";
            player.subtitle();
            Thread.Sleep(15000);
            Assert.IsNull(Player.Sub);
        }
    }
}
