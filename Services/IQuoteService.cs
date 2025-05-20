using FancyQuoteApp.Models;

namespace FancyQuoteApp.Services
{
    public interface IQuoteService
    {
        Quote GetRandomQuote();
    }
}