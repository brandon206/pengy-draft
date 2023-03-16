using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenguinDraft.Api.Dtos
{
  public class CardDto
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ManaCost { get; set; }
    public string? Type { get; set; }
    public string? Text { get; set; }
  }
}