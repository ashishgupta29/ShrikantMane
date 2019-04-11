using System.Linq;
using ServiceLayer.EnumList;
using ServiceLayer.Rules.Interface;

namespace ServiceLayer.Rules
{
    public class Result : IResult
    {
        public string getResult(SelectItemsEnum.Item selectedItemByFirstPlayer, SelectItemsEnum.Item selectedItemBySecondPlayer)
        {
            IRuleMapData mappedData = new RulesItemMapData();
                        
            if (selectedItemByFirstPlayer == selectedItemBySecondPlayer)
                return ResultTypeEnum.Type.TIE_MATCH.ToString();            
            else if ((mappedData.getItemMappedData()).SingleOrDefault(x=> x.Key == selectedItemByFirstPlayer).Value == selectedItemBySecondPlayer)
                return ResultTypeEnum.Type.FIRST_PLAYER_WIN.ToString();
            else
                return ResultTypeEnum.Type.SECOND_PLAYER_WIN.ToString();            
        }
    }
}
