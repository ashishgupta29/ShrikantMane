using System;
using ServiceLayer.EnumList;

namespace ServiceLayer.Players.Interface
{
    public class ComputerPlayer : IComputerPlayer
    {
        private Random randomNumber = new Random();        

        public SelectItemsEnum.Item getComputerChoosedItem()
        {
            switch (getRandomValueFromOneToThree())
            {
                case 1:
                    return SelectItemsEnum.Item.ROCK;
                case 2:
                    return SelectItemsEnum.Item.SCISSORS;
                default:
                    return SelectItemsEnum.Item.PAPER;
            }
        }

        private int getRandomValueFromOneToThree()
        {
            return randomNumber.Next(1, 4);
        }
    }
}
