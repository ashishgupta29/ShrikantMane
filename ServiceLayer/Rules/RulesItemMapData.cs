using System.Collections.Generic;
using ServiceLayer.EnumList;
using ServiceLayer.Rules.Interface;

namespace ServiceLayer.Rules
{
    public class RulesItemMapData: IRuleMapData
    {
        Dictionary<SelectItemsEnum.Item, SelectItemsEnum.Item> dictionaryMapRule;
        
        public Dictionary<SelectItemsEnum.Item, SelectItemsEnum.Item>  getItemMappedData()
        {
            dictionaryMapRule = new Dictionary<SelectItemsEnum.Item, SelectItemsEnum.Item>();

            dictionaryMapRule.Add(SelectItemsEnum.Item.ROCK, SelectItemsEnum.Item.SCISSORS);
            dictionaryMapRule.Add(SelectItemsEnum.Item.SCISSORS, SelectItemsEnum.Item.PAPER);
            dictionaryMapRule.Add(SelectItemsEnum.Item.PAPER, SelectItemsEnum.Item.ROCK);

            return dictionaryMapRule;
        }
    }
}
