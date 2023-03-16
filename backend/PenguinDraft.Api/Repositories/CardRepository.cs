using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenguinDraft.Api.Data;
using PenguinDraft.Api.Interfaces;
using PenguinDraft.Api.Models;

namespace PenguinDraft.Api.Repositories
{
  public class CardRepository : ICardRepository
  {
    private readonly ApplicationDbContext _context;
    public CardRepository(ApplicationDbContext context)
    {
      _context = context;
    }

    public bool CardExists(int cardId)
    {
      return _context.Cards.Any(c => c.Id == cardId);
    }

    public ICollection<Card> GetAllCards()
    {
      return _context.Cards.OrderBy(c => c.Id).ToList();
    }

    public Card GetCardById(int Id)
    {
      return _context.Cards.Where(c => c.Id == Id).FirstOrDefault();
    }

    public Card GetCardByName(string name)
    {
      return _context.Cards.Where(c => c.Name == name).FirstOrDefault();
    }

    public bool Save()
    {
      var saved = _context.SaveChanges();
      return saved > 0 ? true : false;
    }
  }
}