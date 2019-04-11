using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceLayer.EnumList;
using ServiceLayer.Players.Interface;
using ServiceLayer.Result;
using ServiceLayer.Validation;

namespace UnitTestGame
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ValidInputItem()
        {
            IValidation vald = new Validation();
            Assert.IsTrue(vald.isValidChoosedItem("PAPER"));
        }

        [TestMethod]
        public void InValidInputItem()
        {
            IValidation vald = new Validation();
            Assert.IsFalse(vald.isValidChoosedItem("XXXX"));
        }

        [TestMethod]
        public void CheckGameComputerVsPlayer()
        {
            GameResult reslt = new GameResult();
            IComputerPlayer comPlayer = new ComputerPlayer();

            var firstPlayerItem = SelectItemsEnum.Item.ROCK;
            var secondPlayerItem = comPlayer.getComputerChoosedItem();

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString()) || result.Contains(ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString()) ||
                result.Contains(ResultTypeEnum.Type.TIE_MATCH.ToString())), true);
        }

        [TestMethod]
        public void CheckGameHumanPlayers()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.ROCK;
            var secondPlayerItem = SelectItemsEnum.Item.PAPER;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString()) || result.Contains(ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString()) ||
                result.Contains(ResultTypeEnum.Type.TIE_MATCH.ToString())), true);
        }

        [TestMethod]
        public void CheckGameRuleForRock_ValidInput()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.ROCK;
            var secondPlayerItem = SelectItemsEnum.Item.SCISSORS;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString())), true);
        }

        [TestMethod]
        public void CheckGameRuleForRock_InvalidInput()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.ROCK;
            var secondPlayerItem = SelectItemsEnum.Item.PAPER;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString())), true);
        }

        [TestMethod]
        public void CheckGameRuleForPaper_ValidInput()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.PAPER;
            var secondPlayerItem = SelectItemsEnum.Item.ROCK;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString())), true);
        }

        [TestMethod]
        public void CheckGameRuleForPaper_InvalidInput()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.PAPER;
            var secondPlayerItem = SelectItemsEnum.Item.SCISSORS;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString())), true);
        }

        [TestMethod]
        public void CheckGameRuleForScissors_ValidInput()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.SCISSORS;
            var secondPlayerItem = SelectItemsEnum.Item.PAPER;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString())), true);
        }

        [TestMethod]
        public void CheckGameRuleForScissors_InvalidInput()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.SCISSORS;
            var secondPlayerItem = SelectItemsEnum.Item.ROCK;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString())), true);
        }

        [TestMethod]
        public void CheckTieGame()
        {
            GameResult reslt = new GameResult();

            var firstPlayerItem = SelectItemsEnum.Item.SCISSORS;
            var secondPlayerItem = SelectItemsEnum.Item.SCISSORS;

            var result = reslt.getResult(firstPlayerItem, secondPlayerItem);

            Assert.AreEqual((result.Contains(ResultTypeEnum.Type.TIE_MATCH.ToString())), true);
        }
    }
}
