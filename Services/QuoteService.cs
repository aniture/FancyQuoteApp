using System;
using System.Collections.Generic;
using FancyQuoteApp.Models;

namespace FancyQuoteApp.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly List<Quote> _quotes = new()
        {
            new Quote { Text = "The best error message is the one that never shows up.", Author = "Thomas Fuchs" },
            new Quote { Text = "It’s not a bug – it’s an undocumented feature.", Author = "Anonymous" },
            new Quote { Text = "Truth can only be found in one place: the code.", Author = "Robert C. Martin" },
            new Quote { Text = "Walking on water and developing software from a specification are easy if both are frozen.", Author = "Edward V. Berard" },
            new Quote { Text = "Deleted code is debugged code.", Author = "Jeff Sickel" },
            new Quote { Text = "Fix the cause, not the symptom.", Author = "Steve Maguire" },
            new Quote { Text = "Any fool can write code that a computer can understand. Good programmers write code that humans can understand.", Author = "Martin Fowler" },
            new Quote { Text = "Programming isn't about what you know; it's about what you can figure out.", Author = "Chris Pine" },
            new Quote { Text = "Make it work, make it right, make it fast.", Author = "Kent Beck" },
            new Quote { Text = "One man’s crappy software is another man’s full-time job.", Author = "Jessica Gaston" },
            
        };

        public Quote GetRandomQuote()
        {
            var random = new Random();
            return _quotes[random.Next(_quotes.Count)];
        }
    }
}