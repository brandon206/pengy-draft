using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PenguinDraft.Api.Dtos;
using PenguinDraft.Api.Models;
using AutoMapper;

namespace PenguinDraft.Api.Mapping
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Card, CardDto>();
    }
  }
}