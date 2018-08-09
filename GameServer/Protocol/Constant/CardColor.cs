﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.Constant
{
   public class CardColor
    {
        public const int NONE = 0;
        public const int CLUE = 1;//梅花
        public const int HEART = 2;//红桃
        public const int SPADE = 3;//黑桃
        public const int SQUARE = 4;//方片

        public static string GetString(int color)
        {
            switch (color)
            {
                case CLUE:
                    return "Clue";
                case HEART:
                    return "Heart";
                case SPADE:
                    return "Spade";
                case SQUARE:
                    return "Square";
                default:
                    throw new Exception("不存在这样的花色");
            }
        }
    }
}