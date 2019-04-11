using ServiceLayer.EnumList;
using System.Collections.Generic;

namespace ServiceLayer.Rules.Interface
{
    public interface IRuleMapData
    {
        Dictionary<SelectItemsEnum.Item, SelectItemsEnum.Item> getItemMappedData();
    }
}
