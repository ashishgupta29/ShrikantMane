using ServiceLayer.EnumList;

namespace ServiceLayer.Rules.Interface
{
    public interface IResult
    {
        string getResult(SelectItemsEnum.Item selectedItemByFirstPlayer, SelectItemsEnum.Item selectedItemBySecondPlayer);
    }
}
