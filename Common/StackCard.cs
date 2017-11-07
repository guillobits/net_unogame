﻿using System;
using System.Collections.Generic;

namespace Common
{
    public class StackCard
    {
        private List<Card> _stack;

        public StackCard()
        {
            _stack = new List<Card>();
        }

        public void AddCard(Card card)
        {
            _stack.Add(card);
        }

        public Card GetRandomCard()
        {
            // Get Stack Lenght
            var lenght = _stack.Count;
            if (lenght == 0)
                throw new Exception("StackCard is empty");

            // Generate the index of the random card
            var random = new Random();
            var idxRandom = random.Next(0, lenght + 1);
            
            // Send the random card
            return (_stack.ToArray()[idxRandom]);
        }
        
        public Card PopRandomCard()
        {
            Card card = GetRandomCard();

            _stack.Remove(card);
            return (card);
        }

        public void GenerateDeck()
        {
            
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}