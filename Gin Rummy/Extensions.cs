﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gin_Rummy
{
    public static class Extensions
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }
    }
}