using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PenguinDraft.Api.Dtos;
using PenguinDraft.Api.Interfaces;
using PenguinDraft.Api.Models;

namespace PenguinDraft.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CardsController : ControllerBase
  {
    private readonly ICardRepository _cardRepository;
    private readonly IMapper _mapper;

    public CardsController(ICardRepository cardRepository, IMapper mapper)
    {
      _cardRepository = cardRepository;
      _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Card>))]
    public IActionResult GetAllCards()
    {
      var cards = _mapper.Map<List<CardDto>>(_cardRepository.GetAllCards());

      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      return Ok(cards);
    }

    [HttpGet("{cardId}")]
    [ProducesResponseType(200, Type = typeof(Card))]
    [ProducesResponseType(400)]
    public IActionResult GetCardById(int cardId)
    {
      if (!_cardRepository.CardExists(cardId))
        return NotFound();

      var card = _mapper.Map<CardDto>(_cardRepository.GetCardById(cardId));

      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      return Ok(card);
    }
  }
}