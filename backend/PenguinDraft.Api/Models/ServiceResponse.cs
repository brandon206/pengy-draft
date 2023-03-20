using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PenguinDraft.Api.Models
{
  public class ServiceResponse<T>
  {
    public T? Data { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
  }
}