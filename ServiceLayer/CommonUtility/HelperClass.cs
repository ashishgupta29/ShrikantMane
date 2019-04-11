using ServiceLayer.EnumList;

namespace ServiceLayer.CommonUtility
{
    public class HelperClass
    {
        public static SelectItemsEnum.Item getSelectedItemByPlayer(string item)
        {            
            switch (item.ToUpper())
            {
                case "ROCK":
                    return SelectItemsEnum.Item.ROCK;                   
                case "SCISSORS":
                    return SelectItemsEnum.Item.SCISSORS;
                case "PAPER":
                    return SelectItemsEnum.Item.PAPER;
                default:
                    return SelectItemsEnum.Item.NONE;
            }
        }

        
    }
}
