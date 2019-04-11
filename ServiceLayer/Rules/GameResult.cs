using ServiceLayer.CommonUtility;
using ServiceLayer.EnumList;
using ServiceLayer.Rules.Interface;
using System.Collections.Generic;

namespace ServiceLayer.Result
{
    public class GameResult : IResult, IFinalResult
    {
        List<string> listResult;
        
        public GameResult()
        {
            listResult = new List<string>();
        }

        public string getFinalResult()
        {
            int iCountTie = listResult.FindAll(x => x.Contains(ResultTypeEnum.Type.TIE_MATCH.ToString())).Count;
            int iCountFirstPlayer = listResult.FindAll(x => x.Contains(ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString())).Count;
            int iCountSecondPlayer = listResult.FindAll(x => x.Contains(ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString())).Count;

            if (iCountTie == listResult.Count)
                return Constant.TIE_GAME;
            else if (iCountFirstPlayer == iCountSecondPlayer)
                return Constant.EQUAL_GAME;
            else if (iCountFirstPlayer == 1 && iCountTie == 2)
                return Constant.ONLY_FIRST_PLAYER_WIN;
            else if (iCountSecondPlayer == 1 && iCountTie == 2)
                return Constant.ONLY_Second_PLAYER_WIN;
            else if(iCountFirstPlayer > iCountSecondPlayer)
                return Constant.FIRST_PLAYER_WIN.Replace("XXXX", iCountFirstPlayer.ToString());
            else
                return Constant.SECOND_PLAYER_WIN.Replace("XXXX", iCountSecondPlayer.ToString());
        }

        public string getResult(SelectItemsEnum.Item selectedItemByFirstPlayer, SelectItemsEnum.Item selectedItemBySecondPlayer)
        {
            IResult rule = new ServiceLayer.Rules.Result();
            var result = rule.getResult(selectedItemByFirstPlayer, selectedItemBySecondPlayer);

            listResult.Add(result);

            return result;
        }
    }
}
