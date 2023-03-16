using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenguinDraft.Api.Models;

namespace PenguinDraft.Api.Interfaces
{
  public interface ICardRepository
  {
    ICollection<Card> GetAllCards();
    Card GetCardById(int Id);
    Card GetCardByName(string name);
    bool CardExists(int cardId);
    bool Save();
  }
}