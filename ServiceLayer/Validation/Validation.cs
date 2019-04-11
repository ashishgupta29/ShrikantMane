using ServiceLayer.CommonUtility;
using ServiceLayer.EnumList;

namespace ServiceLayer.Validation
{
    public class Validation: IValidation
    {
        public bool isValidChoosedItem(string item)
        {
            if (HelperClass.getSelectedItemByPlayer(item) == SelectItemsEnum.Item.NONE)
                return false;
            else
                return true;
        }
    }
}
