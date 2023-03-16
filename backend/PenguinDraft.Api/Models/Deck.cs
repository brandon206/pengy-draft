using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenguinDraft.Api.Models
{
  public class Deck
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    // public virtual ICollection<Card> Cards { get; set; } = new List<Card>();
  }
}