using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenguinDraft.Api.Models;

namespace PenguinDraft.Api.Services
{
  public class CardService : ICardService
  {

    private static List<Card> cards = new List<Card> {
        new Card { Name = "Counterspell" },
        new Card { Id = 1, Name = "Arcane Signet"}
    };
    public List<Card> AddCard(Card newCard)
    {
      cards.Add(newCard);
      return cards;
    }

    public List<Card> GetAllCards()
    {
      return cards;
    }

    public Card GetCardById(int cardId)
    {
      var card = cards.FirstOrDefault(c => c.Id == cardId);
      if (card is not null)
        return card;

      throw new Exception("Card not found");
    }
  }
}