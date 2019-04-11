using ServiceLayer.EnumList;

namespace ServiceLayer.Players.Interface
{
    public interface IComputerPlayer
    {
        SelectItemsEnum.Item getComputerChoosedItem();
    }
}
