using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenguinDraft.Api.Models;

namespace PenguinDraft.Api.Services
{
  public interface ICardService
  {
    List<Card> GetAllCards();
    Card GetCardById(int cardId);
    List<Card> AddCard(Card newCard);
  }
}